using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Personel_Takip
{
    class DbClass
    {
        public static string baglantıadresi = @"Data Source=localhost\SQLEXPRESS;Initial catalog=INKA;user id=sa;password=123";
       
        SqlConnection baglantıprotokolü = new SqlConnection();
        public DbClass()
        {
            baglantıprotokolü.ConnectionString = baglantıadresi;
        }
          
        public DataTable GetTable(string sql,params SqlParameter[] prms)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = baglantıprotokolü;
            if (prms!=null)
            {
                cmd.Parameters.AddRange(prms);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void ExecuteSql(string sql, params SqlParameter[] prms)
        {
            SqlCommand cmd = new SqlCommand(sql,baglantıprotokolü);
            if (prms != null)
            {
                cmd.Parameters.AddRange(prms);
            }
            if (baglantıprotokolü.State==ConnectionState.Closed)
            {
                baglantıprotokolü.Open();
            }
            try
            {
                cmd.ExecuteNonQuery();
            }
            
            finally
            {
                baglantıprotokolü.Close();
            }
        }
        //public SqlDataReader ExecuteReader(string sql, SqlParameter[] prms)
        //{
        //    SqlDataReader dr = null;
        //    SqlCommand cmd = new SqlCommand(sql, baglantıprotokolü);
        //    if (prms != null)
        //    {
        //        cmd.Parameters.AddRange(prms);
        //    }
        //    if (baglantıprotokolü.State == ConnectionState.Closed)
        //    {
        //        baglantıprotokolü.Open();
        //    }
        //    dr = cmd.ExecuteReader();
        //    return dr;
        //}
    }
}

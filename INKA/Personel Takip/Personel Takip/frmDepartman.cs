using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip
{
    public partial class frmDepartman : Form
    {
        DbClass db = new DbClass();
        string sqldepartman = "SELECT * FROM DEPARTMAN";
        int satirno = -1;
        
        public frmDepartman()
        {
            InitializeComponent();
        }
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = db.GetTable(sqldepartman);
           
        }
        
        
        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                satirno = e.RowIndex;
                KayitGoster();
            }
            catch
            { }
        }
        void KayitGoster()
        {
            if (satirno>-1)
            {
                txtDEPARTMANID.Text = dataGridView1.Rows[satirno].Cells["DEPARTMAN_ID"].Value.ToString();
                txtDEPARTMANADI.Text = dataGridView1.Rows[satirno].Cells["DEPARTMAN_ADI"].Value.ToString();
               
            }
        }

        private void  btnYeni_Click(object sender, EventArgs e)
        {
            txtDEPARTMANID.Text =" ";
            txtDEPARTMANADI.Text =" ";
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           
            if (txtDEPARTMANID != null)
            {
                SqlParameter p1 = new SqlParameter("@P1", txtDEPARTMANID.Text);
                SqlParameter p2 = new SqlParameter("@P2", txtDEPARTMANADI.Text);
                string sql = "";
                if (txtDEPARTMANID.Text != " ")
                {
                    sql = "UPDATE DEPARTMAN SET DEPARTMAN_ADI=@P2 ";
                    sql += " WHERE DEPARTMAN_ID=@P1";
                }
                else
                {
                    sql = "INSERT INTO DEPARTMAN(DEPARTMAN_ADI)";
                    sql += "VALUES(@P2)";
                }
                db.ExecuteSql(sql, p1, p2);
                dataGridView1.DataSource = db.GetTable(sqldepartman);
               
            }
        }
       
        
        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            KayitGoster();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Silinsin mi","Dikkat",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question,
                                              MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                SqlParameter p1 = new SqlParameter("@P1",txtDEPARTMANID.Text);
                if ( txtDEPARTMANID.Text!="")
                {
                    string sql="DELETE FROM DEPARTMAN WHERE DEPARTMAN_ID=@P1";
                    try
                    {
                        db.ExecuteSql(sql,p1);
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                    dataGridView1.DataSource=db.GetTable(sqldepartman);
                }
            }
           
        }
    }
}

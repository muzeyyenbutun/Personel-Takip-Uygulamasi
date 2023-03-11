using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Personel_Takip
{
    public partial class frmHarekettipi : Form
    {
        DbClass db = new DbClass();
        string sqlharekettipi = "SELECT * FROM HAREKET_TIPI";
        int satirno = -1;
        
        public frmHarekettipi()
        {
            InitializeComponent();
        }

        private void FrmHarekettipi_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = db.GetTable(sqlharekettipi);
           
        }
        
       
        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            satirno = e.RowIndex;
            KayitGoster();
        }
        void KayitGoster()
        {
            txtHAREKETTIPIID.Text = dataGridView1.Rows[satirno].Cells["HAREKET_TIPI_ID"].Value.ToString();
            txtHAREKETTIPIADI.Text = dataGridView1.Rows[satirno].Cells["HAREKET_ADI"].Value.ToString();
            
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
           
            txtHAREKETTIPIID.Text =" ";
            txtHAREKETTIPIADI.Text =" ";
           
        }
      
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtHAREKETTIPIID != null)
            {
                SqlParameter p1 = new SqlParameter("@P1", txtHAREKETTIPIID.Text);
                SqlParameter p2 = new SqlParameter("@P2", txtHAREKETTIPIADI.Text);
                string sql = "";
                if (txtHAREKETTIPIID.Text != " ")
                {
                    sql = "UPDATE HAREKET_TIPI SET HAREKET_ADI=@P2 ";
                    sql += " WHERE HAREKET_TIPI_ID=@P1";
                }
                else
                {
                    sql = "INSERT INTO HAREKET_TIPI(HAREKET_ADI)";
                    sql += "VALUES(@P2)";
                }
                db.ExecuteSql(sql, p1, p2);
                dataGridView1.DataSource = db.GetTable(sqlharekettipi);

            }

        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            KayitGoster();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Silinsin mi?", "Dikkat",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question,
                                             MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.Yes)
            {
                SqlParameter p1 = new SqlParameter("@P1", txtHAREKETTIPIID.Text);
                if (txtHAREKETTIPIID.Text!= "")
                {
                    string sql = "DELETE FROM HAREKET_TIPI WHERE HAREKET_TIPI_ID=@P1";
                    try
                    {
                        db.ExecuteSql(sql, p1);
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                    dataGridView1.DataSource =db.GetTable(sqlharekettipi);
                }
            }

        }
    }
}

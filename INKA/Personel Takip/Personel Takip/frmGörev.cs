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
    public partial class frmGörev : Form
    {
        DbClass db = new DbClass();
        string sqlgorev = "SELECT * FROM GOREV";
        int satirno = -1;
       
        public frmGörev()
        {
            InitializeComponent();
        }

        private void FrmGörev_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = db.GetTable(sqlgorev);
            
        }
        
        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            satirno = e.RowIndex;
            KayitGoster();
        }
        void KayitGoster()
        {
            if (satirno > -1)
            {
                txtGOREVID.Text = dataGridView1.Rows[satirno].Cells["GOREV_ID"].Value.ToString();
                txtGOREVADI.Text = dataGridView1.Rows[satirno].Cells["GOREV_ADI"].Value.ToString();
            }
            
            
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtGOREVID.Text =" ";
            txtGOREVADI.Text =" ";
           
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtGOREVID != null)
            {
                SqlParameter p1 = new SqlParameter("@P1", txtGOREVID.Text);
                SqlParameter p2 = new SqlParameter("@P2", txtGOREVADI.Text);
                string sql = "";
                if (txtGOREVID.Text != " ")
                {
                    sql = "UPDATE GOREV SET GOREV_ADI=@P2 ";
                    sql += " WHERE GOREV_ID=@P1";
                }
                else
                {
                    sql = "INSERT INTO GOREV(GOREV_ADI)";
                    sql += "VALUES(@P2)";
                }
                db.ExecuteSql(sql, p1, p2);
                dataGridView1.DataSource = db.GetTable(sqlgorev);

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
                SqlParameter p1 = new SqlParameter("@P1", txtGOREVID.Text);
                if (txtGOREVID.Text!= "")
                {
                    string sql = "DELETE FROM GOREV WHERE GOREV_ID=@P1";
                    try
                    {
                        db.ExecuteSql(sql, p1);
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                    dataGridView1.DataSource=db.GetTable(sqlgorev);
                }
            }
           
        }

        
    

    }
}

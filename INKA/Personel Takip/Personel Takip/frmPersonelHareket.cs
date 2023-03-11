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

    public partial class txtHarekettıpıAdı : Form
    {
        DbClass db = new DbClass();
        int satirno = -1;
        string sqlpershar = "SELECT * FROM PERS_HAR";

        public txtHarekettıpıAdı()
        {
            InitializeComponent();
        }

        private void FrmPersonelHareket_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.GetTable(sqlpershar);
            Genel.ComboDoldur(cmbHareketAdı, "SELECT * FROM HAREKET_TIPI", "HAREKET_ADI", "HAREKET_TIPI_ID");
            Genel.ComboDoldur(cmbPersonelId, "SELECT * FROM PERSONEL", "ADI_SOYADI", "PERSONEL_ID"); 
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                satirno = e.RowIndex;
                KayitGoster();
            }
            catch
            {}
        }
        void KayitGoster()
        {
            if (satirno>-1)
            {
                txtAlacak.Text = dataGridView1.Rows[satirno].Cells["ALACAK"].Value.ToString();
                txtBorc.Text = dataGridView1.Rows[satirno].Cells["BORC"].Value.ToString();
                cmbHareketAdı.SelectedValue= dataGridView1.Rows[satirno].Cells["HAREKET_TIPI_ID"].Value.ToString();
                txtPersHarId.Text= dataGridView1.Rows[satirno].Cells["PERSONEL_ID"].Value.ToString();
                cmbPersonelId.SelectedValue= dataGridView1.Rows[satirno].Cells["PERSONEL_ID"].Value.ToString();
                Tarih.Value=Convert.ToDateTime(dataGridView1.Rows[satirno].Cells["TARIH"].Value.ToString());
            }
        }

        private void BtnYeni_Click(object sender, EventArgs e)
        {
            txtAlacak.Text ="";
            txtBorc.Text = "";
            cmbHareketAdı.SelectedIndex =-1;
            txtPersHarId.Text = "";
            cmbPersonelId.SelectedIndex = -1;
            Tarih.Value=DateTime.Now;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlParameter p1 = new SqlParameter("@P1", Convert.ToInt32(txtAlacak.Text));
            SqlParameter p2 = new SqlParameter("@P2", Convert.ToInt32(txtBorc.Text));
            SqlParameter p3 = new SqlParameter("@P3", cmbHareketAdı.SelectedValue);
            SqlParameter p4 = new SqlParameter("@P4", txtPersHarId.Text);
            SqlParameter p5 = new SqlParameter("@P5", cmbPersonelId.SelectedValue);
            //SqlParameter p6 = new SqlParameter("@P6", cmbHareketAdı.SelectedValue);
            //SqlParameter p7 = new SqlParameter("@P7", cmbADSOYAD.SelectedValue);
            SqlParameter p8 = new SqlParameter("@P8", Tarih.Value);
            string sql = "";
            if (txtPersHarId.Text != " ")
            {
                sql = "UPDATE PERS_HAR SET ALACAK=@P1,BORC=@P2,HAREKET_TIPI_ID=@P3,PERSONEL_ID=@P5,";
                sql += "TARIH=@P8";
                sql += " WHERE PER_HAR_ID=@P4";
            }

            else
            {
                sql = "INSERT INTO PERSONEL(ALACAK,BORC,HAREKET_TIPI_ID,PERSONEL_ID,ADI_SOYADI,TARİH)";
                sql += "VALUES(@P1,@P2,@P3,@P5,@P8)";
            }
            db.ExecuteSql(sql, p1, p2, p3, p4, p5, p8);
            dataGridView1.DataSource = db.GetTable(sqlpershar);

        }

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            KayitGoster();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Silinsin mi?", "Dikkat",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question,
                                           MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                SqlParameter p1 = new SqlParameter("@P1", txtPersHarId.Text);
                if (txtPersHarId.Text != "")
                {
                    string sql = "DELETE FROM PERS_HAR WHERE PER_HAR_ID=@P1";
                    try
                    {
                        db.ExecuteSql(sql, p1);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata oluştu...");
                    }
                    dataGridView1.DataSource = db.GetTable(sqlpershar);
                }
            }
        }

      
    }
}

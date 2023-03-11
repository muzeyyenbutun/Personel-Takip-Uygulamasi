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
    public partial class frmKullanıcılar : Form
    {
        DbClass db = new DbClass();
        string sqlkullanici = "SELECT * FROM Admin";
        int satirno = -1;
        public frmKullanıcılar()
        {
            InitializeComponent();
        }

        private void FrmKullanıcılar_Load(object sender, EventArgs e)
        {
            gridKullanici.DataSource = db.GetTable(sqlkullanici);
        }

       

        private void BtnYENİ_Click(object sender, EventArgs e)
        {
            txtKULLANICI_ID.Text = "";
            txtKULLANICI_ADI.Text = "";
            txtSIFRE.Text = "";
        }

        private void BtnKAYDET_Click_1(object sender, EventArgs e)
        {
            if (txtKULLANICI_ID != null)
            {
                SqlParameter p1 = new SqlParameter("@P1", txtKULLANICI_ID.Text);
                SqlParameter p2 = new SqlParameter("@P2", txtKULLANICI_ADI.Text);
                SqlParameter p3 = new SqlParameter("@P3", txtSIFRE.Text);


                string sql = " ";
                if (txtKULLANICI_ID.Text != "")
                {

                    sql ="UPDATE Admin SET KullaniciAdi=@P2,Parola=@P3 WHERE AdminId=@P1 ";
                }
                else
                {
                    sql ="INSERT INTO Admin(KullaniciAdi,Parola)VALUES(@P2,@P3) ";

                }
                db.ExecuteSql(sql, p1, p2, p3);
                gridKullanici.DataSource = db.GetTable(sqlkullanici);

            }
        }

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            KayitGoster();
        }
        void KayitGoster()
        {
            if (satirno > -1)
            {
                txtKULLANICI_ADI.Text = gridKullanici.Rows[satirno].Cells["KullaniciAdi"].Value.ToString();
                txtKULLANICI_ID.Text = gridKullanici.Rows[satirno].Cells["AdminId"].Value.ToString();
                txtSIFRE.Text = gridKullanici.Rows[satirno].Cells["Parola"].Value.ToString();
            }
        }

        private void BtnSil_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Silinsin mi?", "Dikkat",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                SqlParameter p1 = new SqlParameter("@P1", txtKULLANICI_ID.Text);
                if (txtKULLANICI_ID.Text != "")
                {
                    string sqlsil = "DELETE FROM Admin WHERE AdminId=@P1";
                    try
                    {
                        db.ExecuteSql(sqlsil, p1);
                    }
                    catch (Exception hata)
                    {

                        MessageBox.Show(hata.Message);
                    }

                    gridKullanici.DataSource = db.GetTable(sqlkullanici);
                }
            }
        }

        private void GridKullanici_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                satirno = e.RowIndex;
                KayitGoster();
            }
            catch
            { }
        }
    }
}

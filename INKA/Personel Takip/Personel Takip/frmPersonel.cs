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
    public partial class frmPersonel : Form
    {
        DbClass db = new DbClass();
        string sqlpersonel = " SELECT * FROM PERSONEL";
        int satirno = -1;
      
        public frmPersonel()
        {
            InitializeComponent();
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
          
            dataGridView1.DataSource = db.GetTable(sqlpersonel);
            //string sql = "SELECT 1 AS DURUMU,'Aktif' Durumu";
            //sql += " UNION ";
            //sql += "SELECT 0 AS Durumu,'Pasif' Durumu";
            //Genel.ComboDoldur(cmbDURUMU,sql,"Durumu","DURUMU");
            Genel.ComboDoldur(cmbDepartmanId, "SELECT * FROM DEPARTMAN", "DEPARTMAN_ADI", "DEPARTMAN_ID");
            Genel.ComboDoldur(cmbGorevId, "SELECT * FROM GOREV", "GOREV_ADI", "GOREV_ID");
            DataGridViewButtonColumn dgvBtn = new DataGridViewButtonColumn();
            dgvBtn.Name = "Detay";
            dgvBtn.HeaderText = "Hareket Detay";
            dgvBtn.Text = "Detay Getir";
            dgvBtn.UseColumnTextForButtonValue = true;
            dgvBtn.DefaultCellStyle.BackColor = Color.Blue;
            dgvBtn.DefaultCellStyle.SelectionBackColor = Color.Red;
            dgvBtn.Width = 70;
            dataGridView1.Columns.Add(dgvBtn);
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
                txtADISOYADI.Text = dataGridView1.Rows[satirno].Cells["ADI_SOYADI"].Value.ToString();
                txtADRES.Text = dataGridView1.Rows[satirno].Cells["ADRES"].Value.ToString();
                cmbDepartmanId.SelectedValue = dataGridView1.Rows[satirno].Cells["DEPARTMAN_ID"].Value.ToString();
                int DURUMU = (dataGridView1.Rows[satirno].Cells["DURUMU"].Value.ToString() == "TRUE") ? 1 : 0;
                chkDurumu.Checked = Convert.ToBoolean(dataGridView1.Rows[satirno].Cells["DURUMU"].Value.ToString());
                txtEPOSTA.Text = dataGridView1.Rows[satirno].Cells["EPOSTA"].Value.ToString();
                cmbGorevId.SelectedValue=dataGridView1.Rows[satirno].Cells["GOREV_ID"].Value.ToString();
                txtMAAŞ.Text =dataGridView1.Rows[satirno].Cells["MAAS"].Value.ToString();
                txtPERSONELID.Text = dataGridView1.Rows[satirno].Cells["PERSONEL_ID"].Value.ToString();
                txtTELEFON.Text=dataGridView1.Rows[satirno].Cells["TELEFON"].Value.ToString();
                txtİLÇE.Text = dataGridView1.Rows[satirno].Cells["ILCE"].Value.ToString();
                txtŞEHİR.Text = dataGridView1.Rows[satirno].Cells["SEHIR"].Value.ToString();
                GİRİŞTARİHİ.Value =Convert.ToDateTime(dataGridView1.Rows[satirno].Cells["GIRIS_TARIHI"].Value.ToString());
                txtAyrılısTarıhı.Text=dataGridView1.Rows[satirno].Cells["AYRILIS_TARIHI"].Value.ToString();
            }

           
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtADISOYADI.Text =" ";
            txtADRES.Text =" ";
            cmbDepartmanId.SelectedValue = -1;
            chkDurumu.Checked = false;
            txtEPOSTA.Text =" ";
            cmbGorevId.SelectedValue = -1;
            txtMAAŞ.Text =" ";
            txtPERSONELID.Text =" ";
            txtTELEFON.Text =" ";
            txtİLÇE.Text =" ";
            txtŞEHİR.Text =" ";
            GİRİŞTARİHİ.Value = DateTime.Now;
            txtAyrılısTarıhı.Text = "";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtPERSONELID.Text != null)
            {
                SqlParameter p1 = new SqlParameter("@P1", txtPERSONELID.Text);
                SqlParameter p2 = new SqlParameter("@P2", txtADISOYADI.Text);
                SqlParameter p3 = new SqlParameter("@P3", txtADRES.Text);
                SqlParameter p4 = new SqlParameter("@P4", cmbDepartmanId.SelectedValue);
                SqlParameter p5 = new SqlParameter("@P5", chkDurumu.Checked);
                SqlParameter p6 = new SqlParameter("@P6", txtEPOSTA.Text);
                SqlParameter p7 = new SqlParameter("@P7", cmbGorevId.SelectedValue);
                SqlParameter p8 = new SqlParameter("@P8", txtMAAŞ.Text);
                SqlParameter p9 = new SqlParameter("@P9", txtTELEFON.Text);
                SqlParameter p10 = new SqlParameter("@P10", txtİLÇE.Text);
                SqlParameter p11 = new SqlParameter("@P11", txtŞEHİR.Text);
             
                SqlParameter p12 = new SqlParameter("@P12",GİRİŞTARİHİ.Value);
                
                SqlParameter p13 = new SqlParameter("@P13",txtAyrılısTarıhı.Text);
                string sql = "";
                if (txtPERSONELID.Text != " ")
                {
                    sql = "UPDATE PERSONEL SET ADI_SOYADI=@P2,ADRES=@P3,DEPARTMAN_ID=@P4,DURUMU=@P5,EPOSTA=@P6,GOREV_ID=@P7,";
                    sql += "MAAS=@P8,TELEFON=@P9,ILCE=@P10,SEHIR=@P11,GIRIS_TARIHI=@P12,AYRILIS_TARIHI=@P13";
                    sql+= " WHERE PERSONEL_ID=@P1";
                }

                else
                {
                    sql = "INSERT INTO PERSONEL(ADI_SOYADI,ADRES,DEPARTMAN_ID,DURUMU,EPOSTA,GOREV_ID,MAAS,TELEFON,ILCE,SEHIR,GIRIS_TARIHI,AYRILIS_TARIHI)";
                    sql += "VALUES(@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12,@P13)";
                }
                db.ExecuteSql(sql, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11,p12,p13);
                dataGridView1.DataSource = db.GetTable(sqlpersonel);


            }
        }
        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            KayitGoster();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Silinsin mi?", "Dikkat",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.Yes)
            {
                SqlParameter p1 = new SqlParameter("@P1", txtPERSONELID.Text);
                if (txtPERSONELID.Text!="")
                {
                    string sql = "DELETE FROM PERSONEL WHERE PERSONEL_ID=@P1";
                    try
                    {
                        db.ExecuteSql(sql, p1);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata oluştu...");
                    }
                    dataGridView1.DataSource = db.GetTable(sqlpersonel);
                }
            }
           
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==dataGridView1.Columns["Detay"].Index)
            {
                frmPers_Har_Detay f1 = new frmPers_Har_Detay();
                int id = Convert.ToInt32(dataGridView1.Rows[satirno].Cells["PERSONEL_ID"].Value);
                string sqlform ="SELECT P.ADI_SOYADI,PH.TARIH,PH.BORC,PH.ALACAK,HAREKET_ADI FROM PERS_HAR PH INNER JOIN PERSONEL P ON P.PERSONEL_ID = PH.PERSONEL_ID INNER JOIN HAREKET_TIPI H ON H.HAREKET_TIPI_ID = PH.HAREKET_TIPI_ID WHERE P.PERSONEL_ID=" + id;
                SqlParameter p1 = new SqlParameter("@P1", id);
                f1.gridDetay.DataSource= db.GetTable(sqlform, p1);
                //f1.label2.Text = id.ToString();
                f1.ShowDialog();
                f1.Dispose();


            }
        }
    }
}

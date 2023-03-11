using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip
{
   
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmDepartman f2 = new frmDepartman();
            f2.ShowDialog();
            f2.Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmPersonel f3 = new frmPersonel();
            f3.ShowDialog();
            f3.Dispose();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            frmRaporlar f4 = new frmRaporlar();
            f4.ShowDialog();
            f4.Dispose();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmGörev f5 = new frmGörev();
            f5.ShowDialog();
            f5.Dispose();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
           txtHarekettıpıAdı f6 = new txtHarekettıpıAdı();
            f6.ShowDialog();
            f6.Dispose();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PERSONEL TAKİP PROGRAMIMIZA HOŞGELDİNİZ..." +"\n"+
                "ALT MENÜLERDEN HERHANGİ BİRİNİ SEÇEREK İŞLEM YAPABİLİRSİNİZ.");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            frmGiriş frm = new frmGiriş();
            frm.ShowDialog();
            if (frmGiriş.Sonuc)
            {

            }
            else
                Application.Exit();
        }

        private void BtnKullanıcılar_Click(object sender, EventArgs e)
        {
            frmKullanıcılar f5 = new frmKullanıcılar();
            f5.ShowDialog();
            f5.Dispose();
        }
    }
}

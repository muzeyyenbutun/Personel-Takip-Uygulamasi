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
    public partial class frmRaporlar : Form
    {
        DbClass db = new DbClass();
        int satirno = -1;
        public frmRaporlar()
        {
            InitializeComponent();
        }
        private void BtnSorgu1_Click(object sender, EventArgs e)
        { //8.Çalışan Personel Listesini alınız.(son maaşlara göre)

           
            string sqlsorgu1 = "SELECT P.ADI_SOYADI, PH.TARIH, PH.BORC,PH.ALACAK, HAREKET_ADI FROM PERS_HAR PH INNER JOIN PERSONEL P ON P.PERSONEL_ID = PH.PERSONEL_ID INNER JOIN HAREKET_TIPI H ON H.HAREKET_TIPI_ID = PH.HAREKET_TIPI_ID WHERE P.PERSONEL_ID";
            dataGridView1.DataSource = db.GetTable(sqlsorgu1);
        }

        private void BtnSorgu2_Click(object sender, EventArgs e)
        {//9.Personele ödenecek toplam aylık maaşı bulan SQL kodunu yazınız.
            string sqlsorgu2 = "SELECT SUM(MAAS) AS TOPLAM FROM PERSONEL";
            dataGridView2.DataSource = db.GetTable(sqlsorgu2);
        }
        private void BtnSorgu3_Click_1(object sender, EventArgs e)
        {
            //10.Şu ana kadar, hangi personele toplam ne kadar para ödendi ve daha ne kadar para ödenecek SQL'ini yazınız.
            string sqlsorgu3 = "SELECT PERSONEL.ADI_SOYADI,SUM(PERS_HAR.ALACAK) AS TOPLAM_ÖDENECEK,SUM(PERS_HAR.BORC) AS TOPLAM_ODENEN FROM PERSONEL JOIN PERS_HAR ON PERS_HAR.PERSONEL_ID=PERSONEL.PERSONEL_ID GROUP BY PERSONEL.ADI_SOYADI";
            dataGridView4.DataSource = db.GetTable(sqlsorgu3);
        }

        private void BtnSorgu4_Click(object sender, EventArgs e)
        {//11.Firmanın şu ana kadar ödediği toplam ücret ve ödeyeceği toplam ücreti bulan SQL kodunu yazınız.
            string sqlsorgu4 = "SELECT SUM(BORC) AS TOPLAM_ODENEN,SUM(BORC)-SUM(ALACAK) AS TOPLAM_ODENECEK FROM PERS_HAR ";
            dataGridView5.DataSource = db.GetTable(sqlsorgu4);
        }

        private void BtnSorgu5_Click(object sender, EventArgs e)
        {//12.Aldığı ücret 2000 TL'nin üstünde olan personelin listesini bulunuz.
            string sqlsorgu5 = "SELECT ADI_SOYADI,TELEFON AS CEPTEL,MAAS,GOREV.GOREV_ADI,DEPARTMAN.DEPARTMAN_ADI FROM PERSONEL JOIN GOREV ON PERSONEL.GOREV_ID = GOREV.GOREV_ID JOIN DEPARTMAN ON GOREV.GOREV_ID = DEPARTMAN.DEPARTMAN_ID";
            dataGridView6.DataSource = db.GetTable(sqlsorgu5);
        }

        private void BtnSorgu6_Click(object sender, EventArgs e)
        {//13.Herbir departmandaki ortalama maaşı bulan SQL'i yazınız.
            string sqlsorgu6 = "SELECT DEPARTMAN.DEPARTMAN_ADI,AVG(MAAS) AS ORT_MAAS FROM DEPARTMAN JOIN PERSONEL ON DEPARTMAN.DEPARTMAN_ID=PERSONEL.DEPARTMAN_ID GROUP BY DEPARTMAN.DEPARTMAN_ADI";
            dataGridView7.DataSource = db.GetTable(sqlsorgu6);
        }

        private void BtnSorgu7_Click(object sender, EventArgs e)
        {//14.Herhangi bir departmanda çalışmayan personel listesini bulunuz.
            string sqlsorgu7 = "SELECT * FROM PERSONEL A JOIN GOREV B ON  A.GOREV_ID=B.GOREV_ID  WHERE A.DEPARTMAN_ID IS NULL";
            dataGridView8.DataSource = db.GetTable(sqlsorgu7);
        }

        private void BtnSorgu8_Click(object sender, EventArgs e)
        {//16.Çalışanı olmayan departmanların listesini bulunuz.
            string sqlsorgu8 = "SELECT DEPARTMAN_ADI FROM DEPARTMAN WHERE DEPARTMAN.DEPARTMAN_ID NOT IN(SELECT PERSONEL.DEPARTMAN_ID FROM PERSONEL WHERE DEPARTMAN.DEPARTMAN_ID = PERSONEL.DEPARTMAN_ID)";
            dataGridView9.DataSource = db.GetTable(sqlsorgu8);
        }

        private void BtnSorgu9_Click(object sender, EventArgs e)
        {//17.Hangi departmanda ne kadar personel var listesini bulunuz
            string sqlsorgu9 = "SELECT DEPARTMAN.DEPARTMAN_ADI,COUNT(PERSONEL_ID) AS ÇALIŞAN_SAYISI FROM DEPARTMAN JOIN PERSONEL ON DEPARTMAN.DEPARTMAN_ID=PERSONEL.DEPARTMAN_ID GROUP BY DEPARTMAN.DEPARTMAN_ADI ";
            dataGridView3.DataSource = db.GetTable(sqlsorgu9);
        }

        private void BtnSorgu10_Click(object sender, EventArgs e)
        {//18.Ortalama Maaşı 2000 TL nin üzerinde olan departmanların listesini bulunuz.
            string sqlsorgu10 = "SELECT DEPARTMAN_ADI,AVG(MAAS) AS ORT_MAAS FROM DEPARTMAN JOIN PERSONEL ON DEPARTMAN.DEPARTMAN_ID = PERSONEL.DEPARTMAN_ID GROUP BY DEPARTMAN_ADI HAVING AVG(PERSONEL.MAAS) > 2000";
            dataGridView10.DataSource = db.GetTable(sqlsorgu10);
        }

        private void BtnSorgu11_Click(object sender, EventArgs e)
        {//19.Hangi eleman kaç aydır çalışıyor listesiniz bulunuz
            string sqlsorgu11 = "SELECT ADI_SOYADI,DATEDIFF(month,GIRIS_TARIHI,GETDATE()) AS AY FROM PERSONEL WHERE PERSONEL_ID in (1,2,3,4,8,13)";
            dataGridView11.DataSource = db.GetTable(sqlsorgu11);
        }

        private void BtnSorgu12_Click(object sender, EventArgs e)
        {//20.Bütün Personel ve Bütün departmanların listesini bulunuz.
            string sqlsorgu12 = "SELECT PERSONEL.ADI_SOYADI,DEPARTMAN.DEPARTMAN_ADI FROM PERSONEL FULL OUTER JOIN DEPARTMAN ON PERSONEL.DEPARTMAN_ID = DEPARTMAN.DEPARTMAN_ID";
            dataGridView12.DataSource = db.GetTable(sqlsorgu12);
        }

       
    }
}

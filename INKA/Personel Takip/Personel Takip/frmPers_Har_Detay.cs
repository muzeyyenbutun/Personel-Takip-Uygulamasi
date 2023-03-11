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
    public partial class frmPers_Har_Detay : Form
    {
        DbClass db = new DbClass();
        public static int idp = 0;
        //string sqlpershareketleri = "SELECT * FROM PERS_HAR";
        public frmPers_Har_Detay()
        {
            InitializeComponent();
        }

        private void FrmPers_Har_Detay_Load(object sender, EventArgs e)
        {
            //gridDetay.DataSource = db.GetTable(sqlpershareketleri);
        }
    }
}

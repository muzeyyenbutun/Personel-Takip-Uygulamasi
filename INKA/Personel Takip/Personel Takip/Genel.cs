using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip
{
    class Genel
    {
        public static void ComboDoldur(ComboBox cmb,string sql,string gorunen,string deger)
        {
            DbClass db = new DbClass();
            DataTable dt = db.GetTable(sql);
            cmb.DisplayMember = gorunen;
            cmb.ValueMember = deger;
            cmb.DataSource = dt;
        }
    }
}

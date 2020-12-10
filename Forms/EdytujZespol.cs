using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_deweloperska_2.Forms
{
    public partial class EdytujZespol : Form
    {
        private firma_deweloperska_3Entities db = new firma_deweloperska_3Entities();
        public string global_x;
        public EdytujZespol(string x)
        {
            global_x = x;
            InitializeComponent();
            inputNazwaZespolu.Text = x;
        }

        private void inputNazwaZespolu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdytujZespol_Click(object sender, EventArgs e)
        {
            db.ZESPOLies.Find(global_x).ZESP_NAZWA = inputNazwaZespolu.Text;
            this.Close();
            db.SaveChanges();
        }
    }
}

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
    public partial class DodajZespol : Form
    {
        private firma_deweloperska_3Entities db = new firma_deweloperska_3Entities();
        public DodajZespol()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajZespol_Click(object sender, EventArgs e)
        {
            ZESPOLY nowy = new ZESPOLY();
            nowy.ZESP_NAZWA = inputNazwaZespolu.Text;
            db.ZESPOLies.Add(nowy);
            db.SaveChanges();  
            this.Close();
        }
    }
}

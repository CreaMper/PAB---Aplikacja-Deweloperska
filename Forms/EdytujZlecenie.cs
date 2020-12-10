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
    public partial class EdytujZlecenie : Form
    {
        private firma_deweloperska_3Entities db = new firma_deweloperska_3Entities();
        private int id = 0;
        public EdytujZlecenie(int x)
        {
            id = x;
            InitializeComponent();

            var query = (from z in db.ZESPOLies join zc in db.ZLECENIAs on z.ZESP_ID equals zc.ZESP_ID join p in db.PRIORYTETies on zc.PRIO_ID equals p.PRIO_ID select new { Numer = zc.ZLEC_ID, Priorytet = p.PRIO_NAZWA, Zespół = z.ZESP_NAZWA, Zrealizowano = zc.ZLEC_ZAKONCZONO, Rozpoczęto = zc.ZLEC_ROZPOCZECIE, Opis = zc.ZLEC_OPIS }).ToList();
            dataGridView1.DataSource = query;

            numer.Text = dataGridView1.SelectedRows[0].Cells["Numer"].Value.ToString();
/*            priorytet.Text = db.ZLECENIAs.Find(x).PRIO_ID.ToString();
            zespol.Text = db.ZLECENIAs.Find(x).ZLEC.ToString();
            ukonczono.Text = db.ZLECENIAs.Find(x).PRAC_TELEFON.ToString();
            dodaj_email.Text = db.PRACOWNICies.Find(x).PRAC_EMAIL.ToString();
            dodaj_adres.Text = db.PRACOWNICies.Find(x).PRAC_ADRES;
            dodaj_stanowisko.Text = db.PRACOWNICies.Find(x).PRAC_STANOWSKO;*/
        }

        private void dodajTelefon_Click(object sender, EventArgs e)
        {

        }

        private void zespol_TextChanged(object sender, EventArgs e)
        {

        }

        private void EdytujZlecenie_Load(object sender, EventArgs e)
        {

        }
    }
}

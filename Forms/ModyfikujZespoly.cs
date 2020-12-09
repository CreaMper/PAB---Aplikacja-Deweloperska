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
    public partial class ModyfikujZespoly : Form
    {
        private firma_deweloperska_3Entities db = new firma_deweloperska_3Entities();

        public ModyfikujZespoly()
        {
            InitializeComponent();

            var query = (from z in db.ZESPOLies select z.ZESP_NAZWA).Distinct().ToList();
            cboZespoly.DataSource = query;
            cboZespoly.DisplayMember = "ZESP_NAZWA";
            cboZespoly.Text = null;
            dtgrdZlecenia.Hide();
            dtgrdZespoly.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboZespoly_SelectedIndexChanged(object sender, EventArgs e)
        {
            var zespol = cboZespoly.Text;
            var query = (from z in db.ZESPOLies join p in db.PRACOWNICies on z.ZESP_ID equals p.ZESP_ID where z.ZESP_NAZWA == zespol select new { Imie = p.PRAC_IMIE, Nazwisko = p.PRAC_NAZWISKO, Stanowisko = p.PRAC_STANOWSKO }).ToList();
            dtgrdZespoly.DataSource = query;
            dtgrdZespoly.Show();

            var zlecenia = (from z in db.ZLECENIAs join zp in db.ZESPOLies on z.ZESP_ID equals zp.ZESP_ID where zp.ZESP_NAZWA == zespol select new { Zlecenie = z.ZLEC_ID, Ukonczone =z.ZLEC_ZAKONCZONO , Priorytet = z.PRIORYTETY, Rozpoczecie = z.ZLEC_ROZPOCZECIE, Opis = z.ZLEC_OPIS}).ToList();
            dtgrdZlecenia.DataSource = zlecenia;
            dtgrdZlecenia.Show();

        }

        private void dtgrdZlecenia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgrdZespoly_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

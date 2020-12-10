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

namespace Aplikacja_deweloperska_2.Forms
{
    public partial class ModyfikujZespoly : Form
    {
        private firma_deweloperska_3Entities db = new firma_deweloperska_3Entities();

        public ModyfikujZespoly()
        {
            InitializeComponent();

            AktualizujDropdown();
            cboZespoly.Text = null;
            dtgrdZlecenia.Hide();
            dtgrdZespoly.Hide();
            btnPrzypiszPracownika.Hide();
            btnUsunPracownikaZespol.Hide();

        }

        private void AktualizujDropdown()
        {
            var query = (from z in db.ZESPOLies select z.ZESP_NAZWA).Distinct().ToList();
            cboZespoly.DataSource = query;
            cboZespoly.DisplayMember = "ZESP_NAZWA";
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
            var query = (from z in db.ZESPOLies join p in db.PRACOWNICies on z.ZESP_ID equals p.ZESP_ID where z.ZESP_NAZWA == zespol select new { PRAC_Id = p.PRAC_ID, Imie = p.PRAC_IMIE, Nazwisko = p.PRAC_NAZWISKO, Stanowisko = p.PRAC_STANOWSKO }).ToList();
            dtgrdZespoly.DataSource = query;
            dtgrdZespoly.Columns["PRAC_Id"].Visible = false;
            dtgrdZespoly.Show();

            var zlecenia = (from z in db.ZLECENIAs join zp in db.ZESPOLies on z.ZESP_ID equals zp.ZESP_ID where zp.ZESP_NAZWA == zespol select new { Zlecenie = z.ZLEC_ID, Ukonczone =z.ZLEC_ZAKONCZONO , Priorytet = z.PRIORYTETY, Rozpoczecie = z.ZLEC_ROZPOCZECIE, Opis = z.ZLEC_OPIS}).ToList();
            dtgrdZlecenia.DataSource = zlecenia;
            dtgrdZlecenia.Show();

            btnPrzypiszPracownika.Show();
            btnUsunPracownikaZespol.Show();

        }

        private void dtgrdZlecenia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgrdZespoly_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDodajZespol_Click(object sender, EventArgs e)
        {
            var newForm = new DodajZespol();
            newForm.ShowDialog();
            db.SaveChanges();
            AktualizujDropdown();
        }

        private void btnEdytujZespol_Click(object sender, EventArgs e)
        {
            var zespol = cboZespoly.Text;
            if (zespol == "")
            {
                MessageBox.Show("Najpierw wybierz zespol!", "Whooooooooops", MessageBoxButtons.OK);
            }
            else
            {
                var newForm = new EdytujZespol(zespol);
                newForm.ShowDialog();
                db.SaveChanges();
                AktualizujDropdown();
            }
        }

        private void btnPrzypiszPracownika_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUsunPracownikaZespol_Click(object sender, EventArgs e)
        {
            var PRAC_ID = dtgrdZespoly.SelectedRows[0].Cells[0].Value.ToString();
            var odpowiedz = MessageBox.Show("Czy napewno chcesz usunąć tego pracownika z zespołu?", "Whooooooooops", MessageBoxButtons.YesNo);
            if (odpowiedz == DialogResult.Yes)
            {
                db.Database.ExecuteSqlCommand("UPDATE PRACOWNICY SET ZESP_ID = null WHERE PRAC_ID = " + PRAC_ID);
                db.SaveChanges();
                var zespol = cboZespoly.Text;
                var query = (from z in db.ZESPOLies join p in db.PRACOWNICies on z.ZESP_ID equals p.ZESP_ID where z.ZESP_NAZWA == zespol select new { PRAC_Id = p.PRAC_ID, Imie = p.PRAC_IMIE, Nazwisko = p.PRAC_NAZWISKO, Stanowisko = p.PRAC_STANOWSKO }).ToList();
                dtgrdZespoly.DataSource = query;
                dtgrdZespoly.Columns["PRAC_Id"].Visible = false;
            } 
        }
    }
}

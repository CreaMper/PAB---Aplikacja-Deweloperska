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
    public partial class DodajPracownikaZespol : Form
    {
        private firma_deweloperska_3Entities db = new firma_deweloperska_3Entities();
        public decimal global_id_zespolu;
        public DodajPracownikaZespol(decimal id_zespolu)
        {
            global_id_zespolu = id_zespolu;
            InitializeComponent();
            var query = (from p in db.PRACOWNICies where p.ZESP_ID == null select new { PRAC_Id = p.PRAC_ID, Imie = p.PRAC_IMIE, Nazwisko = p.PRAC_NAZWISKO, Stanowisko = p.PRAC_STANOWSKO }).ToList();
            dtgrdPracownicy.DataSource = query;
            dtgrdPracownicy.Columns["PRAC_Id"].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtgrdZespoly_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var PRAC_ID = dtgrdPracownicy.SelectedRows[0].Cells[0].Value.ToString();
            decimal id_zespolu = global_id_zespolu;
            db.Database.ExecuteSqlCommand("UPDATE PRACOWNICY SET ZESP_ID = "+ id_zespolu + " WHERE PRAC_ID = " + PRAC_ID);
            this.Close();
            db.SaveChanges();
        }
    }
}

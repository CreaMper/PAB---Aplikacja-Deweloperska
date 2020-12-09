using Aplikacja_deweloperska_2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_deweloperska_2
{
    public partial class PrzegladPracownikow : Form
    {
        private firma_deweloperska_2Entities db = new firma_deweloperska_2Entities();
        public PrzegladPracownikow()
        {
            InitializeComponent();

            bsPracownicy.DataSource = db.PRACOWNICies.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void btnPracownicyDodaj_Click(object sender, EventArgs e)
        {
            var newForm = new DodaPracownika();
            newForm.ShowDialog();
            db.SaveChanges();
            bsPracownicy.DataSource = db.PRACOWNICies.ToList();
        }

        private void pracownicy_edytuj_Click(object sender, EventArgs e)
        {
            var element = dtgdPracownicy.SelectedRows[0].Cells[0].Value.ToString();
            var newForm = new EdytujPracownika(int.Parse(element));
            newForm.ShowDialog();
            
            firma_deweloperska_2Entities db = new firma_deweloperska_2Entities();
            bsPracownicy.DataSource = db.PRACOWNICies.ToList();
            db.SaveChanges();
        }

        public void OdswiezBaze()
        {
            Console.WriteLine("asdas");
        }

        private void szczegolyPracownika_Click(object sender, EventArgs e)
        {
            var element = dtgdPracownicy.SelectedRows[0].Cells[0].Value.ToString();
            var newForm = new SzczegolyPracownika(int.Parse(element));
            newForm.ShowDialog();
        }

        private void pracownicyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void przegladToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new ModyfikujZespoly();
            newForm.ShowDialog();
        }
    }
}

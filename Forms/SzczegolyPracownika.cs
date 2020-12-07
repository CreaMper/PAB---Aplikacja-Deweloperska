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
    public partial class SzczegolyPracownika : Form
    {
        private firma_deweloperska_2Entities db = new firma_deweloperska_2Entities();
        private int id = 0;
        public SzczegolyPracownika(int x)
        {
            InitializeComponent();
            wYDATKIBindingSource.DataSource = db.WYDATKIs.Where(k => k.PRAC_ID == x).ToList();
            zESPOLYBindingSource.DataSource = db.ZESPOLies.ToList();
            lblImieAdd.Text = db.PRACOWNICies.Find(x).PRAC_IMIE;
            lblNazwiskoAdd.Text = db.PRACOWNICies.Find(x).PRAC_NAZWISKO;
            lblPeselAdd.Text = db.PRACOWNICies.Find(x).PRAC_PESEL;
            lblTelefonAdd.Text = db.PRACOWNICies.Find(x).PRAC_TELEFON;
            lblEmailAdd.Text = db.PRACOWNICies.Find(x).PRAC_EMAIL;
            lblAdressAdd.Text = db.PRACOWNICies.Find(x).PRAC_ADRES;
            lblStanowiskoAdd.Text = db.PRACOWNICies.Find(x).PRAC_STANOWSKO;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var element = wYDATKIBindingSource.Current as WYDATKI;
            if (element == null) {
                pRZEZNACZENIEBindingSource.DataSource = null;
            }
            pRZEZNACZENIEBindingSource.DataSource = db.PRZEZNACZENIEs.Where(k => k.WYD_ID == element.WYD_ID).ToList();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

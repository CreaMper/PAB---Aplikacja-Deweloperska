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
    public partial class DodaPracownika : Form
    {
        private firma_deweloperska_2Entities db = new firma_deweloperska_2Entities();
        public DodaPracownika()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnDodajPracownika_Click(object sender, EventArgs e)
        {
            PRACOWNICY nowy = new PRACOWNICY();
            nowy.PRAC_IMIE = dodaj_imie.Text;
            nowy.PRAC_NAZWISKO = dodaj_nazwisko.Text;
            nowy.PRAC_PESEL = dodaj_pesel.Text;
            nowy.PRAC_TELEFON = dodaj_telefon.Text;
            nowy.PRAC_EMAIL = dodaj_email.Text;
            nowy.PRAC_ADRES = dodaj_adres.Text;
            nowy.PRAC_STANOWSKO = dodaj_stanowisko.Text;

            db.PRACOWNICies.Add(nowy);

            db.SaveChanges();
            bsPracownicy.DataSource = db.PRACOWNICies.ToList();
            this.Close();
        }

        private void dodaj_umowa_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void DodaPracownika_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }
        
    }
}

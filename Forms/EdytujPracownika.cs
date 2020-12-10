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
    public partial class EdytujPracownika : Form
    {
        private firma_deweloperska_3Entities db = new firma_deweloperska_3Entities();
        private int id = 0;
        public EdytujPracownika(int x)
        {
            id = x;
            InitializeComponent();

            dodaj_imie.Text = db.PRACOWNICies.Find(x).PRAC_IMIE;
            dodaj_nazwisko.Text = db.PRACOWNICies.Find(x).PRAC_NAZWISKO;
            dodaj_pesel.Text = db.PRACOWNICies.Find(x).PRAC_PESEL;
            dodaj_telefon.Text = db.PRACOWNICies.Find(x).PRAC_TELEFON;
            dodaj_email.Text = db.PRACOWNICies.Find(x).PRAC_EMAIL;
            dodaj_adres.Text = db.PRACOWNICies.Find(x).PRAC_ADRES;
            dodaj_stanowisko.Text = db.PRACOWNICies.Find(x).PRAC_STANOWSKO;
        }

        private void btnDodajPracownika_Click(object sender, EventArgs e)
        { 
            db.PRACOWNICies.Find(id).PRAC_IMIE = dodaj_imie.Text;
            db.PRACOWNICies.Find(id).PRAC_NAZWISKO = dodaj_nazwisko.Text;
            db.PRACOWNICies.Find(id).PRAC_PESEL = dodaj_pesel.Text;
            db.PRACOWNICies.Find(id).PRAC_TELEFON = dodaj_telefon.Text;
            db.PRACOWNICies.Find(id).PRAC_EMAIL = dodaj_email.Text;
            db.PRACOWNICies.Find(id).PRAC_ADRES = dodaj_adres.Text;
            db.PRACOWNICies.Find(id).PRAC_STANOWSKO = dodaj_stanowisko.Text;
            this.Close();
            db.SaveChanges();
            bsPracownicy.DataSource = db.PRACOWNICies.ToList();
            
        }

        private void lbl_Imie_Click(object sender, EventArgs e)
        {

        }

        private void EdytujPracownika_Load(object sender, EventArgs e)
        {

        }

        private void dodaj_imie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

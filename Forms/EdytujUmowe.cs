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
    public partial class EdytujUmowe : Form
    {
        private firma_deweloperska_2Entities db = new firma_deweloperska_2Entities();
        private int id = 0;
        private bool umowa = false;
        public EdytujUmowe(int x)
        {

            InitializeComponent();
            id = x;
            try
            {
                inputNrUmowy.Text = db.UMOWies.Where(k => k.PRAC_ID == x).FirstOrDefault().UMOWA_ID.ToString();
                inputPensja.Text = db.UMOWies.Where(k => k.PRAC_ID == x).FirstOrDefault().UMOWA_PENSJA.ToString();
                umowa = true;
            } catch (System.NullReferenceException)
            {
                umowa = false;
                inputNrUmowy.Text = ((db.UMOWies.Max(k => k.UMOWA_ID)) + 1).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (umowa == true)
            {
                db.UMOWies.Where(k => k.PRAC_ID == id).FirstOrDefault().UMOWA_ID = int.Parse(inputNrUmowy.Text);
                db.UMOWies.Where(k => k.PRAC_ID == id).FirstOrDefault().UMOWA_PENSJA = int.Parse(inputPensja.Text);
                db.UMOWies.Where(k => k.PRAC_ID == id).FirstOrDefault().UMOWA_DO_KIEDY = dateZatrudnionyDo.Value;
                db.UMOWies.Where(k => k.PRAC_ID == id).FirstOrDefault().UMOWA_OD_KIEDY = dateZatrudnionyOD.Value;
            } else
            {
                UMOWY nowy = new UMOWY();
                nowy.UMOWA_ID = int.Parse(inputNrUmowy.Text);
                nowy.UMOWA_PENSJA = int.Parse(inputPensja.Text);
                nowy.UMOWA_DO_KIEDY = dateZatrudnionyDo.Value;
                nowy.UMOWA_OD_KIEDY = dateZatrudnionyOD.Value;
                nowy.PRAC_ID = id;
                db.UMOWies.Add(nowy);
            }
            this.Close();
            db.SaveChanges();
            uMOWYBindingSource.DataSource = db.UMOWies.ToList();
            
        }

        private void inputNrUmowy_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputPensja_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

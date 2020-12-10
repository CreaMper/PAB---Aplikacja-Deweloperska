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
    public partial class MenuZlecenia : Form
    {
        private firma_deweloperska_3Entities db = new firma_deweloperska_3Entities();
        public MenuZlecenia()
        {
            InitializeComponent();
            
            var query = (from z in db.ZESPOLies join zc in db.ZLECENIAs on z.ZESP_ID equals zc.ZESP_ID join p in db.PRIORYTETies on zc.PRIO_ID equals p.PRIO_ID select new { Numer = zc.ZLEC_ID, Priorytet = p.PRIO_NAZWA, Zespół = z.ZESP_NAZWA, Zrealizowano = zc.ZLEC_ZAKONCZONO, Rozpoczęto = zc.ZLEC_ROZPOCZECIE, Opis = zc.ZLEC_OPIS }).ToList();
            dtgrdZlecenia.DataSource = query;
            dtgrdZlecenia.Columns["Numer"].Width = 40;
            dtgrdZlecenia.Columns["Priorytet"].Width = 70;
            dtgrdZlecenia.Columns["Zespół"].Width = 70;
            dtgrdZlecenia.Columns["Zrealizowano"].Width = 70;
            dtgrdZlecenia.Columns["Opis"].Width = 300;

        }

        private void MenuZlecenia_Load(object sender, EventArgs e)
        {

        }

        private void btnEdytujZlecenie_Click(object sender, EventArgs e)
        {
            var element = dtgrdZlecenia.SelectedRows[0].Cells[0].Value.ToString();
            var newForm = new EdytujZlecenie(int.Parse(element)+1);
        }

        private void dtgrdZlecenia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgrdZespoly_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

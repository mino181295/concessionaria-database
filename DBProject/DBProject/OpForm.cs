using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject
{
    public partial class opForm : Form
    {
        private DataClassesDataContext db;

        public opForm(DataClassesDataContext db)
        {
            this.db = db;
            InitializeComponent();
            showHome();

        }

        private void showHome()
        {
            this.panelHome.BringToFront();
        }


        private void buttonOp_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "buttonA1":
                    panelOpionalToVeic.BringToFront();
                    break;
                case "buttonA2":
                    panelStoricoRevisioni.BringToFront();
                    break;
                case "buttonB1":
                    panelAcquirenti.BringToFront();
                    break;
                case "buttonB3":
                    panelClassificaVendite.BringToFront();
                    break;
                case "buttonC3":
                    panelIncassi.BringToFront();
                    break;
                case "buttonC4":
                    panelContratto.BringToFront();
                    break;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            showHome();
        }



        // OP A1: Ricerca optional dato il veicololo. 
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            var data = from v in db.VeicoloCatalogo
                       join c in db.Fornitore on v.CasaProduttrice equals c.PartitaIVA
                       select new { member = c.RagioneSociale + " " + v.NomeModello + " " + v.AnnoModello, v.Codice };

            ComboBox combo = (ComboBox)sender;
            combo.DataSource = data;
            combo.DisplayMember = "member";
            combo.ValueMember = "Codice";
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            var value = combo.SelectedValue;
            if (value == null)
                return;

            dataGridViewOptional.DataSource = from o in this.db.Supporto
                                              join v in db.VeicoloCatalogo on o.VeicoloCatalogo equals v.Codice
                                              where v.Codice == value.ToString()
                                              select o.Optional1;
        }


        // OP A2: Storico revisioni veicolo.
        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            var data = from v in db.VeicoloVenduto                          
                       select new { member = v.Id + " " + v.VeicoloCatalogo1.NomeModello, v.Id };

            ComboBox combo = (ComboBox)sender;
            combo.DataSource = data;
            combo.DisplayMember = "member";
            combo.ValueMember = "Id";
        }

        private void comboBox2_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            var value = combo.SelectedValue;
            if (value == null)
                return;

            dataGridViewRevisioni.DataSource = from v in this.db.VeicoloVenduto
                                               join r in db.Revisione on v.Id equals r.VeicoloVenduto
                                               where v.Id == EntryForm.convertStringInt(value.ToString())
                                               && r.DataEsecuzione != null
                                               select new { r.Numero, r.DataEsecuzione };
        }       


        // OP B1: Lista acquirenti da [data1] a [data2].
        private void dateTimePickerAcquirenti_ValueChanged(object sender, EventArgs e)
        {
            DateTime fromD = dateTimePicker6.Value;
            DateTime to = dateTimePicker1.Value;

            dataGridViewAcquirenti.DataSource = (from c in db.Cliente
                                                join cv in db.ContrattoVendita
                                                on c.Id equals cv.Cliente
                                                where cv.Data <= to && cv.Data >= fromD
                                                select c).ToList().GroupBy(test => test.Id)
                                                                  .Select(grp => grp.First())
                                                                  .ToList();
        }


        // OP B3: Visualizzazione classifica veicoli venduti da [data1] a [data2].
        private void dateTimeVendite_ValueChanged(object sender, EventArgs e)
        {
            DateTime fromD = dateTimePicker2.Value;
            DateTime to = dateTimePicker3.Value;

            dataGridViewVendite.DataSource = from vv in db.VeicoloVenduto
                                       join vc in db.VeicoloCatalogo on vv.VeicoloCatalogo equals vc.Codice
                                       where vv.ContrattoVendita.Data <= to && vv.ContrattoVendita.Data >= fromD
                                       group vc by vc.Codice into vs
                                       select new { CodiceVeicolo = vs.First().Codice , NumeroVenduti = vs.Count() };

        }


        // OP C3: Somma incassi da [data1] a [data2].
        private void dateTimePickerIncassi_ValueChanged(object sender, EventArgs e)
        {
            DateTime fromD = dateTimePicker4.Value;
            DateTime to = dateTimePicker5.Value;

            labelIncassi.Text = (from c in db.ContrattoVendita
                                 where c.Data <= to && c.Data >= fromD
                                 select c).ToList().Sum(item => item.ImportoComplessivo).ToString() + " €";

        }


        // OP C4: Valore complessivo contratto.
        private void comboBox3_DropDown(object sender, EventArgs e)
        {
            var data = from c in db.ContrattoVendita                                              
                       select new { member = c.Numero + " del " + c.Data + " a nome di " + 
                       (c.Cliente1.PartitaIVA == null ? (c.Cliente1.Nome + " " + c.Cliente1.Cognome) : 
                       c.Cliente1.RagioneSociale), c.Numero };

            ComboBox combo = (ComboBox)sender;
            combo.DataSource = data;
            combo.DisplayMember = "member";
            combo.ValueMember = "Numero";
        }

        private void comboBox3_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            var value = combo.SelectedValue;
            if (value == null)
                return;
            
                        labelValContratto.Text = (from c in db.ContrattoVendita
                                            where c.Numero == EntryForm.convertStringInt(value.ToString())
                                            select c.ImportoComplessivo).First().ToString();
        }

       
    }
}

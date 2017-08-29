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
    public partial class OpForm : Form
    {
        private DataClassesDataContext db;

        public OpForm(DataClassesDataContext db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            var value = combo.SelectedValue;
            if (value == null)
                return;

            dataGridView1.DataSource = from o in this.db.Supporto
                                       join v in db.VeicoloCatalogo on o.VeicoloCatalogo equals v.Codice
                                       where v.Codice == value.ToString()
                                       select o.Optional1;                                          
        }

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

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime fromD = dateTimePicker2.Value;
            DateTime to = dateTimePicker3.Value;

            dataGridView2.DataSource = from vv in db.VeicoloVenduto
                                       join vc in db.VeicoloCatalogo on vv.VeicoloCatalogo equals vc.Codice
                                       where vv.ContrattoVendita.Data <= to && vv.ContrattoVendita.Data >= fromD
                                       group vc by vc.Codice into vs
                                       select new {Veicolo=vs.First().Codice + " " + vs.First().NomeModello, NumeroVenduti = vs.Count() };
                                       
        }

        private void dateTimePickerIncassi_ValueChanged(object sender, EventArgs e)
        {
            DateTime fromD = dateTimePicker4.Value;
            DateTime to = dateTimePicker5.Value;

           label3.Text = (from c in db.ContrattoVendita
                                        where c.Data <= to && c.Data >= fromD
                                        select c).ToList().Sum(item=>item.ImportoComplessivo).ToString();
                                       
        }
    }
}

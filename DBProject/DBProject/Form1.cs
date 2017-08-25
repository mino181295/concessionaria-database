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
    public partial class MainForm : Form
    {
        private EntryForm entryForm = new EntryForm();
        private DataClassesDataContext db = new DataClassesDataContext();
        private Boolean isHomePanel = true;

        // Elementi per le searchbars
        private Control currentCombo;
        private TextBox currentSearchBar;
        private DataGridView destinationDataGridView; // DataGridView da fillare con il risultato della ricerca per filtro.
        private String tableName;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            // Officina
            this.giacenzaTableAdapter.Fill(this.dBProject1617DataSet.Giacenza);
            fillCombo(this.comboBox22, this.dBProject1617DataSet.Giacenza);

            this.ricambioTableAdapter.Fill(this.dBProject1617DataSet.Ricambio);
            fillCombo(this.comboBox21, this.dBProject1617DataSet.Ricambio);

            this.utilizzoTableAdapter.Fill(this.dBProject1617DataSet.Utilizzo);
            fillCombo(this.comboBox20, this.dBProject1617DataSet.Utilizzo);

            this.riparazioneTableAdapter.Fill(this.dBProject1617DataSet.Riparazione);
            fillCombo(this.comboBox19, this.dBProject1617DataSet.Riparazione);

            this.referenzaTableAdapter.Fill(this.dBProject1617DataSet.Referenza);
            fillCombo(this.comboBox7, this.dBProject1617DataSet.Referenza);


            // Veicoli
            this.supportoTableAdapter.Fill(this.dBProject1617DataSet.Supporto);
            fillCombo(this.comboBox18, this.dBProject1617DataSet.Supporto);

            this.dotazioneTableAdapter.Fill(this.dBProject1617DataSet.Dotazione);
            fillCombo(this.comboBox25, this.dBProject1617DataSet.Dotazione);

            this.revisioneTableAdapter.Fill(this.dBProject1617DataSet.Revisione);
            fillCombo(this.comboBox17, this.dBProject1617DataSet.Revisione);

            this.veicoloVendutoTableAdapter.Fill(this.dBProject1617DataSet.VeicoloVenduto);
            fillCombo(this.comboBox16, this.dBProject1617DataSet.VeicoloVenduto);

            this.optionalTableAdapter.Fill(this.dBProject1617DataSet.Optional);
            fillCombo(this.comboBox15, this.dBProject1617DataSet.Optional);

            this.modelloVeicoloTableAdapter.Fill(this.dBProject1617DataSet.ModelloVeicolo);
            fillCombo(this.comboBox11, this.dBProject1617DataSet.ModelloVeicolo);

            this.veicoloCatalogoTableAdapter.Fill(this.dBProject1617DataSet.VeicoloCatalogo);
            fillCombo(this.comboBox14, this.dBProject1617DataSet.VeicoloCatalogo);


            // Ordine
            this.ordineRicambioTableAdapter.Fill(this.dBProject1617DataSet.OrdineRicambio);
            fillCombo(this.comboBox23, this.dBProject1617DataSet.OrdineRicambio);

            this.ordineVeicoloTableAdapter.Fill(this.dBProject1617DataSet.OrdineVeicolo);
            fillCombo(this.comboBox13, this.dBProject1617DataSet.OrdineVeicolo);

            this.ordineTableAdapter.Fill(this.dBProject1617DataSet.Ordine);
            fillCombo(this.comboBox12, this.dBProject1617DataSet.Ordine);


            // Clienti e contatti
            this.nostreModalitàPagamentoTableAdapter.Fill(this.dBProject1617DataSet.NostreModalitàPagamento);
            fillCombo(this.comboBox10, this.dBProject1617DataSet.NostreModalitàPagamento);

            this.rataClienteTableAdapter.Fill(this.dBProject1617DataSet.RataCliente);
            fillCombo(this.comboBox9, this.dBProject1617DataSet.RataCliente);

            this.contrattoVenditaTableAdapter.Fill(this.dBProject1617DataSet.ContrattoVendita);
            fillCombo(this.comboBox24, this.dBProject1617DataSet.ContrattoVendita);

            this.clienteTableAdapter.Fill(this.dBProject1617DataSet.Cliente);
            fillCombo(this.comboBox8, this.dBProject1617DataSet.Cliente);


            // Corrieri
            this.trasportoTableAdapter.Fill(this.dBProject1617DataSet.Trasporto);
            fillCombo(this.comboBoxTrasporti, this.dBProject1617DataSet.Trasporto);

            this.corriereTableAdapter.Fill(this.dBProject1617DataSet.Corriere);
            fillCombo(this.comboBoxCorrieri, this.dBProject1617DataSet.Corriere);


            // Fornitori            
            this.modalitàPagamentoTableAdapter.Fill(this.dBProject1617DataSet.ModalitàPagamento);
            fillCombo(this.comboBoxModPag, this.dBProject1617DataSet.ModalitàPagamento);            

            this.rataTableAdapter.Fill(this.dBProject1617DataSet.Rata);
            fillCombo(this.comboBoxPagamenti, this.dBProject1617DataSet.Rata);

            this.fatturaAcquistoTableAdapter.Fill(this.dBProject1617DataSet.FatturaAcquisto);
            fillCombo(this.comboBoxFatture, this.dBProject1617DataSet.FatturaAcquisto);

            this.fornitoreTableAdapter.Fill(this.dBProject1617DataSet.Fornitore);
            fillCombo(this.comboBoxFornitore, this.dBProject1617DataSet.Fornitore);
            

            #region DataSetAdapters




            /*
            // Officina         
            fillCombo(this.comboBox22, db.Giacenza.GetType());
            fillCombo(this.comboBox21, db.Ricambio.GetType());
            fillCombo(this.comboBox20, db.Utilizzo.GetType());
            fillCombo(this.comboBox19, db.Riparazione.GetType());


            // Veicoli           
            fillCombo(this.comboBox25, db.Supporto.GetType());
            fillCombo(this.comboBox18, db.Dotazione.GetType());
            fillCombo(this.comboBox17, db.Revisione.GetType());
            fillCombo(this.comboBox16, db.VeicoloVenduto.GetType());
            fillCombo(this.comboBox15, db.Optional.GetType());
            fillCombo(this.comboBox11, db.ModelloVeicolo.GetType());
            fillCombo(this.comboBox14, db.VeicoloCatalogo.GetType());


            // Ordine          
            fillCombo(this.comboBox23, db.OrdineRicambio.GetType());
            fillCombo(this.comboBox13, db.OrdineVeicolo.GetType());
            fillCombo(this.comboBox12, db.Ordine.GetType());


            // Clienti e contatti         
            fillCombo(this.comboBox10, db.ModalitàPagamento.GetType());
            fillCombo(this.comboBox9, db.RataCliente.GetType());
            fillCombo(this.comboBox24, db.ContrattoVendita.GetType());
            fillCombo(this.comboBox8, db.Cliente.GetType());


            // Corrieri         
            fillCombo(this.comboBoxTrasporti, db.Trasporto.GetType());
            fillCombo(this.comboBoxCorrieri, db.Corriere.GetType());
            


            // Fornitori            
            fillCombo(this.comboBoxModPag, db.ModalitàPagamento.GetType());
            fillCombo(this.comboBoxPagamenti, db.Rata.GetType());
            fillCombo(this.comboBoxFatture, db.FatturaAcquisto.GetType());
            fillCombo(this.comboBoxFornitore, db.Fornitore.GetType());

            */

            #endregion

            this.homePanel.BringToFront();
        }

        // Fill a combo with specified DataTable columns names.

        private void fillCombo(ComboBox combo, Type tabletype)
        {
            combo.DataSource = from c in db.Mapping.GetTable(tabletype).RowType.DataMembers
                               select c.MappedName;
        }

        private void fillCombo(ComboBox combo, DataTable table)
        {
            List<String> columnsNames = new List<string>();
            columnsNames.Add("");
            foreach (DataColumn dc in table.Columns)
            {
                columnsNames.Add(dc.ColumnName);
            }

            combo.DataSource = columnsNames;
        }

        private void backToHome(object sender, EventArgs e)
        {
            this.homePanel.BringToFront();
            isHomePanel = true;
        }

        private void homeBtns_Click(object sender, EventArgs e)
        {
            Panel panel;
            if (sender == this.fornitoriBtn)
                panel = this.fornitoriPanel;
            else if (sender == this.clientiBtn)            
                panel = this.clientiPanel;                
            else if (sender == this.officinaBtn)
                panel = this.officinaPanel;
            else if (sender == this.corrieriBtn)
                panel = this.corrieriPanel;
            else if (sender == this.veicoliBtn)
                panel = this.veicoliPanel;
            else
                panel = this.ordiniPanel;

            panel.BringToFront();
            isHomePanel = false;
            searchSetup(panel.Controls.OfType<TabControl>().First());
        }

        private void addInstanceBtn_Click(object sender, EventArgs e)
        {
            //temporanea
            this.entryForm.Dispose();
            this.entryForm = new EntryForm();
            //

            //EntryButton è un button custom indicante l'EntryForm da mostrare al click relativo.
            EntryButton senderBtn = (EntryButton)sender;
            this.entryForm.setMainPanel(senderBtn.EntryPanel);
            this.entryForm.Text = senderBtn.FormName;
            this.entryForm.ShowDialog();
        }



        // Methods for texBoxes used as search bar.
        #region searchBars

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            doResearch();            
        }

        private void comboBoxSearchFieldChanged(object sender, EventArgs e)
        {
            doResearch();
        }

        // Dopo inserimento refresho la vista.
        private void MainForm_Activated(object sender, EventArgs e)
        {
            if(!isHomePanel)
                doResearch();
        }

        private void doResearch() {
            if (this.currentSearchBar == null || this.currentCombo == null)
            {
                return;
            }
            String filter = this.currentSearchBar.Text;
            String searchField = this.currentCombo.Text;

            Func<Object, bool> where = c =>
            {
                if (String.IsNullOrEmpty(searchField) || String.IsNullOrEmpty(filter))
                {
                    return true;
                }

                var field = c.GetType().GetProperty(searchField);                
                if (field != null)
                {
                    var content = field.GetValue(c);
                    if (content == null)
                        return false;
                    return content.ToString().Contains(filter);
                }
                return false;
            };

            List<Object> query = null;
           
            switch (tableName)
            {

                // Gestione Fornitori
                case "Fornitore":
                    query = db.Fornitore.Where(where).ToList();
                    break;
                case "Fattura":
                    query = db.FatturaAcquisto.Where(where).ToList();
                    break;
                case "Pagamento_fornitore":
                    query = db.Rata.Where(where).ToList();
                    break;
                case "Modalita_pagamento_fornitore":
                    query = db.ModalitàPagamento.Where(where).ToList();
                    break;

                // Gestione Corrieri
                case "Corriere":
                    query = db.Corriere.Where(where).ToList();
                    break;
                case "Trasporto":
                    query = db.Trasporto.Where(where).ToList();
                    break;

                // Gestione Clienti e Contratti
                case "Cliente":
                    query = db.Cliente.Where(where).ToList();
                    break;
                case "Contratto":
                    query = db.ContrattoVendita.Where(where).ToList();
                    break;
                case "Pagamento":
                    query = db.RataCliente.Where(where).ToList();
                    break;
                case "Modalita_di_pagamento":
                    query = db.NostreModalitàPagamento.Where(where).ToList();
                    break;

                // Gestione Ordini
                case "Ordine":
                    query = db.Ordine.Where(where).ToList();
                    break;
                case "Dettaglio_ordine_veicolo":
                    query = db.OrdineVeicolo.Where(where).ToList();
                    break;
                case "Dettaglio_ordine_ricambio":
                    query = db.OrdineRicambio.Where(where).ToList();
                    break;

                // Gestione Veicolo
                case "Veicolo_in_catalogo":
                    query = db.VeicoloCatalogo.Where(where).ToList();
                    break;
                case "Modello_veicolo":
                    query = db.ModelloVeicolo.Where(where).ToList();
                    break;
                case "Optional":
                    query = db.Optional.Where(where).ToList();
                    break;
                case "Veicolo_venduto":
                    query = db.VeicoloVenduto.Where(where).ToList();
                    break;
                case "Revisione":
                    query = db.Revisione.Where(where).ToList();
                    break;
                case "Optional_supportato":
                    query = db.Supporto.Where(where).ToList();
                    break;
                case "Optional_in_veicolo_venduto":
                    query = db.Dotazione.Where(where).ToList();
                    break;

                // Gestione Officina
                case "Riparazione":
                    query = db.Riparazione.Where(where).ToList();
                    break;
                case "Dettaglio_riparazione":
                    query = db.Utilizzo.Where(where).ToList();
                    break;
                case "Ricambio":
                    query = db.Ricambio.Where(where).ToList();
                    break;
                case "Giacenza":
                    query = db.Giacenza.Where(where).ToList();
                    break;
                case "Ricambio_veicolo":
                    query = db.Referenza.Where(where).ToList();
                    break;
            }

            destinationDataGridView.DataSource = query;
        }
                
        private void tabControlSelectedIndexChanged(object sender, EventArgs e)
        {            
            searchSetup(sender);
            doResearch();     
        }       

        private void searchSetup(Object sender)
        {           
            tableName = ((TabControl)sender).SelectedTab.Name;
            var controls = ((TabControl)sender).SelectedTab.Controls;

            // Setto la searchbar corrente
            this.currentSearchBar = controls.OfType<TextBox>().First();

            // Setto il combo corrente
            this.currentCombo = controls.OfType<ComboBox>().First();

            // Setto il DataGridView destinazione dei dati.
            destinationDataGridView = controls.OfType<DataGridView>().First();            
        }


        #endregion             
    }
}

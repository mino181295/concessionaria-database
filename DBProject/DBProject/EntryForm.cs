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
    /**
     * Enumerazione per distinguere i vari panel da usare nell'EntryForm
     * (pannello di immissione principale)
     */
    public enum Entry
    {
        None,

        // Gestione Fornitore
        Fornitore, Fattura, ModPag, RecapitoForn, EmailForn, PagVForn, PerPagForn,

        // Gestione Cliente
        Cliente, Contratto, Pagamento, RecapitoCli, EmailCli, NsModPag, PerPagCli,

        // Gestione Corriere
        Corriere, RecapitoCor, EmailCor, Trasporto, PerfTrasp,

        // Gestione Officina
        Riparazione, UtilizzoRicambioRip, Ricambio, Giacenza, RicVeic,

        // Gestione Veicolo
        Veicolo, Modello, Optional, OptToVeic, OptToVeicVend, Vendita, Revisione, EsecRev,

        // Gestione Ordine
        Ordine, DetVeic, DetRic, PerfOrdine

    }

    public partial class EntryForm : Form
    {
        /* To know which Entity you are editing */
        private Entry currEntry = Entry.None;

        /* To access the data in the db. */
        private DataClassesDataContext db = new DataClassesDataContext();

        /*
         * Dictionary used to map the enum Entry (from which i know which entity i should consider)
         * together with the respective panel.  
         */
        private Dictionary<Entry, Panel> panelMap = new Dictionary<Entry, Panel>();

        public EntryForm()
        {
            InitializeComponent();

            // Gestione Fornitore
            this.panelMap.Add(Entry.Fornitore, this.addFornitorePanel);
            this.panelMap.Add(Entry.Fattura, this.addFatturaPanel);
            this.panelMap.Add(Entry.ModPag, this.addModalitaPagPanel);
            this.panelMap.Add(Entry.PagVForn, this.addPagamentoPanel);
            this.panelMap.Add(Entry.PerPagForn, this.addPagamentoPanel);

            // Gestione Cliente
            this.panelMap.Add(Entry.Cliente, this.addClientePanel);
            this.panelMap.Add(Entry.Contratto, this.addContrattoPanel);
            this.panelMap.Add(Entry.Pagamento, this.addPagamentoPanel);
            this.panelMap.Add(Entry.NsModPag, this.addModalitaPagPanel);
            this.panelMap.Add(Entry.PerPagCli, this.addPagamentoPanel);

            // Gestione Corriere
            this.panelMap.Add(Entry.Corriere, this.addFornitorePanel);
            this.panelMap.Add(Entry.Trasporto, this.addTrasportoPanel);
            this.panelMap.Add(Entry.PerfTrasp, this.addPerfPanel);

            // Gestione Officina
            this.panelMap.Add(Entry.Riparazione, this.addRiparazionePanel);
            this.panelMap.Add(Entry.UtilizzoRicambioRip, this.addUtilizzoRicambioRipPanel);
            this.panelMap.Add(Entry.Ricambio, this.addRicambioPanel);
            this.panelMap.Add(Entry.Giacenza, this.addGiacenzaPanel);
            this.panelMap.Add(Entry.RicVeic, this.addOptToVeicPanel);

            // Gestione Veicolo
            this.panelMap.Add(Entry.Veicolo, this.addVeicoloPanel);
            this.panelMap.Add(Entry.Modello, this.addModelloPanel);
            this.panelMap.Add(Entry.Optional, this.addOptionalPanel);
            this.panelMap.Add(Entry.OptToVeic, this.addOptToVeicPanel);
            this.panelMap.Add(Entry.OptToVeicVend, this.addOptToVeicPanel);
            this.panelMap.Add(Entry.Vendita, this.addVenditaPanel);
            this.panelMap.Add(Entry.Revisione, this.addRevisionePanel);
            this.panelMap.Add(Entry.EsecRev, this.addEsecRevPanel);

            // Gestione Ordine
            this.panelMap.Add(Entry.PerfOrdine, this.addPerfPanel);
            this.panelMap.Add(Entry.Ordine, this.addOrdinePanel);
            this.panelMap.Add(Entry.DetRic, this.addVeicRicToOrdinePanel);
            this.panelMap.Add(Entry.DetVeic, this.addVeicRicToOrdinePanel);

        }


        public void setMainPanel(Entry p)
        {
            this.currEntry = p;
            this.panelMap[p].BringToFront();
        }



        /*
         * Metodi per riutilizzare panel simili in contesti differenti
         * previo semplici modifiche.
         */

        #region sharedPanelManagement

        // usato sia per anagrafica FORNITORE che CORRIERE
        private void addFornitorePanel_VisibleChanged(object sender, EventArgs e)
        {
            if (this.currEntry == Entry.Corriere)
            {
                this.groupBox10.Visible = false;                             
            }
        }

        // per aggiungere le NOSTRE MODALITA e quelle del FORNIORE
        private void addModalitaPagPanel_VisibleChanged(object sender, EventArgs e)
        {
            bool cond = this.currEntry == Entry.ModPag;

            this.fornAddModPagLabel.Visible = cond;
            this.fornAddModPagComboBox.Visible = cond;
        }
        
        // usato sia per PAGAMENTO FATTURA ORDINE che per PAGAMENTO CONTRATTO VENDITA
        private void addPagamentoPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (this.currEntry == Entry.Pagamento || this.currEntry == Entry.PerPagCli)
            {
                this.contratto_AddPagLabel.Text = "Contratto";                
                this.label126.Visible = false;
                this.comboFornitore.Visible = false;
            }
            else if (this.currEntry == Entry.PagVForn || this.currEntry == Entry.PerPagForn)
            {
                this.contratto_AddPagLabel.Text = "Fattura";                
                this.label126.Visible = true;
                this.comboFornitore.Visible = true;
            }

            if (this.currEntry == Entry.PerPagCli || this.currEntry == Entry.PerPagForn)
            {
                comboScadenza.BringToFront();
                datePagamento.BringToFront();
                label41.Text = "Data pagamento";

            }                            
             else {
                dateTimePicker4.BringToFront();
                textBox29.BringToFront();
                label41.Text = "Importo";
            } 
                           
        }

        // per inserire la DATA EFFETTIVA CONSEGNA sia dell'ORDINE che del VEICOLO al cliente        
        private void addPerfPanel_VisibleChanged(object sender, EventArgs e)
        {

            if (this.currEntry == Entry.PerfOrdine)
            {
                this.label48.Text = "ID Ordine";
                var data = from o in db.Ordine
                           where o.DataConsegna == null
                           select new { desc = ("Id " + o.Id + " del " + o.DataOrdine), o.Id };

                comboPerf.DataSource = data.ToList();
                comboPerf.DisplayMember = "desc";
                comboPerf.ValueMember = "Id";
            }
            else
            {
                this.label48.Text = "Codice trasporto";
                var data = from o in db.Trasporto
                           where o.DataConsegna == null
                           select new { desc = ("Codice " + o.Codice + " del " + o.DataConsegnaPrevista), o.Codice };

                comboPerf.DataSource = data.ToList();
                comboPerf.DisplayMember = "desc";
                comboPerf.ValueMember = "Codice";
            }                                                        
        }     

        // usato sia per DETTAGLIO ORDINE VEICOLO che RICAMBIO
        private void addVeicRicToOrdinePanel_VisibleChanged(object sender, EventArgs e)
        {
            comboBox3.DataSource = from o in db.Ordine
                                   where o.TipoOrdine == (this.currEntry == Entry.DetVeic ? 'v' : 'r')
                                   select new { desc = "id: " + o.Id + " del " + o.DataOrdine, o.Id };
            comboBox3.DisplayMember = "desc";
            comboBox3.ValueMember = "Id";

            if (this.currEntry == Entry.DetVeic)
            {
                this.label129.Text = "Veicolo Cliente";
                label130.Visible = false;
                numericUpDown4.Visible = false;                

                comboItem.DataSource = from v in db.VeicoloVenduto
                                       where v.OrdineVeicolo == null
                                       select new { desc = "id: " + v.Id + " contratto: " + v.Contratto, v.Id };
                comboItem.DisplayMember = "desc";
                comboItem.ValueMember = "Id";

            } else
            {
                this.label129.Text = "Ricambio";
                label130.Visible = true;
                numericUpDown4.Visible = true;

                comboItem.DataSource = from v in db.Ricambio                                      
                                       select new { desc = v.Nome + " codice: " + v.Codice, v.Codice};
                comboItem.DisplayMember = "desc";
                comboItem.ValueMember = "Codice";
            }            
        }

        /* usato per associare:
         *  ricambio-veicolo
         *  optional-veicolo venduto
         *  optional-veicolo in catalogo
         */
        private void addOptToVeicPanel_VisibleChanged(object sender, EventArgs e)
        {
            switch (this.currEntry)
            {
                // settare comboBox adeguatamente
                case Entry.RicVeic:
                    this.label84.Text = "Ricambio";                   
                    break;
                case Entry.OptToVeicVend:
                    this.comboVeicVend.BringToFront();
                    break;
            }
            if (currEntry != Entry.RicVeic)
            {
                this.label84.Text = "Optional";
                this.comboOpt.BringToFront();
            }           
        }

        #endregion


        //Closing management

        private void clearFields(Control ctrl)
        {
            foreach (Control c in ctrl.Parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    ((TextBox)(c)).Text = string.Empty;
                }
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }
        }
        /* 
         * Buttons to insert a new instance to the db.
         */

        #region instanceAdding

        //Aggiunta funzioni
        private bool isString(string s)
        {
            return !String.IsNullOrWhiteSpace(s);
        }

        private bool isInt(int i)
        {
            return (i != -1);
        }

        private bool isFloat(float f)
        {
            return (f != -1);
        }

        private int convertStringInt(string i)
        {
            int result = 0;
            return Int32.TryParse(i, out result) ? result : -1;
        }

        private float convertStringFloat(string i)
        {
            float result = 0;
            return float.TryParse(i, out result) ? result : -1;
        }

        
        private void submitAddOrdineBtn_Click(object sender, EventArgs e)
        {
            Ordine o = new Ordine();

            var val = this.comboBox30.SelectedValue;
            o.Fornitore = val == null ? null : val.ToString();                        
            o.DataOrdine = this.dateTimePicker11.Value;
            o.DataConsegnaPrevista = this.dateTimePicker13.Value;                       
            o.TipoOrdine = this.radioButton1.Checked ? 'r' : 'v';

            try
            {
                if (!(isString(o.Fornitore)))
                {
                    throw new Exception("Campi vuoti o errati");
                }
                db.Ordine.InsertOnSubmit(o);
                db.SubmitChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di inserimento dati");
            }            
        }

        private void submitVenditaBtn_Click(object sender, EventArgs e)
        {
            VeicoloVenduto vv = new VeicoloVenduto();

            var val = this.comboBox20.SelectedValue;
            vv.Contratto = val == null ? -1 : convertStringInt(val.ToString());

            val = this.comboBox19.SelectedValue;
            vv.VeicoloCatalogo = val == null ? null :val.ToString();             

            try
            {
                if (!(isString(vv.VeicoloCatalogo) &&                        
                       isInt((int)vv.Contratto)))
                {
                    throw new Exception("Campi vuoti o errati");
                }
                db.VeicoloVenduto.InsertOnSubmit(vv);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di inserimento dati");
            }

            this.Close();
        }

        private void submitOptToVeicBtn_Click(object sender, EventArgs e)
        {/*
            //nON CAPISCO PRIMA è BINDATO CON RIPARAZIONE POI C'E OPTIONAL
            supporto s = new supporto();
            s.Optional_Codice = this.comboRic.ValueMember;
            s.Veicolo_Codice = this.comboVeicCat.ValueMember;*/
            this.Close();
        }

        private void submitOptionalBtn_Click(object sender, EventArgs e)
        {/*
            Optional o = new Optional();

            o.Codice = this.textBox65.Text;
            o.Nome = this.textBox64.Text;
            o.Prezzo = convertStringFloat(this.textBox63.Text);
            o.Descrizione = this.textBox66.Text;

            try
            {
                if (!(isString(o.Codice) &&
                        isString(o.Nome) &&
                        isString(o.Descrizione) &&
                        isFloat(o.Prezzo)))
                {
                    throw new Exception("Campi vuoti");
                }
                //db.Optional.InsertOnSubmit(o);
                //db.SubmitChanges();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di inserimento dati");
            }*/

            this.Close();
        }

        private void submitModelloBtn_Click(object sender, EventArgs e)
        {
            ModelloVeicolo m = new ModelloVeicolo();

            m.Nome = this.textBox74.Text;
            m.Anno = this.dateTimePicker15.Value;

            var val = this.comboBox15.SelectedValue;
            m.Fornitore = val == null ? null : val.ToString();    

            try
            {
                if (!(isString(m.Nome) &&
                        isString(m.Fornitore)))
                {
                    throw new Exception("Campi vuoti o errati");
                }
                db.ModelloVeicolo.InsertOnSubmit(m);
                db.SubmitChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di inserimento dati");
            }                        
        }

        private void submitRicambioBtn_Click(object sender, EventArgs e)
        {
            // fare check sul tipo di fornitore per determinare il tipo di ricambio (generico/originale)
            this.Close();
        }     

        private void submitFornitoreBtn_Click(object sender, EventArgs e)
        {
            Fornitore f = new Fornitore();
            f.CAP = this.textBoxFornCAP.Text;
            f.Città = this.textBoxFornCitta.Text;
            f.Indirizzo = this.textBoxFornIndirizzo.Text;
            f.IndirizzoEmail1 = this.textBoxFornEmail1.Text;
            f.IndirizzoEmail2 = this.textBoxFornEmail2.Text;
            f.PartitaIVA = this.textBoxFornPIVA.Text;
            f.Provincia = this.textBoxFornProvincia.Text;
            f.RagioneSociale = this.textBoxFornRagSoc.Text;
            f.Recapito1 = this.textBoxFornRec1.Text;
            f.Recapito2 = this.textBoxFornRec2.Text;            
            f.CasaProduttrice = this.checkBoxFornVeic.Checked ? 'y' : 'n';
            f.FornitoreRicambi = this.checkBoxFornRic.Checked ? 'y' : 'n';

            try
            {
                if (!(isString(f.CAP) &&
                        isString(f.Città) &&
                        isString(f.Indirizzo) &&
                        isString(f.IndirizzoEmail1) &&                        
                        isString(f.PartitaIVA) &&
                        isString(f.Provincia) &&
                        isString(f.RagioneSociale) &&
                        isString(f.Recapito1)                                             
                    ))
                {
                    throw new Exception("Alcuni campi sono vuoti o errati!");
                }
                db.Fornitore.InsertOnSubmit(f);
                db.SubmitChanges();
                

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di inserimento dati");
            }            
        }

        private void submitFatturaBtn_Click(object sender, EventArgs e)
        {
            FatturaAcquisto f = new FatturaAcquisto();
            f.Numero = convertStringInt(this.textBox5.Text);
            f.Data = this.dateTimePicker1.Value;
            f.ImportoComplessivo = convertStringFloat(this.textBox7.Text);
            var val = this.comboBox1.SelectedValue;
            f.Fornitore = val == null ? null : val.ToString();
            val = this.comboBox22.SelectedValue;
            f.ModPagamentoDa = convertStringFloat(val == null ? null : val.ToString());
            f.ModPagamentoFornitore = f.Fornitore;
            val = this.comboBox9.SelectedValue;
            f.Ordine = val == null ? -1 : Convert.ToDecimal(val.ToString());
            
            try
            {
                if (!(isInt((int)f.Numero) &&
                      isFloat(f.ImportoComplessivo) &&
                      isString(f.Fornitore) &&
                      isFloat(f.ModPagamentoDa) &&
                      isInt((int)f.Ordine) &&
                      f.Ordine > 0
                    ))
                {
                    throw new Exception("Valori sbagliati o vuoti");
                }
                db.FatturaAcquisto.InsertOnSubmit(f);
                db.SubmitChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di inserimento dati");
            }
            
        }

        private void submitContrattoBtn_Click(object sender, EventArgs e)
        {
            ContrattoVendita v = new ContrattoVendita();            
            v.Data = this.dateTimePicker9.Value;
            v.ImportoComplessivo = convertStringFloat(this.textBox21.Text);
            var val = this.comboBox5.SelectedValue;
            v.ModalitàPagamento = val == null ? -1 : convertStringFloat(val.ToString());
            val = this.comboBox6.SelectedValue;
            v.Cliente = val == null ? -1 : convertStringInt(val.ToString());
            try
            {
                if (!(isInt((int)v.Cliente) &&
                        isFloat(v.ImportoComplessivo) &&
                        isFloat(v.ModalitàPagamento)))
                {
                    throw new Exception("Campi vuoti o errati");
                }
                db.ContrattoVendita.InsertOnSubmit(v);
                db.SubmitChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di inserimento dati");
            }            
        }

        private void submitClienteABtn_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();

            c.PartitaIVA = this.textBox82.Text;
            c.RagioneSociale = this.textBox80.Text;
            c.IndirizzoEmail1 = this.textBox81.Text;            
            c.Recapito1 = this.textBox79.Text;                       
            c.Indirizzo = this.textBox31.Text;
            c.Città = this.textBox28.Text;
            c.Provincia = this.textBox30.Text;
            c.CAP = this.textBox32.Text;
            c.TipoCliente = 'a';

            try
            {
                if ( ! (  isString(c.PartitaIVA) &&
                          isString(c.RagioneSociale) &&
                          isString(c.IndirizzoEmail1) &&
                          isString(c.Recapito1) &&
                          isString(c.Indirizzo) &&
                          isString(c.Città) &&                          
                          isString(c.Provincia) &&
                          isString(c.CAP)))
                {
                    throw new Exception("Campi vuoti o errati");
                }
                db.Cliente.InsertOnSubmit(c);
                db.SubmitChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di inserimento dati");
            }                       
        }

        private void submitGiacenzaBtn_Click(object sender, EventArgs e)
        {
            /*
            Giacenza g = new Giacenza();

            g.Ricambio_Codice = this.comboBox12.ValueMember;
            g.Numero = convertStringInt(this.textBox4.Text);
            g.Data = this.dateTimePicker6.Value;
            g.Quantita = convertStringInt(this.textBox46.Text);
            g.Causale = this.textBox48.Text;

            try
            {
                if (!(isString(g.Ricambio_Codice) &&
                    isString(g.Causale) &&
                    isInt(g.Quantita) &&
                    isInt(g.Numero)))
                {
                    throw new Exception("Campi vuoti");
                }
                //db.Giacenza.InsertOnSubmit(g);
                //db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di inserimento dati");
            }
            this.Close();*/
        }

        private void submitPagamentoBtn_Click(object sender, EventArgs e)
        {            
                                  
            try
            {
                // Caso di utilizzo per rata cliente
                if (this.currEntry == Entry.Pagamento)
                {
                    RataCliente rc = new RataCliente();

                    var val = this.comboFattura.SelectedValue;
                    rc.Contratto = convertStringInt(val == null ? null : val.ToString());
                    rc.Scadenza = this.dateTimePicker4.Value;
                    rc.Importo = convertStringFloat(this.textBox29.Text);

                    if (!(isInt((int)rc.Contratto) &&
                            isFloat(rc.Importo)))
                    {
                        throw new Exception("Campi vuoti o errati");
                    }
                    db.RataCliente.InsertOnSubmit(rc);
                    db.SubmitChanges();

                }
                else if (this.currEntry == Entry.PagVForn)
                {
                    Rata p = new Rata();

                    var val = this.comboFornitore.SelectedValue;
                    p.FornitoreFattura = val == null ? null : val.ToString();
                    val = this.comboFattura.SelectedValue;
                    p.NumeroFattura = convertStringInt(val == null ? null : val.ToString());
                    p.Scadenza = this.dateTimePicker4.Value;
                    p.Importo = convertStringFloat(this.textBox29.Text);


                    if (!(isString(p.FornitoreFattura) &&
                            isInt((int)p.NumeroFattura) &&
                            isFloat(p.Importo)))
                    {
                        throw new Exception("Campi vuoti o errati");
                    }
                    db.Rata.InsertOnSubmit(p);
                    db.SubmitChanges();
                }
                // Caso inserimento pagamento
                else
                {                    
                    var val = this.comboFattura.SelectedValue;
                    String fattContr = val == null ? null : val.ToString();

                    val = this.comboScadenza.SelectedValue;
                    String scad = val == null ? null : val.ToString();

                    if (!(isString(fattContr) &&
                            isString(scad)))
                    {
                        throw new Exception("Campi vuoti o errati");
                    }

                    if (this.currEntry == Entry.PerPagCli)
                    {
                        RataCliente rc = (from p in db.RataCliente
                                          where p.Contratto == Convert.ToDecimal(fattContr)
                                          && p.Scadenza == Convert.ToDateTime(scad)
                                          select p).First();
                        rc.DataPagamento = this.datePagamento.Value;

                        db.SubmitChanges();
                        db.Refresh(System.Data.Linq.RefreshMode.KeepChanges, rc);
                    }
                    else
                    {
                        val = this.comboFornitore.SelectedValue;
                        String forn = val == null ? null : val.ToString();

                        if (!isString(forn))
                        {
                            throw new Exception("Campi vuoti o errati");
                        }

                        Rata r = (from p in db.Rata
                                  where p.FornitoreFattura == forn
                                  && p.NumeroFattura == Convert.ToDecimal(fattContr)
                                  && p.Scadenza == Convert.ToDateTime(scad)
                                  select p).First();
                        r.DataPagamento = this.datePagamento.Value;

                        db.SubmitChanges();
                        db.Refresh(System.Data.Linq.RefreshMode.KeepChanges, r);
                    }
                }                                              
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di inserimento dati");
            }                       
        }

        private void submitPerfTraspBtn_Click(object sender, EventArgs e)
        {
            //caso pefezionamento ORDINE vs TRASPORTO_CORRIERE
            this.Close();
        }

        private void submitTrasportoBtn_Click(object sender, EventArgs e)
        {/*
            Trasporto t = new Trasporto();

            t.Codice = this.textBox26.Text;
            t.Contratto_Numero = convertStringInt(this.comboBox8.ValueMember);
            t.Costo = convertStringFloat(this.textBox25.Text);
            t.Data_consegna_1 = this.dateTimePicker2.Value;
            t.Data_consegna_2 = null;
            t.Corriere_Partita_IVA = this.comboBox7.ValueMember;
            t.Indirizzo = this.textBox19.Text;
            t.Citta = this.textBox27.Text;
            t.Provincia = this.textBox24.Text;
            t.CAP = this.textBox20.Text;

            try
            {
                if (!(isString(t.Codice) &&
                    isString(t.Corriere_Partita_IVA) &&
                    isString(t.Indirizzo) &&
                    isString(t.Citta) &&
                    isString(t.Provincia) &&
                    isString(t.CAP) &&
                    isInt(t.Contratto_Numero) &&
                    isFloat(t.Costo)))
                {
                    throw new Exception("Campi vuoti");
                }
                //db.Trasporto.InsertOnSubmit(v);
                //db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di inserimento dati");
            }
            */

            this.Close();
        }

        private void submitModalitaPagBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Aggiungo mod pagamento del fornitore                
                if (currEntry == Entry.ModPag)
                {
                    ModalitàPagamento mp = new ModalitàPagamento();
                    var val = this.fornAddModPagComboBox.SelectedValue;
                    mp.Fornitore = val == null ? null : val.ToString();
                    mp.Da = convertStringFloat(this.textBox8.Text);
                    mp.A = convertStringFloat(this.textBox9.Text);
                    mp.NumeroRate = numericUpDown6.Value;
                    mp.Periodicità = this.comboBox4.Text;
                    mp.TassoInteresse = convertStringFloat(this.textBox12.Text);
                    if (!(isString(mp.Fornitore) &&
                            isFloat(mp.Da) &&
                            isFloat(mp.A) &&
                            isInt((int)mp.NumeroRate) &&
                            (mp.Da < mp.A) &&
                            isString(mp.Periodicità) &&
                            isFloat(mp.TassoInteresse)))
                    {
                        throw new Exception("Campi vuoti o errati");
                    }

                    db.ModalitàPagamento.InsertOnSubmit(mp);
                }
                else
                {
                    NostreModalitàPagamento nmp = new NostreModalitàPagamento();
                    nmp.Da = convertStringFloat(this.textBox8.Text);
                    nmp.A = convertStringFloat(this.textBox9.Text);
                    nmp.NumerRate = numericUpDown6.Value;
                    nmp.Periodicità = this.comboBox4.Text;
                    nmp.TassoInteresse = convertStringFloat(this.textBox12.Text);

                    if (!(isFloat(nmp.Da) &&
                            isFloat(nmp.A) &&
                            isInt((int)nmp.NumerRate) &&
                            (nmp.Da < nmp.A) &&
                            isString(nmp.Periodicità) &&
                            isFloat(nmp.TassoInteresse)))
                    {
                        throw new Exception("Campi vuoti o errati");
                    }

                    db.NostreModalitàPagamento.InsertOnSubmit(nmp);
                }

                db.SubmitChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di inserimento dati");
            }
        }

        private void submitRevisioneBtn_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void submitVeicoloBtn_Click(object sender, EventArgs e)
        {
            VeicoloCatalogo v = new VeicoloCatalogo();
            v.Codice = this.textBox53.Text;

            var val = this.comboBox14.SelectedValue;
            v.NomeModello = val == null ? null : val.ToString();

            val = this.comboBox28.SelectedValue;
            Boolean date = false;
            if (date = (val != null))            
                v.AnnoModello = Convert.ToDateTime(val.ToString());            
                         
            v.PrezzoBase = convertStringFloat(this.textBox51.Text);
            v.NumPosti = numericUpDown1.Value;
            v.CapienzaBagagliaio = convertStringFloat(this.textBox59.Text);
            v.NumPorte = numericUpDown2.Value;
            v.Potenza = convertStringFloat(this.textBox52.Text);
            val = this.comboBox18.SelectedValue;
            v.Trazione = val == null ? null : val.ToString();            
            v.Consumi = convertStringFloat(this.textBox54.Text);
            val = this.comboBox23.SelectedValue;
            v.Omologazione = val == null ? null : val.ToString();                         
            v.Cilindrata = convertStringFloat( this.textBox49.Text);
            val = this.comboBox16.SelectedValue;
            v.Cambio = val == null ? null : val.ToString();

            val = this.comboBox17.SelectedValue;
            v.TipoAlimentazione = val == null ? null : val.ToString();            
            v.CapacitàSerbatorio = convertStringFloat(this.textBox56.Text);
           
            Console.WriteLine(isString(v.Trazione));
            Console.WriteLine(isString(v.Omologazione));
            /*
            isFloat(v.Consumi) &&
                        isFloat(v.CapacitàSerbatorio) &&
                        isFloat(v.Cilindrata) &&
                        isString(v.TipoAlimentazione) &&
                        isString(v.Cambio) &&
                        isFloat(v.Potenza)))*/            




            try
            {
                if (!( isString(v.Codice) &&
                        isString(v.NomeModello) && 
                        date &&                                                
                        isFloat(v.PrezzoBase) &&
                        isFloat(v.CapienzaBagagliaio) &&                       
                        isString(v.Trazione) &&
                        isString(v.Omologazione) &&
                        isFloat(v.Consumi) &&
                        isFloat(v.CapacitàSerbatorio) &&
                        isFloat(v.Cilindrata) &&
                        isString(v.TipoAlimentazione) &&
                        isString(v.Cambio) &&
                        isFloat(v.Potenza)))
                {
                    throw new Exception("Campi vuoti o errati");
                }
                db.VeicoloCatalogo.InsertOnSubmit(v); 
                db.SubmitChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di inserimento dati");
            }                        
        }

        private void submitDettaglioBtn_Click(object sender, EventArgs e)
        {/*
            utilizzo u = new utilizzo();

            u.Veicolo_Numero_telaio = this.comboBox25.ValueMember;
            u.Riparazione_Numero = convertStringInt(this.comboBox1.ValueMember);
            u.Ricambio_Codice = this.comboBox10.ValueMember;
            u.quantita = convertStringInt(this.textBox16.Text);

            try
            {
                if (!(  isString(u.Veicolo_Numero_telaio) &&
                        isString(u.Ricambio_Codice) &&
                        isInt(u.Riparazione_Numero) &&
                        isInt((int)u.quantita)))
                {
                    throw new Exception("Campi vuoti");
                }
                //db.Riparazione.InsertOnSubmit(r);
                //db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di inserimento dati");
            }
            */
            this.Close();
        }

        private void submitRiparazione_Click(object sender, EventArgs e)
        {/*
            Riparazione r = new Riparazione();

            r.Veicolo_Numero_telaio = this.comboBox2.ValueMember;
            r.Numero = convertStringInt(this.textBox43.Text);
            r.Data = this.dateTimePicker5.Value;
            r.Importo_complessivo = convertStringFloat(this.textBox42.Text);
            try
            {
                if (!(isString(r.Veicolo_Numero_telaio) &&
                        isInt(r.Numero) &&
                        isFloat(r.Importo_complessivo)))
                {
                    throw new Exception("Campi vuoti");
                }
                //db.Riparazione.InsertOnSubmit(r);
                //db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di inserimento dati");
            }
            */
            this.Close();
        }

        private void submitAddVeicRicToOrderBtn_Click(object sender, EventArgs e)
        {

            // Inserisco ordine per veicolo
            if(this.currEntry == Entry.DetVeic)
            {
                var ov = new OrdineVeicolo();

                var val = this.comboBox3.SelectedValue;
                ov.Ordine = val == null ? -1 : convertStringInt(val.ToString());

                val = this.comboItem.SelectedValue;
                ov.Veicolo = val == null ? -1 : convertStringInt(val.ToString());

                ov.PrezzoFornitore = convertStringFloat(textBox1.Text);

                try
                {
                    if (!(isInt((int)ov.Ordine) &&                         
                         isInt((int)ov.Veicolo) &&                         
                         isFloat(ov.PrezzoFornitore)
                        ))
                    {
                        throw new Exception("Campi vuoti o errati");
                    }
                    db.OrdineVeicolo.InsertOnSubmit(ov);
                    db.SubmitChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Errore di inserimento dati");
                }

            } else
            {
                var or = new OrdineRicambio();

                var val = this.comboBox3.SelectedValue;
                or.Ordine = val == null ? -1 : convertStringInt(val.ToString());

                val = this.comboItem.SelectedValue;
                or.Ricambio = val == null ? null : val.ToString();

                or.PrezzoUnitario = convertStringFloat(textBox1.Text);

                or.Quantità = numericUpDown4.Value;

                try
                {
                    if (!(isInt((int)or.Ordine) &&                          
                         isString(or.Ricambio) &&
                         isInt((int)or.Quantità) &&                         
                         isFloat(or.PrezzoUnitario)
                        ))
                    {
                        throw new Exception("Campi vuoti o errati");
                    }
                    db.OrdineRicambio.InsertOnSubmit(or);
                    db.SubmitChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Errore di inserimento dati");
                }
            }
        }

        private void submitClientePBtn_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();

            c.CodiceFiscale = this.textBox18.Text;
            c.Nome = this.textBox14.Text;
            c.Cognome = this.textBox2.Text;
            c.DataNascita = dateTimePicker10.Value;
            c.CittàNascita = this.textBox73.Text;
            c.ProvinciaNascita = this.textBox23.Text;
            c.IndirizzoEmail1 = this.textBox76.Text;
            c.Recapito1 = this.textBox78.Text;
            c.Indirizzo = this.textBox87.Text;
            c.Città = this.textBox85.Text;
            c.Provincia = this.textBox86.Text;
            c.CAP = this.textBox88.Text;

            c.TipoCliente = 'p';

            try
            {
                if (!(isString(c.CodiceFiscale) &&
                          isString(c.Nome) &&
                          isString(c.Cognome) &&
                          isString(c.CittàNascita) &&
                          isString(c.ProvinciaNascita) &&                          
                          isString(c.Recapito1) &&
                          isString(c.Indirizzo) &&
                          isString(c.Città) &&                          
                          isString(c.Provincia) &&
                          isString(c.CAP)))
                {
                    throw new Exception("Campi vuoti o errati");
                }
                db.Cliente.InsertOnSubmit(c);
                db.SubmitChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di inserimento dati");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            Revisione r = new Revisione();

            r.Veicolo_Numero_telaio = this.comboBox26.ValueMember;
            r.Numero = convertStringInt(this.comboBox27.ValueMember);
            r.Data_esecuzione = this.dateTimePicker7.Value;

            try
            {
                if (!(  isString(r.Veicolo_Numero_telaio) &&
                        isInt(r.Numero)))
                {
                    throw new Exception("Campi vuoti");
                }
                //db.Riparazione.InsertOnSubmit(r);
                //db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di inserimento dati");
            }*/
            this.Close();
        }


        #endregion



        private void addGiacenzaPanel_Paint(object sender, PaintEventArgs e)
        {

        }




        #region EntryForm combobox setup

        /******************************************
         * Settaggio combobox in EntryForm Fatture
         ******************************************/

        // Mostro solo i fornitori con almeno una modalità di pagamento.
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            var pive = from f in this.db.Fornitore
                       where (from mod in this.db.ModalitàPagamento
                              where mod.Fornitore == f.PartitaIVA
                              select mod).ToList().Count > 0
                       select new { f.RagioneSociale, f.PartitaIVA };
            this.comboBox1.DataSource = pive.ToList();
            this.comboBox1.DisplayMember = "RagioneSociale";
            this.comboBox1.ValueMember = "PartitaIVA";

        }

        // Selezionato un fornitore, fillo il combobox con le relative modalità di pagamento.
        private void comboBox22_DropDown(object sender, EventArgs e)
        {
            var value = this.comboBox1.SelectedValue;
            if (value == null)
                return;

            String forn = value.ToString();
            var modpag = from f in this.db.ModalitàPagamento
                         where f.Fornitore == forn
                         select new { f.Da, member = f.Da + "-" + f.A };
            this.comboBox22.DataSource = modpag.ToList();
            this.comboBox22.DisplayMember = "member"; // nome del campo dell'oggetto corrente (della lista di oggetti passati) da visualizzare 
            this.comboBox22.ValueMember = "Da"; // nome del campo dell'oggetto corrente da restituire
        }

        private void comboBox9_DropDown(object sender, EventArgs e)
        {
            var value = this.comboBox1.SelectedValue;
            if (value == null)
                return;
            var o = from f in this.db.Ordine
                    where f.Fornitore == value.ToString()
                    select new {desc = ("Numero " + f.Id + " del " + f.DataOrdine), f.Id };

            ComboBox combo = (ComboBox)sender;
            combo.DataSource = o.ToList();
            combo.DisplayMember = "desc"; // nome del campo dell'oggetto corrente (della lista di oggetti passati) da visualizzare 
            combo.ValueMember = "Id"; // nome del campo dell'oggetto corrente da restituire            
        }


        private void fornitoreComboBox_DropDown(object sender, EventArgs e)
        {
            var pive = from f in this.db.Fornitore                       
                       select new { f.RagioneSociale, f.PartitaIVA };

            ComboBox combo = (ComboBox)sender;
            combo.DataSource = pive.ToList();
            combo.DisplayMember = "RagioneSociale";
            combo.ValueMember = "PartitaIVA";
        }

        private void comboFattura_DropDown(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;            

            // Caso di utilizzo per rata cliente            
            if (this.currEntry == Entry.Pagamento || this.currEntry == Entry.PerPagCli)
            {
                var data = from d in db.ContrattoVendita
                           select new { desc = ("Numero " + d.Numero + " del " + d.Data), d.Numero };
              
                combo.DataSource = data.ToList();
            } else // caso di utilizzo per rata fornitore
            {
                var value = this.comboFornitore.SelectedValue;
                if (value == null)
                    return;

                String forn = value.ToString();
                var data = from f in this.db.FatturaAcquisto
                             where f.Fornitore == forn
                             select new { desc = ("Numero " + f.Numero + " del " + f.Data), f.Numero };
               
                combo.DataSource = data.ToList();
            }
            combo.DisplayMember = "desc";
            combo.ValueMember = "Numero";
        }

        private void comboFornitore_DropDown(object sender, EventArgs e)
        {
            var pive = from f in this.db.Fornitore
                       where f.FatturaAcquisto.ToList().Count > 0
                       select new { f.RagioneSociale, f.PartitaIVA };

            ComboBox combo = (ComboBox)sender;
            combo.DataSource = pive.ToList();
            combo.DisplayMember = "RagioneSociale";
            combo.ValueMember = "PartitaIVA";
        }               

        private void comboScadenza_DropDown(object sender, EventArgs e)
        {
            var v = this.comboFattura.SelectedValue;
            if (v == null)
                return;

            String contFatt = v.ToString();

            if (this.currEntry == Entry.PerPagCli)
            {
                var q = from s in db.RataCliente
                        where s.Contratto == Convert.ToDecimal(contFatt)
                        select s.Scadenza;
                ComboBox combo = (ComboBox)sender;
                combo.DataSource = q.ToList();                
            } else
            {
                var value = this.comboFornitore.SelectedValue;
                if (value == null)
                    return;

                String forn = value.ToString();

                var q = from s in db.Rata
                        where s.FornitoreFattura == forn && s.NumeroFattura == Convert.ToDecimal(contFatt)
                        select s.Scadenza;
                ComboBox combo = (ComboBox)sender;
                combo.DataSource = q.ToList();
            }
            
        }

        private void casaProduttriceDropDown(object sender, EventArgs e)
        {
            var pive = from f in this.db.Fornitore
                       where f.CasaProduttrice == 'y'
                       select new { f.RagioneSociale, f.PartitaIVA };

            ComboBox combo = (ComboBox)sender;
            combo.DataSource = pive.ToList();
            combo.DisplayMember = "RagioneSociale";
            combo.ValueMember = "PartitaIVA";
        }

        private void comboBox24_DropDown(object sender, EventArgs e)
        {            
            var value = this.comboBox14.SelectedValue;
            if (value == null)
                return;

            String forn = value.ToString();
            var mod = from f in this.db.ModelloVeicolo
                         where f.Fornitore == forn
                         select f.Nome;

            this.comboBox24.DataSource = mod.ToList();            
        }

        private void comboBox13_DropDown(object sender, EventArgs e)
        {
            var pive = from f in this.db.Fornitore
                       where f.FornitoreRicambi == 'y'
                       select new { f.RagioneSociale, f.PartitaIVA };

            ComboBox combo = (ComboBox)sender;
            combo.DataSource = pive.ToList();
            combo.DisplayMember = "RagioneSociale";
            combo.ValueMember = "PartitaIVA";
        }
       
        private void ClienteDropDown(object sender, EventArgs e)
        {
            var cliP = from c in this.db.Cliente
                      where c.CodiceFiscale != null                       
                       select new Client {Member = (c.Nome + " " + c.Cognome + " CF: " + c.CodiceFiscale), Id = c.Id};

           var cliA = from c in this.db.Cliente
                      where c.PartitaIVA != null
                      select new Client {Member = (c.RagioneSociale + " PIVA: " + c.PartitaIVA), Id = c.Id};

            List<Client> clients = cliP.ToList<Client>();

            ComboBox combo = (ComboBox)sender;
            combo.DataSource = clients.Concat(cliA.ToList<Client>()).ToList<Client>();
            combo.DisplayMember = "Member";
            combo.ValueMember = "Id";
        }
        private class Client
        {
            public String Member { get; set; }
            public Decimal Id { get; set; }
        }

        private void comboBox5_DropDown(object sender, EventArgs e)
        {           
            var modpag = from f in this.db.NostreModalitàPagamento                      
                         select new { f.Da, member = f.Da + "-" + f.A };
            ComboBox combo = (ComboBox)sender;
            combo.DataSource = modpag.ToList();
            combo.DisplayMember = "member";
            combo.ValueMember = "Da";
        }

        private void comboBox28_DropDown(object sender, EventArgs e)
        {
            var value = this.comboBox24.SelectedValue;
            if (value == null)
                return;

            String mod = value.ToString();

            var anni = from f in this.db.ModelloVeicolo
                       where f.Nome == mod
                       select f.Anno;
            ComboBox combo = (ComboBox)sender;
            combo.DataSource = anni.ToList();          
        }

        private void comboBox19_DropDown(object sender, EventArgs e)
        {
            var data = from v in db.VeicoloCatalogo
                       select new { v.NomeModello, v.Codice };

            ComboBox combo = (ComboBox)sender;
            combo.DataSource = data;
            combo.DisplayMember = "NomeModello";
            combo.ValueMember = "Codice";
        }        

        private void comboBox20_DropDown(object sender, EventArgs e)
        {           
            var value = this.comboBox29.SelectedValue;
            if (value == null)
                return;

            Decimal cli = convertStringInt(value.ToString());

            var data = from v in db.ContrattoVendita
                       where v.Cliente == cli
                       select v.Numero;

            ComboBox combo = (ComboBox)sender;
            combo.DataSource = data;            
        }

        private void comboVeicVend_DropDown(object sender, EventArgs e)
        {
            var data = from v in db.VeicoloVenduto
                       select new {member=v.VeicoloCatalogo1.NomeModello + " ID: " + v.Id, v.Id };

            ComboBox combo = (ComboBox)sender;
            combo.DataSource = data;
            combo.DisplayMember = "member";
            combo.ValueMember = "Id";
        }

        private void comboOpt_DropDown(object sender, EventArgs e)
        {/*
            var value = this.comboVeicVend.SelectedValue;
            if (value == null)
                return;

            String veic = value.ToString();
            var op = from f in this.db.Optional
                      where f.Supporto == forn
                      select f.Nome;

            this.comboBox24.DataSource = mod.ToList();*/
        }
    }

    #endregion
}

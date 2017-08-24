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
            this.panelMap.Add(Entry.PerPagForn, this.addPerfPanel);

            // Gestione Cliente
            this.panelMap.Add(Entry.Cliente, this.addClientePanel);
            this.panelMap.Add(Entry.Contratto, this.addContrattoPanel);
            this.panelMap.Add(Entry.Pagamento, this.addPagamentoPanel);
            this.panelMap.Add(Entry.NsModPag, this.addModalitaPagPanel);
            this.panelMap.Add(Entry.PerPagCli, this.addPerfPanel);

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
            if (this.currEntry == Entry.Pagamento)
            {
                this.contratto_AddPagLabel.Text = "Contratto";
                this.comboContratto.BringToFront();
                this.label126.Visible = false;
                this.comboFornitore.Visible = false;
            }
            else
            {
                this.contratto_AddPagLabel.Text = "Fattura";
                this.comboFattura.BringToFront();
                this.label126.Visible = true;
                this.comboFornitore.Visible = true;
            }
        }

        // per inserire la DATA EFFETTIVA CONSEGNA sia dell'ORDINE che del VEICOLO al cliente
        // e per le rate cliente/fornitore
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
            else if (this.currEntry == Entry.PerfTrasp)
            {
                this.label48.Text = "Codice trasporto";
                var data = from o in db.Trasporto
                           where o.DataConsegna == null
                           select new { desc = ("Codice " + o.Codice + " del " + o.DataConsegnaPrevista), o.Codice };

                comboPerf.DataSource = data.ToList();
                comboPerf.DisplayMember = "desc";
                comboPerf.ValueMember = "Codice";
            }
            else
            {
                this.label48.Text = "Pagamento";
                if (this.currEntry == Entry.PerPagForn)
                {
                    var data = from o in db.Rata
                               where o.DataPagamento == null
                               select new
                               {
                                   desc = ("Fornitore: " + o.FornitoreFattura + " fattura: " + o.NumeroFattura),
                                   id = new { o.FornitoreFattura, o.NumeroFattura, o.Scadenza }
                               };

                    comboPerf.DataSource = data.ToList();                    
                }
                else
                {
                    var data = from o in db.RataCliente
                               where o.DataPagamento == null
                               select new
                               {
                                   desc = ("Contratto: " + o.Contratto),
                                   id = new { o.Contratto, o.Scadenza }
                               };

                    comboPerf.DataSource = data.ToList();

                }
                comboPerf.DisplayMember = "desc";
                comboPerf.ValueMember = "id";
            }                    
        }

        // usato sia per DETTAGLIO ORDINE VEICOLO che RICAMBIO
        private void addVeicRicToOrdinePanel_VisibleChanged(object sender, EventArgs e)
        {
            if (this.currEntry == Entry.DetVeic)
            {
                this.label129.Text = "Veicolo";
                this.comboVeicolo.BringToFront();
            }
            else
            {
                this.label129.Text = "Ricambio";
                this.comboRicambio.BringToFront();
            }

            // occorre riempire il comboBox adeguatamente
            /*  var q =
             from c in Class
             select new { Name = c.CompanyName, ID = c.CompanyID };

              companyComboBox.ItemsSource = companyQuery.ToList();
              companyComboBox.DisplayMemberPath = "Name";
              companyComboBox.SelectedValuePath = "ID";
              InitializeComponent();
              */
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
                    this.comboRic.BringToFront();
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
            else if (currEntry != Entry.OptToVeicVend)
            {
                this.comboVeicCat.BringToFront();
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
        {/*
            Veicolo_venduto vv = new Veicolo_venduto();

            vv.Numero_telaio = this.textBox67.Text;
            vv.Contratto_Numero = convertStringInt(this.comboBox20.ValueMember);
            vv.Ordine_ID_ordine = this.comboBox18.ValueMember;
            vv.Veicolo_Codice = this.comboBox19.ValueMember;

            try
            {
                if (!(isString(vv.Numero_telaio) &&
                        isString(vv.Veicolo_Codice) &&
                        isString(vv.Ordine_ID_ordine) &&
                        isInt(vv.Contratto_Numero)))
                {
                    throw new Exception("Campi vuoti");
                }
                //db.Veicolo_venduto.InsertOnSubmit(vv);
                //db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di inserimento dati");
            }*/

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
        {/*
            Modello_veicolo m = new Modello_veicolo();

            m.Nome = this.textBox74.Text;
            m.Anno = this.dateTimePicker15.Value;
            m.Fornitore_Partita_IVA = this.comboBox15.ValueMember;

            try
            {
                if (!(isString(m.Nome) &&
                        isString(m.Fornitore_Partita_IVA)))
                {
                    throw new Exception("Campi vuoti");
                }
                //db.Modello_veicolo.InsertOnSubmit(m);
                //db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di inserimento dati");
            }
            */
            this.Close();
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
        {/*
            Contratto_di_vendita v = new Contratto_di_vendita();
            //Da aggiungere numero

            v.Data = this.dateTimePicker9.Value;
            v.Importo_complessivo = convertStringFloat(this.textBox21.Text);
            v.Nostre_Mod_Da = convertStringFloat(this.comboBox6.ValueMember);
            v.Cliente_PartitaIVA_CodiceFiscale = this.comboBox5.ValueMember;
            try
            {
                if (!(isString(v.Cliente_PartitaIVA_CodiceFiscale) &&
                        isFloat(v.Importo_complessivo) &&
                        isFloat(v.Nostre_Mod_Da)))
                {
                    throw new Exception("Campi vuoti");
                }
                //db.Contratto_di_vendita.InsertOnSubmit(v);
                //db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di inserimento dati");
            }*/
            this.Close();
        }

        private void submitClienteABtn_Click(object sender, EventArgs e)
        {/*
            Cliente c = new Cliente();

            c.PartitaIVA_CodiceFiscale = this.textBox82.Text;
            c.Ragione_sociale = this.textBox80.Text;
            c.Indirizzo_e_mail_1 = this.textBox81.Text;
            c.Indirizzo_e_mail_2 = this.textBox15.Text;
            c.Recapito_1 = this.textBox79.Text;
            c.Recapito_2 = this.textBox17.Text;
            c.Recapito_3 = this.textBox1.Text;
            c.Indirizzo = this.textBox31.Text;
            c.Citta = this.textBox28.Text;
            c.Provincia = this.textBox30.Text;
            c.CAP = this.textBox32.Text;

            try
            {
                if ( ! (  isString(c.PartitaIVA_CodiceFiscale) &&
                          isString(c.Ragione_sociale) &&
                          isString(c.Indirizzo_e_mail_1) &&
                          isString(c.Recapito_1) &&
                          isString(c.Indirizzo) &&
                          isString(c.Citta) &&
                          isString(c.Citta) &&
                          isString(c.Provincia) &&
                          isString(c.CAP)))
                {
                    throw new Exception("Campi vuoti");
                }
                //db.Contratto_di_vendita.InsertOnSubmit(c);
                //db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di inserimento dati");
            }
            */
            this.Close();
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

                }
                else
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
                }               

                db.SubmitChanges();
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
            // mino uso questo metodo sia per le nostre modalità di pagamento che per quelle del
            // fornitore, il se inserire le nostre modalità o quelle del fornitore lo aggiungo poi io
            
            ModalitàPagamento mp = new ModalitàPagamento();
            NostreModalitàPagamento nmp = new NostreModalitàPagamento();
            var val = this.fornAddModPagComboBox.SelectedValue;
            mp.Fornitore = val == null ? null : val.ToString();
            nmp.Da = mp.Da = convertStringFloat( this.textBox8.Text);
            nmp.A = mp.A = convertStringFloat(this.textBox9.Text);
            nmp.NumerRate = mp.NumeroRate = convertStringInt(this.textBox10.Text);           
            nmp.Periodicità = mp.Periodicità = this.comboBox4.Text;
            nmp.TassoInteresse = mp.TassoInteresse = convertStringFloat(this.textBox12.Text);

            try
            {
                if (!(  isString(mp.Fornitore) &&
                        isFloat(mp.Da) &&
                        isFloat(mp.A) &&
                        isInt((int)mp.NumeroRate) &&
                        (mp.Da < mp.A) &&
                        isString(mp.Periodicità) &&
                        isFloat(mp.TassoInteresse)))
                {
                    throw new Exception("Campi vuoti o errati");
                }               

                // Aggiungo mod pagamento del fornitore                
                if (currEntry == Entry.ModPag)                
                    db.ModalitàPagamento.InsertOnSubmit(mp);                
                // Aggiungo mie modalità di pagamento
                else                
                    db.NostreModalitàPagamento.InsertOnSubmit(nmp);                

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
        {/*
            Veicolo_in_catalogo v = new Veicolo_in_catalogo();
            v.Codice = this.textBox53.Text;
            v.Modello_Nome = this.comboBox14.ValueMember;
            v.Modello_Partita_IVA = this.comboBox24.ValueMember;
            v.Modello_Anno = this.dateTimePicker14.Value;

            v.Prezzo_base =convertStringFloat(this.textBox51.Text);
            v.No_posti =convertStringInt(this.textBox55.Text);
            v.Capienza_bagagliaio =convertStringFloat(this.textBox59.Text);
            v.No_porte = convertStringInt(this.textBox58.Text);

            v.Potenza = convertStringFloat(this.textBox52.Text);
            v.Trazione = this.textBox61.Text;
            v.Consumi = convertStringFloat(this.textBox54.Text);
            v.Omologazione = this.textBox57.Text;
            v.Cilindrata =convertStringFloat( this.textBox49.Text);
            v.Cambio = this.textBox60.Text;
            v.Tipo_alimentazione = this.textBox50.Text;
            v.Capacita_serbatorio =convertStringFloat(this.textBox56.Text);

            try
            {
                if (!(  isString(v.Codice) &&
                        isString(v.Modello_Nome) &&
                        isString(v.Modello_Partita_IVA) &&

                        isFloat(v.Prezzo_base) &&
                        isFloat(v.Capienza_bagagliaio) &&
                        isInt(v.No_posti) &&
                        isInt(v.No_porte) &&

                        isString(v.Trazione) &&
                        isString(v.Omologazione) &&
                        isFloat(v.Consumi) &&
                        isFloat(v.Capacita_serbatorio) &&
                        isFloat(v.Cilindrata) &&
                        isString(v.Tipo_alimentazione) &&
                        isString(v.Cambio) &&
                        isFloat(v.Potenza)))
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
            //uso lo stesso metodo per inserire un veicolo/ricambio in un dettaglio d'ordine
            //il check add veicolo/ricambio lo farà io, completa il resto
            this.Close();
        }

        private void submitClientePBtn_Click(object sender, EventArgs e)
        {
            // settare il tipo di cliente 
            this.Close();
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
            if (this.currEntry == Entry.Pagamento)
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
    }

    #endregion
}

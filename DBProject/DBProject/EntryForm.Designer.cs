using System.Collections.Generic;
using System.Windows.Forms;

namespace DBProject
{
    partial class EntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            this.addFornitorePanel = new System.Windows.Forms.Panel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.textBoxFornPIVA = new System.Windows.Forms.TextBox();
            this.textBoxFornRagSoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.checkBoxFornRic = new System.Windows.Forms.CheckBox();
            this.checkBoxFornVeic = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label98 = new System.Windows.Forms.Label();
            this.textBoxFornEmail1 = new System.Windows.Forms.TextBox();
            this.label100 = new System.Windows.Forms.Label();
            this.textBoxFornEmail2 = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.textBoxFornRec1 = new System.Windows.Forms.TextBox();
            this.label96 = new System.Windows.Forms.Label();
            this.textBoxFornRec3 = new System.Windows.Forms.TextBox();
            this.textBoxFornRec2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxFornCitta = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.textBoxFornProvincia = new System.Windows.Forms.TextBox();
            this.textBoxFornIndirizzo = new System.Windows.Forms.TextBox();
            this.textBoxFornCAP = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.submitFornitoreBtn = new System.Windows.Forms.Button();
            this.addFatturaPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox22 = new System.Windows.Forms.ComboBox();
            this.modalitadipagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progettoDB16DataSet = new DBProject.ProgettoDB16DataSet();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.submitFatturaBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fornitoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.addModalitaPagPanel = new System.Windows.Forms.Panel();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.submitModalitaPagBtn = new System.Windows.Forms.Button();
            this.fornAddModPagComboBox = new System.Windows.Forms.ComboBox();
            this.fornAddModPagLabel = new System.Windows.Forms.Label();
            this.submitTrasportoBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.submitRevisioneBtn = new System.Windows.Forms.Button();
            this.submitOptionalBtn = new System.Windows.Forms.Button();
            this.submitRicambioBtn = new System.Windows.Forms.Button();
            this.submitDettaglioBtn = new System.Windows.Forms.Button();
            this.submitOptToVeicBtn = new System.Windows.Forms.Button();
            this.submitVenditaBtn = new System.Windows.Forms.Button();
            this.submitModelloBtn = new System.Windows.Forms.Button();
            this.submitRiparazione = new System.Windows.Forms.Button();
            this.submitVeicoloBtn = new System.Windows.Forms.Button();
            this.submitContrattoBtn = new System.Windows.Forms.Button();
            this.submitPerfTraspBtn = new System.Windows.Forms.Button();
            this.submitClienteABtn = new System.Windows.Forms.Button();
            this.submitGiacenzaBtn = new System.Windows.Forms.Button();
            this.submitPagamentoBtn = new System.Windows.Forms.Button();
            this.submitClientePBtn = new System.Windows.Forms.Button();
            this.submitAddOrdineBtn = new System.Windows.Forms.Button();
            this.submitAddVeicRicToOrderBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addClientePanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.textBox75 = new System.Windows.Forms.TextBox();
            this.label103 = new System.Windows.Forms.Label();
            this.textBox76 = new System.Windows.Forms.TextBox();
            this.label104 = new System.Windows.Forms.Label();
            this.textBox78 = new System.Windows.Forms.TextBox();
            this.label110 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker10 = new System.Windows.Forms.DateTimePicker();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label99 = new System.Windows.Forms.Label();
            this.textBox73 = new System.Windows.Forms.TextBox();
            this.label101 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.textBox85 = new System.Windows.Forms.TextBox();
            this.label112 = new System.Windows.Forms.Label();
            this.textBox86 = new System.Windows.Forms.TextBox();
            this.textBox87 = new System.Windows.Forms.TextBox();
            this.textBox88 = new System.Windows.Forms.TextBox();
            this.label113 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.textBox77 = new System.Windows.Forms.TextBox();
            this.label105 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label111 = new System.Windows.Forms.Label();
            this.textBox79 = new System.Windows.Forms.TextBox();
            this.label116 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.textBox80 = new System.Windows.Forms.TextBox();
            this.label108 = new System.Windows.Forms.Label();
            this.textBox82 = new System.Windows.Forms.TextBox();
            this.label109 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label106 = new System.Windows.Forms.Label();
            this.textBox81 = new System.Windows.Forms.TextBox();
            this.label107 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.addContrattoPanel = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker9 = new System.Windows.Forms.DateTimePicker();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.nostremodalitadipagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.addTrasportoPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.contrattodivenditaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label31 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.corriereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label29 = new System.Windows.Forms.Label();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.addPerfPanel = new System.Windows.Forms.Panel();
            this.comboOrdine = new System.Windows.Forms.ComboBox();
            this.ordineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboTrasporto = new System.Windows.Forms.ComboBox();
            this.trasportoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.addPagamentoPanel = new System.Windows.Forms.Panel();
            this.comboFornitore = new System.Windows.Forms.ComboBox();
            this.label126 = new System.Windows.Forms.Label();
            this.comboFattura = new System.Windows.Forms.ComboBox();
            this.fatturadiacquistoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboContratto = new System.Windows.Forms.ComboBox();
            this.contrattodivenditaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label39 = new System.Windows.Forms.Label();
            this.contratto_AddPagLabel = new System.Windows.Forms.Label();
            this.addRiparazionePanel = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.veicolovendutoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.addUtilizzoRicambioRipPanel = new System.Windows.Forms.Panel();
            this.comboBox25 = new System.Windows.Forms.ComboBox();
            this.riparazioneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label120 = new System.Windows.Forms.Label();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.ricambioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label21 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.addRicambioPanel = new System.Windows.Forms.Panel();
            this.label119 = new System.Windows.Forms.Label();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.label64 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label55 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.addGiacenzaPanel = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.addVeicoloPanel = new System.Windows.Forms.Panel();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker14 = new System.Windows.Forms.DateTimePicker();
            this.comboBox24 = new System.Windows.Forms.ComboBox();
            this.label65 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.modelloveicoloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label117 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label75 = new System.Windows.Forms.Label();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.label77 = new System.Windows.Forms.Label();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.addModelloPanel = new System.Windows.Forms.Panel();
            this.dateTimePicker15 = new System.Windows.Forms.DateTimePicker();
            this.label79 = new System.Windows.Forms.Label();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.textBox74 = new System.Windows.Forms.TextBox();
            this.addOptionalPanel = new System.Windows.Forms.Panel();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.textBox65 = new System.Windows.Forms.TextBox();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.addOptToVeicPanel = new System.Windows.Forms.Panel();
            this.comboRic = new System.Windows.Forms.ComboBox();
            this.comboVeicCat = new System.Windows.Forms.ComboBox();
            this.veicoloincatalogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboOpt = new System.Windows.Forms.ComboBox();
            this.optionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboVeicVend = new System.Windows.Forms.ComboBox();
            this.veicolovendutoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label84 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.addVenditaPanel = new System.Windows.Forms.Panel();
            this.comboBox20 = new System.Windows.Forms.ComboBox();
            this.label95 = new System.Windows.Forms.Label();
            this.textBox67 = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.comboBox19 = new System.Windows.Forms.ComboBox();
            this.label86 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.addRevisionePanel = new System.Windows.Forms.Panel();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label90 = new System.Windows.Forms.Label();
            this.dateTimePicker8 = new System.Windows.Forms.DateTimePicker();
            this.label89 = new System.Windows.Forms.Label();
            this.comboBox21 = new System.Windows.Forms.ComboBox();
            this.veicolovendutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label93 = new System.Windows.Forms.Label();
            this.addOrdinePanel = new System.Windows.Forms.Panel();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.label122 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox30 = new System.Windows.Forms.ComboBox();
            this.fatturadiacquistoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label123 = new System.Windows.Forms.Label();
            this.comboBox29 = new System.Windows.Forms.ComboBox();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.dateTimePicker13 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker12 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker11 = new System.Windows.Forms.DateTimePicker();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.addVeicRicToOrdinePanel = new System.Windows.Forms.Panel();
            this.comboVeicolo = new System.Windows.Forms.ComboBox();
            this.textBox93 = new System.Windows.Forms.TextBox();
            this.comboRicambio = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label129 = new System.Windows.Forms.Label();
            this.label131 = new System.Windows.Forms.Label();
            this.label130 = new System.Windows.Forms.Label();
            this.addEsecRevPanel = new System.Windows.Forms.Panel();
            this.comboBox27 = new System.Windows.Forms.ComboBox();
            this.revisioneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label125 = new System.Windows.Forms.Label();
            this.comboBox26 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker7 = new System.Windows.Forms.DateTimePicker();
            this.label94 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.ricambioTableAdapter = new DBProject.ProgettoDB16DataSetTableAdapters.RicambioTableAdapter();
            this.contratto_di_venditaTableAdapter = new DBProject.ProgettoDB16DataSetTableAdapters.Contratto_di_venditaTableAdapter();
            this.veicolo_vendutoTableAdapter = new DBProject.ProgettoDB16DataSetTableAdapters.Veicolo_vendutoTableAdapter();
            this.revisioneTableAdapter = new DBProject.ProgettoDB16DataSetTableAdapters.RevisioneTableAdapter();
            this.trasportoTableAdapter = new DBProject.ProgettoDB16DataSetTableAdapters.TrasportoTableAdapter();
            this.corriereTableAdapter = new DBProject.ProgettoDB16DataSetTableAdapters.CorriereTableAdapter();
            this.fornitoreTableAdapter = new DBProject.ProgettoDB16DataSetTableAdapters.FornitoreTableAdapter();
            this.veicolo_in_catalogoTableAdapter = new DBProject.ProgettoDB16DataSetTableAdapters.Veicolo_in_catalogoTableAdapter();
            this.ordineTableAdapter = new DBProject.ProgettoDB16DataSetTableAdapters.OrdineTableAdapter();
            this.optionalTableAdapter = new DBProject.ProgettoDB16DataSetTableAdapters.OptionalTableAdapter();
            this.modello_veicoloTableAdapter = new DBProject.ProgettoDB16DataSetTableAdapters.Modello_veicoloTableAdapter();
            this.riparazioneTableAdapter = new DBProject.ProgettoDB16DataSetTableAdapters.RiparazioneTableAdapter();
            this.fattura_di_acquistoTableAdapter = new DBProject.ProgettoDB16DataSetTableAdapters.Fattura_di_acquistoTableAdapter();
            this.modalita_di_pagamentoTableAdapter = new DBProject.ProgettoDB16DataSetTableAdapters.Modalita_di_pagamentoTableAdapter();
            this.clienteTableAdapter = new DBProject.ProgettoDB16DataSetTableAdapters.ClienteTableAdapter();
            this.nostre_modalita_di_pagamentoTableAdapter = new DBProject.ProgettoDB16DataSetTableAdapters.Nostre_modalita_di_pagamentoTableAdapter();
            this.addFornitorePanel.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.addFatturaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modalitadipagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progettoDB16DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornitoreBindingSource)).BeginInit();
            this.addModalitaPagPanel.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.addClientePanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.addContrattoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nostremodalitadipagamentoBindingSource)).BeginInit();
            this.addTrasportoPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrattodivenditaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corriereBindingSource)).BeginInit();
            this.addPerfPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trasportoBindingSource)).BeginInit();
            this.addPagamentoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fatturadiacquistoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrattodivenditaBindingSource)).BeginInit();
            this.addRiparazionePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veicolovendutoBindingSource1)).BeginInit();
            this.addUtilizzoRicambioRipPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riparazioneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricambioBindingSource)).BeginInit();
            this.addRicambioPanel.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.addGiacenzaPanel.SuspendLayout();
            this.addVeicoloPanel.SuspendLayout();
            this.groupBox21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelloveicoloBindingSource)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.addModelloPanel.SuspendLayout();
            this.addOptionalPanel.SuspendLayout();
            this.addOptToVeicPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veicoloincatalogoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veicolovendutoBindingSource2)).BeginInit();
            this.addVenditaPanel.SuspendLayout();
            this.addRevisionePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veicolovendutoBindingSource)).BeginInit();
            this.addOrdinePanel.SuspendLayout();
            this.groupBox24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fatturadiacquistoBindingSource)).BeginInit();
            this.groupBox22.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.addVeicRicToOrdinePanel.SuspendLayout();
            this.addEsecRevPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.revisioneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addFornitorePanel
            // 
            this.addFornitorePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addFornitorePanel.Controls.Add(this.groupBox11);
            this.addFornitorePanel.Controls.Add(this.groupBox10);
            this.addFornitorePanel.Controls.Add(this.groupBox9);
            this.addFornitorePanel.Controls.Add(this.groupBox8);
            this.addFornitorePanel.Controls.Add(this.groupBox2);
            this.addFornitorePanel.Controls.Add(this.submitFornitoreBtn);
            this.addFornitorePanel.Location = new System.Drawing.Point(1, -2);
            this.addFornitorePanel.Name = "addFornitorePanel";
            this.addFornitorePanel.Size = new System.Drawing.Size(836, 471);
            this.addFornitorePanel.TabIndex = 0;
            this.addFornitorePanel.VisibleChanged += new System.EventHandler(this.addFornitorePanel_VisibleChanged);
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox11.Controls.Add(this.textBoxFornPIVA);
            this.groupBox11.Controls.Add(this.textBoxFornRagSoc);
            this.groupBox11.Controls.Add(this.label1);
            this.groupBox11.Controls.Add(this.label2);
            this.groupBox11.Location = new System.Drawing.Point(45, 38);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(366, 90);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Nominativi";
            // 
            // textBoxFornPIVA
            // 
            this.textBoxFornPIVA.Location = new System.Drawing.Point(174, 25);
            this.textBoxFornPIVA.Name = "textBoxFornPIVA";
            this.textBoxFornPIVA.Size = new System.Drawing.Size(188, 20);
            this.textBoxFornPIVA.TabIndex = 1;
            // 
            // textBoxFornRagSoc
            // 
            this.textBoxFornRagSoc.Location = new System.Drawing.Point(173, 51);
            this.textBoxFornRagSoc.Name = "textBoxFornRagSoc";
            this.textBoxFornRagSoc.Size = new System.Drawing.Size(188, 20);
            this.textBoxFornRagSoc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Partita IVA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ragione sociale";
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox10.Controls.Add(this.checkBoxFornRic);
            this.groupBox10.Controls.Add(this.checkBoxFornVeic);
            this.groupBox10.Location = new System.Drawing.Point(441, 221);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(161, 79);
            this.groupBox10.TabIndex = 12;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Tipologia";
            // 
            // checkBoxFornRic
            // 
            this.checkBoxFornRic.AutoSize = true;
            this.checkBoxFornRic.Location = new System.Drawing.Point(24, 46);
            this.checkBoxFornRic.Name = "checkBoxFornRic";
            this.checkBoxFornRic.Size = new System.Drawing.Size(114, 17);
            this.checkBoxFornRic.TabIndex = 13;
            this.checkBoxFornRic.Text = "Fornitore di ricambi";
            this.checkBoxFornRic.UseVisualStyleBackColor = true;
            // 
            // checkBoxFornVeic
            // 
            this.checkBoxFornVeic.AutoSize = true;
            this.checkBoxFornVeic.Location = new System.Drawing.Point(24, 24);
            this.checkBoxFornVeic.Name = "checkBoxFornVeic";
            this.checkBoxFornVeic.Size = new System.Drawing.Size(111, 17);
            this.checkBoxFornVeic.TabIndex = 12;
            this.checkBoxFornVeic.Text = "Fornitore di veicoli";
            this.checkBoxFornVeic.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox9.Controls.Add(this.label98);
            this.groupBox9.Controls.Add(this.textBoxFornEmail1);
            this.groupBox9.Controls.Add(this.label100);
            this.groupBox9.Controls.Add(this.textBoxFornEmail2);
            this.groupBox9.Location = new System.Drawing.Point(45, 270);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(366, 82);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Indirizzi email";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(11, 26);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(53, 13);
            this.label98.TabIndex = 6;
            this.label98.Text = "Principale";
            // 
            // textBoxFornEmail1
            // 
            this.textBoxFornEmail1.Location = new System.Drawing.Point(174, 19);
            this.textBoxFornEmail1.Name = "textBoxFornEmail1";
            this.textBoxFornEmail1.Size = new System.Drawing.Size(188, 20);
            this.textBoxFornEmail1.TabIndex = 6;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(11, 48);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(61, 13);
            this.label100.TabIndex = 11;
            this.label100.Text = "Secondario";
            // 
            // textBoxFornEmail2
            // 
            this.textBoxFornEmail2.Location = new System.Drawing.Point(173, 45);
            this.textBoxFornEmail2.Name = "textBoxFornEmail2";
            this.textBoxFornEmail2.Size = new System.Drawing.Size(188, 20);
            this.textBoxFornEmail2.TabIndex = 7;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.label97);
            this.groupBox8.Controls.Add(this.textBoxFornRec1);
            this.groupBox8.Controls.Add(this.label96);
            this.groupBox8.Controls.Add(this.textBoxFornRec3);
            this.groupBox8.Controls.Add(this.textBoxFornRec2);
            this.groupBox8.Location = new System.Drawing.Point(45, 143);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(366, 111);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Recapiti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Principale";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(13, 74);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(46, 13);
            this.label97.TabIndex = 13;
            this.label97.Text = "Ulteriore";
            // 
            // textBoxFornRec1
            // 
            this.textBoxFornRec1.Location = new System.Drawing.Point(174, 21);
            this.textBoxFornRec1.Name = "textBoxFornRec1";
            this.textBoxFornRec1.Size = new System.Drawing.Size(188, 20);
            this.textBoxFornRec1.TabIndex = 3;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(11, 50);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(61, 13);
            this.label96.TabIndex = 11;
            this.label96.Text = "Secondario";
            // 
            // textBoxFornRec3
            // 
            this.textBoxFornRec3.Location = new System.Drawing.Point(173, 73);
            this.textBoxFornRec3.Name = "textBoxFornRec3";
            this.textBoxFornRec3.Size = new System.Drawing.Size(188, 20);
            this.textBoxFornRec3.TabIndex = 5;
            // 
            // textBoxFornRec2
            // 
            this.textBoxFornRec2.Location = new System.Drawing.Point(173, 47);
            this.textBoxFornRec2.Name = "textBoxFornRec2";
            this.textBoxFornRec2.Size = new System.Drawing.Size(188, 20);
            this.textBoxFornRec2.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.textBoxFornCitta);
            this.groupBox2.Controls.Add(this.label42);
            this.groupBox2.Controls.Add(this.textBoxFornProvincia);
            this.groupBox2.Controls.Add(this.textBoxFornIndirizzo);
            this.groupBox2.Controls.Add(this.textBoxFornCAP);
            this.groupBox2.Controls.Add(this.label50);
            this.groupBox2.Controls.Add(this.label52);
            this.groupBox2.Controls.Add(this.label51);
            this.groupBox2.Location = new System.Drawing.Point(438, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 123);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sede";
            // 
            // textBoxFornCitta
            // 
            this.textBoxFornCitta.Location = new System.Drawing.Point(174, 44);
            this.textBoxFornCitta.Name = "textBoxFornCitta";
            this.textBoxFornCitta.Size = new System.Drawing.Size(188, 20);
            this.textBoxFornCitta.TabIndex = 9;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(13, 23);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(45, 13);
            this.label42.TabIndex = 28;
            this.label42.Text = "Indirizzo";
            // 
            // textBoxFornProvincia
            // 
            this.textBoxFornProvincia.Location = new System.Drawing.Point(174, 71);
            this.textBoxFornProvincia.Name = "textBoxFornProvincia";
            this.textBoxFornProvincia.Size = new System.Drawing.Size(188, 20);
            this.textBoxFornProvincia.TabIndex = 10;
            // 
            // textBoxFornIndirizzo
            // 
            this.textBoxFornIndirizzo.Location = new System.Drawing.Point(174, 18);
            this.textBoxFornIndirizzo.Name = "textBoxFornIndirizzo";
            this.textBoxFornIndirizzo.Size = new System.Drawing.Size(188, 20);
            this.textBoxFornIndirizzo.TabIndex = 8;
            // 
            // textBoxFornCAP
            // 
            this.textBoxFornCAP.Location = new System.Drawing.Point(174, 96);
            this.textBoxFornCAP.Name = "textBoxFornCAP";
            this.textBoxFornCAP.Size = new System.Drawing.Size(92, 20);
            this.textBoxFornCAP.TabIndex = 11;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(13, 47);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(28, 13);
            this.label50.TabIndex = 27;
            this.label50.Text = "Città";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(13, 99);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(28, 13);
            this.label52.TabIndex = 25;
            this.label52.Text = "CAP";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(13, 74);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(51, 13);
            this.label51.TabIndex = 26;
            this.label51.Text = "Provincia";
            // 
            // submitFornitoreBtn
            // 
            this.submitFornitoreBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitFornitoreBtn.BackColor = System.Drawing.Color.White;
            this.submitFornitoreBtn.Image = ((System.Drawing.Image)(resources.GetObject("submitFornitoreBtn.Image")));
            this.submitFornitoreBtn.Location = new System.Drawing.Point(389, 418);
            this.submitFornitoreBtn.Name = "submitFornitoreBtn";
            this.submitFornitoreBtn.Size = new System.Drawing.Size(46, 45);
            this.submitFornitoreBtn.TabIndex = 14;
            this.toolTip1.SetToolTip(this.submitFornitoreBtn, "Invia");
            this.submitFornitoreBtn.UseVisualStyleBackColor = false;
            this.submitFornitoreBtn.Click += new System.EventHandler(this.submitFornitoreBtn_Click);
            // 
            // addFatturaPanel
            // 
            this.addFatturaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addFatturaPanel.Controls.Add(this.label4);
            this.addFatturaPanel.Controls.Add(this.comboBox22);
            this.addFatturaPanel.Controls.Add(this.dateTimePicker1);
            this.addFatturaPanel.Controls.Add(this.submitFatturaBtn);
            this.addFatturaPanel.Controls.Add(this.label13);
            this.addFatturaPanel.Controls.Add(this.comboBox1);
            this.addFatturaPanel.Controls.Add(this.label7);
            this.addFatturaPanel.Controls.Add(this.label6);
            this.addFatturaPanel.Controls.Add(this.label5);
            this.addFatturaPanel.Controls.Add(this.textBox7);
            this.addFatturaPanel.Controls.Add(this.textBox5);
            this.addFatturaPanel.Location = new System.Drawing.Point(1, -1);
            this.addFatturaPanel.Name = "addFatturaPanel";
            this.addFatturaPanel.Size = new System.Drawing.Size(836, 471);
            this.addFatturaPanel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Modalità di pagamento";
            // 
            // comboBox22
            // 
            this.comboBox22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox22.DataSource = this.modalitadipagamentoBindingSource;
            this.comboBox22.DisplayMember = "Da";
            this.comboBox22.FormattingEnabled = true;
            this.comboBox22.Location = new System.Drawing.Point(395, 285);
            this.comboBox22.Name = "comboBox22";
            this.comboBox22.Size = new System.Drawing.Size(191, 21);
            this.comboBox22.TabIndex = 5;
            this.comboBox22.ValueMember = "Da";
            // 
            // modalitadipagamentoBindingSource
            // 
            this.modalitadipagamentoBindingSource.DataMember = "Modalita_di_pagamento";
            this.modalitadipagamentoBindingSource.DataSource = this.progettoDB16DataSet;
            // 
            // progettoDB16DataSet
            // 
            this.progettoDB16DataSet.DataSetName = "ProgettoDB16DataSet";
            this.progettoDB16DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(395, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // submitFatturaBtn
            // 
            this.submitFatturaBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitFatturaBtn.BackColor = System.Drawing.Color.White;
            this.submitFatturaBtn.Image = ((System.Drawing.Image)(resources.GetObject("submitFatturaBtn.Image")));
            this.submitFatturaBtn.Location = new System.Drawing.Point(390, 411);
            this.submitFatturaBtn.Name = "submitFatturaBtn";
            this.submitFatturaBtn.Size = new System.Drawing.Size(46, 45);
            this.submitFatturaBtn.TabIndex = 6;
            this.toolTip1.SetToolTip(this.submitFatturaBtn, "Invia");
            this.submitFatturaBtn.UseVisualStyleBackColor = false;
            this.submitFatturaBtn.Click += new System.EventHandler(this.submitFatturaBtn_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(223, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Fornitore";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DataSource = this.fornitoreBindingSource;
            this.comboBox1.DisplayMember = "Ragione_Sociale";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(395, 233);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "Partita_IVA";
            // 
            // fornitoreBindingSource
            // 
            this.fornitoreBindingSource.DataMember = "Fornitore";
            this.fornitoreBindingSource.DataSource = this.progettoDB16DataSet;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Importo complessivo";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Data";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Numero";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox7.Location = new System.Drawing.Point(395, 186);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(192, 20);
            this.textBox7.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.Location = new System.Drawing.Point(395, 72);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(192, 20);
            this.textBox5.TabIndex = 1;
            // 
            // addModalitaPagPanel
            // 
            this.addModalitaPagPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addModalitaPagPanel.Controls.Add(this.groupBox20);
            this.addModalitaPagPanel.Controls.Add(this.groupBox19);
            this.addModalitaPagPanel.Controls.Add(this.submitModalitaPagBtn);
            this.addModalitaPagPanel.Controls.Add(this.fornAddModPagComboBox);
            this.addModalitaPagPanel.Controls.Add(this.fornAddModPagLabel);
            this.addModalitaPagPanel.Location = new System.Drawing.Point(2, -2);
            this.addModalitaPagPanel.Name = "addModalitaPagPanel";
            this.addModalitaPagPanel.Size = new System.Drawing.Size(836, 471);
            this.addModalitaPagPanel.TabIndex = 2;
            this.addModalitaPagPanel.VisibleChanged += new System.EventHandler(this.addModalitaPagPanel_VisibleChanged);
            // 
            // groupBox20
            // 
            this.groupBox20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox20.Controls.Add(this.label11);
            this.groupBox20.Controls.Add(this.label9);
            this.groupBox20.Controls.Add(this.label12);
            this.groupBox20.Controls.Add(this.textBox10);
            this.groupBox20.Controls.Add(this.textBox11);
            this.groupBox20.Controls.Add(this.textBox12);
            this.groupBox20.Location = new System.Drawing.Point(231, 188);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(374, 124);
            this.groupBox20.TabIndex = 4;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Caratteristiche";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Numero rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tasso dilazione";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Periodicità rate";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(185, 23);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(183, 20);
            this.textBox10.TabIndex = 4;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(185, 58);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(183, 20);
            this.textBox11.TabIndex = 5;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(185, 94);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(183, 20);
            this.textBox12.TabIndex = 6;
            // 
            // groupBox19
            // 
            this.groupBox19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox19.Controls.Add(this.textBox9);
            this.groupBox19.Controls.Add(this.label8);
            this.groupBox19.Controls.Add(this.label10);
            this.groupBox19.Controls.Add(this.textBox8);
            this.groupBox19.Location = new System.Drawing.Point(232, 89);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(374, 82);
            this.groupBox19.TabIndex = 2;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Range importi";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(185, 54);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(183, 20);
            this.textBox9.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Da";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "A";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(185, 22);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(183, 20);
            this.textBox8.TabIndex = 2;
            // 
            // submitModalitaPagBtn
            // 
            this.submitModalitaPagBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitModalitaPagBtn.BackColor = System.Drawing.Color.White;
            this.submitModalitaPagBtn.Image = ((System.Drawing.Image)(resources.GetObject("submitModalitaPagBtn.Image")));
            this.submitModalitaPagBtn.Location = new System.Drawing.Point(395, 408);
            this.submitModalitaPagBtn.Name = "submitModalitaPagBtn";
            this.submitModalitaPagBtn.Size = new System.Drawing.Size(46, 45);
            this.submitModalitaPagBtn.TabIndex = 7;
            this.toolTip1.SetToolTip(this.submitModalitaPagBtn, "Invia");
            this.submitModalitaPagBtn.UseVisualStyleBackColor = false;
            this.submitModalitaPagBtn.Click += new System.EventHandler(this.submitModalitaPagBtn_Click);
            // 
            // fornAddModPagComboBox
            // 
            this.fornAddModPagComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fornAddModPagComboBox.DataSource = this.fornitoreBindingSource;
            this.fornAddModPagComboBox.DisplayMember = "Ragione_Sociale";
            this.fornAddModPagComboBox.FormattingEnabled = true;
            this.fornAddModPagComboBox.Location = new System.Drawing.Point(417, 50);
            this.fornAddModPagComboBox.Name = "fornAddModPagComboBox";
            this.fornAddModPagComboBox.Size = new System.Drawing.Size(183, 21);
            this.fornAddModPagComboBox.TabIndex = 1;
            this.fornAddModPagComboBox.ValueMember = "Partita_IVA";
            // 
            // fornAddModPagLabel
            // 
            this.fornAddModPagLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fornAddModPagLabel.AutoSize = true;
            this.fornAddModPagLabel.Location = new System.Drawing.Point(238, 53);
            this.fornAddModPagLabel.Name = "fornAddModPagLabel";
            this.fornAddModPagLabel.Size = new System.Drawing.Size(48, 13);
            this.fornAddModPagLabel.TabIndex = 10;
            this.fornAddModPagLabel.Text = "Fornitore";
            // 
            // submitTrasportoBtn
            // 
            this.submitTrasportoBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitTrasportoBtn.BackColor = System.Drawing.Color.White;
            this.submitTrasportoBtn.Image = ((System.Drawing.Image)(resources.GetObject("submitTrasportoBtn.Image")));
            this.submitTrasportoBtn.Location = new System.Drawing.Point(387, 420);
            this.submitTrasportoBtn.Name = "submitTrasportoBtn";
            this.submitTrasportoBtn.Size = new System.Drawing.Size(46, 45);
            this.submitTrasportoBtn.TabIndex = 10;
            this.toolTip1.SetToolTip(this.submitTrasportoBtn, "Invia");
            this.submitTrasportoBtn.UseVisualStyleBackColor = false;
            this.submitTrasportoBtn.Click += new System.EventHandler(this.submitTrasportoBtn_Click);
            // 
            // submitRevisioneBtn
            // 
            this.submitRevisioneBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitRevisioneBtn.BackColor = System.Drawing.Color.White;
            this.submitRevisioneBtn.Image = ((System.Drawing.Image)(resources.GetObject("submitRevisioneBtn.Image")));
            this.submitRevisioneBtn.Location = new System.Drawing.Point(389, 416);
            this.submitRevisioneBtn.Name = "submitRevisioneBtn";
            this.submitRevisioneBtn.Size = new System.Drawing.Size(46, 45);
            this.submitRevisioneBtn.TabIndex = 4;
            this.toolTip1.SetToolTip(this.submitRevisioneBtn, "Invia");
            this.submitRevisioneBtn.UseVisualStyleBackColor = false;
            this.submitRevisioneBtn.Click += new System.EventHandler(this.submitRevisioneBtn_Click);
            // 
            // submitOptionalBtn
            // 
            this.submitOptionalBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitOptionalBtn.BackColor = System.Drawing.Color.White;
            this.submitOptionalBtn.Image = ((System.Drawing.Image)(resources.GetObject("submitOptionalBtn.Image")));
            this.submitOptionalBtn.Location = new System.Drawing.Point(384, 408);
            this.submitOptionalBtn.Name = "submitOptionalBtn";
            this.submitOptionalBtn.Size = new System.Drawing.Size(46, 45);
            this.submitOptionalBtn.TabIndex = 5;
            this.toolTip1.SetToolTip(this.submitOptionalBtn, "Invia");
            this.submitOptionalBtn.UseVisualStyleBackColor = false;
            this.submitOptionalBtn.Click += new System.EventHandler(this.submitOptionalBtn_Click);
            // 
            // submitRicambioBtn
            // 
            this.submitRicambioBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitRicambioBtn.BackColor = System.Drawing.Color.White;
            this.submitRicambioBtn.Image = ((System.Drawing.Image)(resources.GetObject("submitRicambioBtn.Image")));
            this.submitRicambioBtn.Location = new System.Drawing.Point(396, 410);
            this.submitRicambioBtn.Name = "submitRicambioBtn";
            this.submitRicambioBtn.Size = new System.Drawing.Size(46, 45);
            this.submitRicambioBtn.TabIndex = 7;
            this.toolTip1.SetToolTip(this.submitRicambioBtn, "Invia");
            this.submitRicambioBtn.UseVisualStyleBackColor = false;
            this.submitRicambioBtn.Click += new System.EventHandler(this.submitRicambioBtn_Click);
            // 
            // submitDettaglioBtn
            // 
            this.submitDettaglioBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitDettaglioBtn.BackColor = System.Drawing.Color.White;
            this.submitDettaglioBtn.Image = ((System.Drawing.Image)(resources.GetObject("submitDettaglioBtn.Image")));
            this.submitDettaglioBtn.Location = new System.Drawing.Point(388, 408);
            this.submitDettaglioBtn.Name = "submitDettaglioBtn";
            this.submitDettaglioBtn.Size = new System.Drawing.Size(46, 45);
            this.submitDettaglioBtn.TabIndex = 5;
            this.toolTip1.SetToolTip(this.submitDettaglioBtn, "Invia");
            this.submitDettaglioBtn.UseVisualStyleBackColor = false;
            this.submitDettaglioBtn.Click += new System.EventHandler(this.submitDettaglioBtn_Click);
            // 
            // submitOptToVeicBtn
            // 
            this.submitOptToVeicBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitOptToVeicBtn.BackColor = System.Drawing.Color.White;
            this.submitOptToVeicBtn.Image = ((System.Drawing.Image)(resources.GetObject("submitOptToVeicBtn.Image")));
            this.submitOptToVeicBtn.Location = new System.Drawing.Point(399, 408);
            this.submitOptToVeicBtn.Name = "submitOptToVeicBtn";
            this.submitOptToVeicBtn.Size = new System.Drawing.Size(46, 45);
            this.submitOptToVeicBtn.TabIndex = 3;
            this.toolTip1.SetToolTip(this.submitOptToVeicBtn, "Invia");
            this.submitOptToVeicBtn.UseVisualStyleBackColor = false;
            this.submitOptToVeicBtn.Click += new System.EventHandler(this.submitOptToVeicBtn_Click);
            // 
            // submitVenditaBtn
            // 
            this.submitVenditaBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitVenditaBtn.BackColor = System.Drawing.Color.White;
            this.submitVenditaBtn.Image = ((System.Drawing.Image)(resources.GetObject("submitVenditaBtn.Image")));
            this.submitVenditaBtn.Location = new System.Drawing.Point(398, 413);
            this.submitVenditaBtn.Name = "submitVenditaBtn";
            this.submitVenditaBtn.Size = new System.Drawing.Size(46, 45);
            this.submitVenditaBtn.TabIndex = 5;
            this.toolTip1.SetToolTip(this.submitVenditaBtn, "Invia");
            this.submitVenditaBtn.UseVisualStyleBackColor = false;
            this.submitVenditaBtn.Click += new System.EventHandler(this.submitVenditaBtn_Click);
            // 
            // submitModelloBtn
            // 
            this.submitModelloBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitModelloBtn.BackColor = System.Drawing.Color.White;
            this.submitModelloBtn.Image = ((System.Drawing.Image)(resources.GetObject("submitModelloBtn.Image")));
            this.submitModelloBtn.Location = new System.Drawing.Point(387, 409);
            this.submitModelloBtn.Name = "submitModelloBtn";
            this.submitModelloBtn.Size = new System.Drawing.Size(46, 45);
            this.submitModelloBtn.TabIndex = 4;
            this.toolTip1.SetToolTip(this.submitModelloBtn, "Invia");
            this.submitModelloBtn.UseVisualStyleBackColor = false;
            this.submitModelloBtn.Click += new System.EventHandler(this.submitModelloBtn_Click);
            // 
            // submitRiparazione
            // 
            this.submitRiparazione.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitRiparazione.BackColor = System.Drawing.Color.White;
            this.submitRiparazione.Image = ((System.Drawing.Image)(resources.GetObject("submitRiparazione.Image")));
            this.submitRiparazione.Location = new System.Drawing.Point(389, 397);
            this.submitRiparazione.Name = "submitRiparazione";
            this.submitRiparazione.Size = new System.Drawing.Size(46, 45);
            this.submitRiparazione.TabIndex = 5;
            this.toolTip1.SetToolTip(this.submitRiparazione, "Invia");
            this.submitRiparazione.UseVisualStyleBackColor = false;
            this.submitRiparazione.Click += new System.EventHandler(this.submitRiparazione_Click);
            // 
            // submitVeicoloBtn
            // 
            this.submitVeicoloBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitVeicoloBtn.BackColor = System.Drawing.Color.White;
            this.submitVeicoloBtn.Image = ((System.Drawing.Image)(resources.GetObject("submitVeicoloBtn.Image")));
            this.submitVeicoloBtn.Location = new System.Drawing.Point(382, 409);
            this.submitVeicoloBtn.Name = "submitVeicoloBtn";
            this.submitVeicoloBtn.Size = new System.Drawing.Size(46, 45);
            this.submitVeicoloBtn.TabIndex = 17;
            this.toolTip1.SetToolTip(this.submitVeicoloBtn, "Invia");
            this.submitVeicoloBtn.UseVisualStyleBackColor = false;
            this.submitVeicoloBtn.Click += new System.EventHandler(this.submitVeicoloBtn_Click);
            // 
            // submitContrattoBtn
            // 
            this.submitContrattoBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitContrattoBtn.BackColor = System.Drawing.Color.White;
            this.submitContrattoBtn.Image = ((System.Drawing.Image)(resources.GetObject("submitContrattoBtn.Image")));
            this.submitContrattoBtn.Location = new System.Drawing.Point(395, 416);
            this.submitContrattoBtn.Name = "submitContrattoBtn";
            this.submitContrattoBtn.Size = new System.Drawing.Size(46, 45);
            this.submitContrattoBtn.TabIndex = 6;
            this.toolTip1.SetToolTip(this.submitContrattoBtn, "Invia");
            this.submitContrattoBtn.UseVisualStyleBackColor = false;
            this.submitContrattoBtn.Click += new System.EventHandler(this.submitContrattoBtn_Click);
            // 
            // submitPerfTraspBtn
            // 
            this.submitPerfTraspBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitPerfTraspBtn.BackColor = System.Drawing.Color.White;
            this.submitPerfTraspBtn.Image = ((System.Drawing.Image)(resources.GetObject("submitPerfTraspBtn.Image")));
            this.submitPerfTraspBtn.Location = new System.Drawing.Point(387, 417);
            this.submitPerfTraspBtn.Name = "submitPerfTraspBtn";
            this.submitPerfTraspBtn.Size = new System.Drawing.Size(46, 45);
            this.submitPerfTraspBtn.TabIndex = 3;
            this.toolTip1.SetToolTip(this.submitPerfTraspBtn, "Invia");
            this.submitPerfTraspBtn.UseVisualStyleBackColor = false;
            this.submitPerfTraspBtn.Click += new System.EventHandler(this.submitPerfTraspBtn_Click);
            // 
            // submitClienteABtn
            // 
            this.submitClienteABtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitClienteABtn.BackColor = System.Drawing.Color.White;
            this.submitClienteABtn.Image = ((System.Drawing.Image)(resources.GetObject("submitClienteABtn.Image")));
            this.submitClienteABtn.Location = new System.Drawing.Point(387, 390);
            this.submitClienteABtn.Name = "submitClienteABtn";
            this.submitClienteABtn.Size = new System.Drawing.Size(46, 45);
            this.submitClienteABtn.TabIndex = 12;
            this.toolTip1.SetToolTip(this.submitClienteABtn, "Invia");
            this.submitClienteABtn.UseVisualStyleBackColor = false;
            this.submitClienteABtn.Click += new System.EventHandler(this.submitClienteABtn_Click);
            // 
            // submitGiacenzaBtn
            // 
            this.submitGiacenzaBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitGiacenzaBtn.BackColor = System.Drawing.Color.White;
            this.submitGiacenzaBtn.Image = ((System.Drawing.Image)(resources.GetObject("submitGiacenzaBtn.Image")));
            this.submitGiacenzaBtn.Location = new System.Drawing.Point(405, 419);
            this.submitGiacenzaBtn.Name = "submitGiacenzaBtn";
            this.submitGiacenzaBtn.Size = new System.Drawing.Size(46, 45);
            this.submitGiacenzaBtn.TabIndex = 5;
            this.toolTip1.SetToolTip(this.submitGiacenzaBtn, "Invia");
            this.submitGiacenzaBtn.UseVisualStyleBackColor = false;
            this.submitGiacenzaBtn.Click += new System.EventHandler(this.submitGiacenzaBtn_Click);
            // 
            // submitPagamentoBtn
            // 
            this.submitPagamentoBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitPagamentoBtn.BackColor = System.Drawing.Color.White;
            this.submitPagamentoBtn.Image = ((System.Drawing.Image)(resources.GetObject("submitPagamentoBtn.Image")));
            this.submitPagamentoBtn.Location = new System.Drawing.Point(398, 417);
            this.submitPagamentoBtn.Name = "submitPagamentoBtn";
            this.submitPagamentoBtn.Size = new System.Drawing.Size(46, 45);
            this.submitPagamentoBtn.TabIndex = 4;
            this.toolTip1.SetToolTip(this.submitPagamentoBtn, "Invia");
            this.submitPagamentoBtn.UseVisualStyleBackColor = false;
            this.submitPagamentoBtn.Click += new System.EventHandler(this.submitPagamentoBtn_Click);
            // 
            // submitClientePBtn
            // 
            this.submitClientePBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitClientePBtn.BackColor = System.Drawing.Color.White;
            this.submitClientePBtn.Image = ((System.Drawing.Image)(resources.GetObject("submitClientePBtn.Image")));
            this.submitClientePBtn.Location = new System.Drawing.Point(387, 368);
            this.submitClientePBtn.Name = "submitClientePBtn";
            this.submitClientePBtn.Size = new System.Drawing.Size(46, 45);
            this.submitClientePBtn.TabIndex = 16;
            this.toolTip1.SetToolTip(this.submitClientePBtn, "Invia");
            this.submitClientePBtn.UseVisualStyleBackColor = false;
            this.submitClientePBtn.Click += new System.EventHandler(this.submitClientePBtn_Click);
            // 
            // submitAddOrdineBtn
            // 
            this.submitAddOrdineBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitAddOrdineBtn.BackColor = System.Drawing.Color.White;
            this.submitAddOrdineBtn.Image = ((System.Drawing.Image)(resources.GetObject("submitAddOrdineBtn.Image")));
            this.submitAddOrdineBtn.Location = new System.Drawing.Point(389, 420);
            this.submitAddOrdineBtn.Name = "submitAddOrdineBtn";
            this.submitAddOrdineBtn.Size = new System.Drawing.Size(46, 45);
            this.submitAddOrdineBtn.TabIndex = 14;
            this.toolTip1.SetToolTip(this.submitAddOrdineBtn, "Invia");
            this.submitAddOrdineBtn.UseVisualStyleBackColor = false;
            this.submitAddOrdineBtn.Click += new System.EventHandler(this.submitAddOrdineBtn_Click);
            // 
            // submitAddVeicRicToOrderBtn
            // 
            this.submitAddVeicRicToOrderBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitAddVeicRicToOrderBtn.BackColor = System.Drawing.Color.White;
            this.submitAddVeicRicToOrderBtn.Image = ((System.Drawing.Image)(resources.GetObject("submitAddVeicRicToOrderBtn.Image")));
            this.submitAddVeicRicToOrderBtn.Location = new System.Drawing.Point(399, 409);
            this.submitAddVeicRicToOrderBtn.Name = "submitAddVeicRicToOrderBtn";
            this.submitAddVeicRicToOrderBtn.Size = new System.Drawing.Size(46, 45);
            this.submitAddVeicRicToOrderBtn.TabIndex = 14;
            this.toolTip1.SetToolTip(this.submitAddVeicRicToOrderBtn, "Invia");
            this.submitAddVeicRicToOrderBtn.UseVisualStyleBackColor = false;
            this.submitAddVeicRicToOrderBtn.Click += new System.EventHandler(this.submitAddVeicRicToOrderBtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(387, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 45);
            this.button1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button1, "Invia");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addClientePanel
            // 
            this.addClientePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addClientePanel.Controls.Add(this.tabControl1);
            this.addClientePanel.Location = new System.Drawing.Point(1, -1);
            this.addClientePanel.Name = "addClientePanel";
            this.addClientePanel.Size = new System.Drawing.Size(836, 471);
            this.addClientePanel.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(827, 475);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox16);
            this.tabPage2.Controls.Add(this.groupBox12);
            this.tabPage2.Controls.Add(this.groupBox15);
            this.tabPage2.Controls.Add(this.groupBox17);
            this.tabPage2.Controls.Add(this.submitClientePBtn);
            this.tabPage2.Controls.Add(this.textBox77);
            this.tabPage2.Controls.Add(this.label105);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(819, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Privato";
            // 
            // groupBox16
            // 
            this.groupBox16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox16.Controls.Add(this.textBox75);
            this.groupBox16.Controls.Add(this.label103);
            this.groupBox16.Controls.Add(this.textBox76);
            this.groupBox16.Controls.Add(this.label104);
            this.groupBox16.Controls.Add(this.textBox78);
            this.groupBox16.Controls.Add(this.label110);
            this.groupBox16.Location = new System.Drawing.Point(429, 54);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(360, 96);
            this.groupBox16.TabIndex = 9;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Recapiti";
            // 
            // textBox75
            // 
            this.textBox75.Location = new System.Drawing.Point(176, 65);
            this.textBox75.Name = "textBox75";
            this.textBox75.Size = new System.Drawing.Size(181, 20);
            this.textBox75.TabIndex = 11;
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(23, 68);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(46, 13);
            this.label103.TabIndex = 21;
            this.label103.Text = "Ulteriore";
            // 
            // textBox76
            // 
            this.textBox76.Location = new System.Drawing.Point(176, 40);
            this.textBox76.Name = "textBox76";
            this.textBox76.Size = new System.Drawing.Size(181, 20);
            this.textBox76.TabIndex = 10;
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(23, 19);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(53, 13);
            this.label104.TabIndex = 19;
            this.label104.Text = "Principale";
            // 
            // textBox78
            // 
            this.textBox78.Location = new System.Drawing.Point(176, 14);
            this.textBox78.Name = "textBox78";
            this.textBox78.Size = new System.Drawing.Size(181, 20);
            this.textBox78.TabIndex = 9;
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(23, 43);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(61, 13);
            this.label110.TabIndex = 18;
            this.label110.Text = "Secondario";
            // 
            // groupBox12
            // 
            this.groupBox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox12.Controls.Add(this.dateTimePicker10);
            this.groupBox12.Controls.Add(this.textBox23);
            this.groupBox12.Controls.Add(this.label99);
            this.groupBox12.Controls.Add(this.textBox73);
            this.groupBox12.Controls.Add(this.label101);
            this.groupBox12.Controls.Add(this.label102);
            this.groupBox12.Location = new System.Drawing.Point(46, 199);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(360, 96);
            this.groupBox12.TabIndex = 5;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Nascita";
            // 
            // dateTimePicker10
            // 
            this.dateTimePicker10.Location = new System.Drawing.Point(173, 14);
            this.dateTimePicker10.Name = "dateTimePicker10";
            this.dateTimePicker10.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker10.TabIndex = 6;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(176, 65);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(181, 20);
            this.textBox23.TabIndex = 8;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(23, 68);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(51, 13);
            this.label99.TabIndex = 21;
            this.label99.Text = "Provincia";
            // 
            // textBox73
            // 
            this.textBox73.Location = new System.Drawing.Point(176, 40);
            this.textBox73.Name = "textBox73";
            this.textBox73.Size = new System.Drawing.Size(181, 20);
            this.textBox73.TabIndex = 7;
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(23, 19);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(30, 13);
            this.label101.TabIndex = 19;
            this.label101.Text = "Data";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(23, 43);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(28, 13);
            this.label102.TabIndex = 18;
            this.label102.Text = "Città";
            // 
            // groupBox15
            // 
            this.groupBox15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox15.Controls.Add(this.textBox2);
            this.groupBox15.Controls.Add(this.label20);
            this.groupBox15.Controls.Add(this.textBox14);
            this.groupBox15.Controls.Add(this.label23);
            this.groupBox15.Controls.Add(this.textBox18);
            this.groupBox15.Controls.Add(this.label24);
            this.groupBox15.Location = new System.Drawing.Point(46, 54);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(360, 96);
            this.groupBox15.TabIndex = 1;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Nominativi";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(176, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(23, 68);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "Cognome";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(176, 40);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(181, 20);
            this.textBox14.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(23, 19);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 13);
            this.label23.TabIndex = 19;
            this.label23.Text = "Codice fiscale";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(176, 14);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(181, 20);
            this.textBox18.TabIndex = 2;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(23, 43);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 13);
            this.label24.TabIndex = 18;
            this.label24.Text = "Nome";
            // 
            // groupBox17
            // 
            this.groupBox17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox17.Controls.Add(this.textBox85);
            this.groupBox17.Controls.Add(this.label112);
            this.groupBox17.Controls.Add(this.textBox86);
            this.groupBox17.Controls.Add(this.textBox87);
            this.groupBox17.Controls.Add(this.textBox88);
            this.groupBox17.Controls.Add(this.label113);
            this.groupBox17.Controls.Add(this.label114);
            this.groupBox17.Controls.Add(this.label115);
            this.groupBox17.Location = new System.Drawing.Point(430, 199);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(360, 127);
            this.groupBox17.TabIndex = 12;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Residenza";
            // 
            // textBox85
            // 
            this.textBox85.Location = new System.Drawing.Point(176, 40);
            this.textBox85.Name = "textBox85";
            this.textBox85.Size = new System.Drawing.Size(181, 20);
            this.textBox85.TabIndex = 13;
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(23, 19);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(45, 13);
            this.label112.TabIndex = 19;
            this.label112.Text = "Indirizzo";
            // 
            // textBox86
            // 
            this.textBox86.Location = new System.Drawing.Point(176, 67);
            this.textBox86.Name = "textBox86";
            this.textBox86.Size = new System.Drawing.Size(181, 20);
            this.textBox86.TabIndex = 14;
            // 
            // textBox87
            // 
            this.textBox87.Location = new System.Drawing.Point(176, 14);
            this.textBox87.Name = "textBox87";
            this.textBox87.Size = new System.Drawing.Size(181, 20);
            this.textBox87.TabIndex = 12;
            // 
            // textBox88
            // 
            this.textBox88.Location = new System.Drawing.Point(175, 92);
            this.textBox88.Name = "textBox88";
            this.textBox88.Size = new System.Drawing.Size(78, 20);
            this.textBox88.TabIndex = 15;
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(23, 43);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(28, 13);
            this.label113.TabIndex = 18;
            this.label113.Text = "Città";
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(23, 95);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(28, 13);
            this.label114.TabIndex = 16;
            this.label114.Text = "CAP";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(23, 70);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(51, 13);
            this.label115.TabIndex = 17;
            this.label115.Text = "Provincia";
            // 
            // textBox77
            // 
            this.textBox77.Location = new System.Drawing.Point(95, -81);
            this.textBox77.Name = "textBox77";
            this.textBox77.Size = new System.Drawing.Size(183, 20);
            this.textBox77.TabIndex = 19;
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(-85, -77);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(121, 13);
            this.label105.TabIndex = 24;
            this.label105.Text = "Partita IVA - Cod. fiscale";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox18);
            this.tabPage1.Controls.Add(this.groupBox14);
            this.tabPage1.Controls.Add(this.submitClienteABtn);
            this.tabPage1.Controls.Add(this.groupBox13);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(819, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Azienda";
            // 
            // groupBox18
            // 
            this.groupBox18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox18.Controls.Add(this.textBox1);
            this.groupBox18.Controls.Add(this.label22);
            this.groupBox18.Controls.Add(this.textBox17);
            this.groupBox18.Controls.Add(this.label111);
            this.groupBox18.Controls.Add(this.textBox79);
            this.groupBox18.Controls.Add(this.label116);
            this.groupBox18.Location = new System.Drawing.Point(429, 67);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(360, 96);
            this.groupBox18.TabIndex = 5;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Recapiti";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(23, 68);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "Ulteriore";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(176, 40);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(181, 20);
            this.textBox17.TabIndex = 6;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(23, 19);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(53, 13);
            this.label111.TabIndex = 19;
            this.label111.Text = "Principale";
            // 
            // textBox79
            // 
            this.textBox79.Location = new System.Drawing.Point(176, 14);
            this.textBox79.Name = "textBox79";
            this.textBox79.Size = new System.Drawing.Size(181, 20);
            this.textBox79.TabIndex = 5;
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(23, 43);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(61, 13);
            this.label116.TabIndex = 18;
            this.label116.Text = "Secondario";
            // 
            // groupBox14
            // 
            this.groupBox14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox14.Controls.Add(this.textBox80);
            this.groupBox14.Controls.Add(this.label108);
            this.groupBox14.Controls.Add(this.textBox82);
            this.groupBox14.Controls.Add(this.label109);
            this.groupBox14.Location = new System.Drawing.Point(46, 67);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(360, 67);
            this.groupBox14.TabIndex = 1;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Nominativi";
            // 
            // textBox80
            // 
            this.textBox80.Location = new System.Drawing.Point(176, 40);
            this.textBox80.Name = "textBox80";
            this.textBox80.Size = new System.Drawing.Size(181, 20);
            this.textBox80.TabIndex = 2;
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(23, 19);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(57, 13);
            this.label108.TabIndex = 19;
            this.label108.Text = "Partita IVA";
            // 
            // textBox82
            // 
            this.textBox82.Location = new System.Drawing.Point(176, 14);
            this.textBox82.Name = "textBox82";
            this.textBox82.Size = new System.Drawing.Size(181, 20);
            this.textBox82.TabIndex = 1;
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(23, 43);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(83, 13);
            this.label109.TabIndex = 18;
            this.label109.Text = "Ragione sociale";
            // 
            // groupBox13
            // 
            this.groupBox13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox13.Controls.Add(this.textBox15);
            this.groupBox13.Controls.Add(this.label106);
            this.groupBox13.Controls.Add(this.textBox81);
            this.groupBox13.Controls.Add(this.label107);
            this.groupBox13.Location = new System.Drawing.Point(46, 212);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(360, 67);
            this.groupBox13.TabIndex = 3;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Indirizzi email";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(176, 40);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(181, 20);
            this.textBox15.TabIndex = 4;
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(23, 19);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(53, 13);
            this.label106.TabIndex = 19;
            this.label106.Text = "Principale";
            // 
            // textBox81
            // 
            this.textBox81.Location = new System.Drawing.Point(176, 14);
            this.textBox81.Name = "textBox81";
            this.textBox81.Size = new System.Drawing.Size(181, 20);
            this.textBox81.TabIndex = 3;
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(23, 43);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(61, 13);
            this.label107.TabIndex = 18;
            this.label107.Text = "Secondario";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.textBox28);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBox30);
            this.groupBox3.Controls.Add(this.textBox31);
            this.groupBox3.Controls.Add(this.textBox32);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Location = new System.Drawing.Point(430, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 127);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sede";
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(176, 40);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(181, 20);
            this.textBox28.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Indirizzo";
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(176, 67);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(181, 20);
            this.textBox30.TabIndex = 10;
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(176, 14);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(181, 20);
            this.textBox31.TabIndex = 8;
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(175, 92);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(78, 20);
            this.textBox32.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Città";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "CAP";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(23, 70);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(51, 13);
            this.label30.TabIndex = 17;
            this.label30.Text = "Provincia";
            // 
            // addContrattoPanel
            // 
            this.addContrattoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addContrattoPanel.Controls.Add(this.textBox3);
            this.addContrattoPanel.Controls.Add(this.dateTimePicker9);
            this.addContrattoPanel.Controls.Add(this.comboBox6);
            this.addContrattoPanel.Controls.Add(this.comboBox5);
            this.addContrattoPanel.Controls.Add(this.textBox21);
            this.addContrattoPanel.Controls.Add(this.label19);
            this.addContrattoPanel.Controls.Add(this.submitContrattoBtn);
            this.addContrattoPanel.Controls.Add(this.label25);
            this.addContrattoPanel.Controls.Add(this.label26);
            this.addContrattoPanel.Controls.Add(this.label27);
            this.addContrattoPanel.Controls.Add(this.label28);
            this.addContrattoPanel.Location = new System.Drawing.Point(2, 0);
            this.addContrattoPanel.Name = "addContrattoPanel";
            this.addContrattoPanel.Size = new System.Drawing.Size(836, 471);
            this.addContrattoPanel.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(415, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 20);
            this.textBox3.TabIndex = 7;
            // 
            // dateTimePicker9
            // 
            this.dateTimePicker9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker9.Location = new System.Drawing.Point(416, 126);
            this.dateTimePicker9.Name = "dateTimePicker9";
            this.dateTimePicker9.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker9.TabIndex = 2;
            // 
            // comboBox6
            // 
            this.comboBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox6.DataSource = this.clienteBindingSource;
            this.comboBox6.DisplayMember = "PartitaIVA_CodiceFiscale";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(415, 244);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(183, 21);
            this.comboBox6.TabIndex = 4;
            this.comboBox6.ValueMember = "PartitaIVA_CodiceFiscale";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.progettoDB16DataSet;
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox5.DataSource = this.nostremodalitadipagamentoBindingSource;
            this.comboBox5.DisplayMember = "Da";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(416, 300);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(183, 21);
            this.comboBox5.TabIndex = 5;
            this.comboBox5.ValueMember = "Da";
            // 
            // nostremodalitadipagamentoBindingSource
            // 
            this.nostremodalitadipagamentoBindingSource.DataMember = "Nostre_modalita_di_pagamento";
            this.nostremodalitadipagamentoBindingSource.DataSource = this.progettoDB16DataSet;
            // 
            // textBox21
            // 
            this.textBox21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox21.Location = new System.Drawing.Point(416, 185);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(183, 20);
            this.textBox21.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(233, 248);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Cliente";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(233, 189);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(103, 13);
            this.label25.TabIndex = 3;
            this.label25.Text = "Importo complessivo";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(233, 131);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(30, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "Data";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(233, 304);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(103, 13);
            this.label27.TabIndex = 1;
            this.label27.Text = "Modalità pagamento";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(234, 76);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 13);
            this.label28.TabIndex = 0;
            this.label28.Text = "Numero";
            // 
            // addTrasportoPanel
            // 
            this.addTrasportoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addTrasportoPanel.Controls.Add(this.submitTrasportoBtn);
            this.addTrasportoPanel.Controls.Add(this.groupBox1);
            this.addTrasportoPanel.Controls.Add(this.comboBox8);
            this.addTrasportoPanel.Controls.Add(this.label31);
            this.addTrasportoPanel.Controls.Add(this.dateTimePicker2);
            this.addTrasportoPanel.Controls.Add(this.comboBox7);
            this.addTrasportoPanel.Controls.Add(this.label29);
            this.addTrasportoPanel.Controls.Add(this.textBox25);
            this.addTrasportoPanel.Controls.Add(this.textBox26);
            this.addTrasportoPanel.Controls.Add(this.label32);
            this.addTrasportoPanel.Controls.Add(this.label33);
            this.addTrasportoPanel.Controls.Add(this.label34);
            this.addTrasportoPanel.Location = new System.Drawing.Point(2, -1);
            this.addTrasportoPanel.Name = "addTrasportoPanel";
            this.addTrasportoPanel.Size = new System.Drawing.Size(836, 471);
            this.addTrasportoPanel.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.textBox27);
            this.groupBox1.Controls.Add(this.label38);
            this.groupBox1.Controls.Add(this.textBox24);
            this.groupBox1.Controls.Add(this.textBox19);
            this.groupBox1.Controls.Add(this.textBox20);
            this.groupBox1.Controls.Add(this.label37);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Location = new System.Drawing.Point(424, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 142);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Luogo consegna:";
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(183, 50);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(181, 20);
            this.textBox27.TabIndex = 7;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(23, 29);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(45, 13);
            this.label38.TabIndex = 19;
            this.label38.Text = "Indirizzo";
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(183, 77);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(181, 20);
            this.textBox24.TabIndex = 8;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(183, 24);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(181, 20);
            this.textBox19.TabIndex = 6;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(183, 102);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(78, 20);
            this.textBox20.TabIndex = 9;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(23, 53);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(28, 13);
            this.label37.TabIndex = 18;
            this.label37.Text = "Città";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(23, 105);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(28, 13);
            this.label35.TabIndex = 16;
            this.label35.Text = "CAP";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(23, 80);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(51, 13);
            this.label36.TabIndex = 17;
            this.label36.Text = "Provincia";
            // 
            // comboBox8
            // 
            this.comboBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox8.DataSource = this.contrattodivenditaBindingSource1;
            this.comboBox8.DisplayMember = "Numero";
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.ItemHeight = 13;
            this.comboBox8.Location = new System.Drawing.Point(199, 176);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(183, 21);
            this.comboBox8.TabIndex = 2;
            this.comboBox8.ValueMember = "Numero";
            // 
            // contrattodivenditaBindingSource1
            // 
            this.contrattodivenditaBindingSource1.DataMember = "Contratto_di_vendita";
            this.contrattodivenditaBindingSource1.DataSource = this.progettoDB16DataSet;
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(61, 179);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(50, 13);
            this.label31.TabIndex = 13;
            this.label31.Text = "Contratto";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.Location = new System.Drawing.Point(606, 124);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // comboBox7
            // 
            this.comboBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox7.DataSource = this.corriereBindingSource;
            this.comboBox7.DisplayMember = "Ragione_sociale";
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.ItemHeight = 13;
            this.comboBox7.Location = new System.Drawing.Point(198, 231);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(183, 21);
            this.comboBox7.TabIndex = 3;
            this.comboBox7.ValueMember = "Partita_IVA";
            // 
            // corriereBindingSource
            // 
            this.corriereBindingSource.DataMember = "Corriere";
            this.corriereBindingSource.DataSource = this.progettoDB16DataSet;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(60, 236);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(43, 13);
            this.label29.TabIndex = 10;
            this.label29.Text = "Corriere";
            // 
            // textBox25
            // 
            this.textBox25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox25.Location = new System.Drawing.Point(199, 279);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(183, 20);
            this.textBox25.TabIndex = 4;
            // 
            // textBox26
            // 
            this.textBox26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox26.Location = new System.Drawing.Point(199, 124);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(183, 20);
            this.textBox26.TabIndex = 1;
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(61, 283);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(34, 13);
            this.label32.TabIndex = 2;
            this.label32.Text = "Costo";
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(423, 127);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(126, 13);
            this.label33.TabIndex = 1;
            this.label33.Text = "Data consegna (prevista)";
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(61, 128);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(40, 13);
            this.label34.TabIndex = 0;
            this.label34.Text = "Codice";
            // 
            // addPerfPanel
            // 
            this.addPerfPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPerfPanel.Controls.Add(this.comboOrdine);
            this.addPerfPanel.Controls.Add(this.comboTrasporto);
            this.addPerfPanel.Controls.Add(this.dateTimePicker3);
            this.addPerfPanel.Controls.Add(this.submitPerfTraspBtn);
            this.addPerfPanel.Controls.Add(this.label47);
            this.addPerfPanel.Controls.Add(this.label48);
            this.addPerfPanel.Location = new System.Drawing.Point(1, -1);
            this.addPerfPanel.Name = "addPerfPanel";
            this.addPerfPanel.Size = new System.Drawing.Size(836, 471);
            this.addPerfPanel.TabIndex = 22;
            this.addPerfPanel.VisibleChanged += new System.EventHandler(this.addPerfPanel_VisibleChanged);
            // 
            // comboOrdine
            // 
            this.comboOrdine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboOrdine.DataSource = this.ordineBindingSource;
            this.comboOrdine.DisplayMember = "ID_ordine";
            this.comboOrdine.FormattingEnabled = true;
            this.comboOrdine.Location = new System.Drawing.Point(426, 111);
            this.comboOrdine.Name = "comboOrdine";
            this.comboOrdine.Size = new System.Drawing.Size(121, 21);
            this.comboOrdine.TabIndex = 5;
            this.comboOrdine.ValueMember = "ID_ordine";
            // 
            // ordineBindingSource
            // 
            this.ordineBindingSource.DataMember = "Ordine";
            this.ordineBindingSource.DataSource = this.progettoDB16DataSet;
            // 
            // comboTrasporto
            // 
            this.comboTrasporto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTrasporto.DataSource = this.trasportoBindingSource;
            this.comboTrasporto.DisplayMember = "Codice";
            this.comboTrasporto.FormattingEnabled = true;
            this.comboTrasporto.Location = new System.Drawing.Point(426, 111);
            this.comboTrasporto.Name = "comboTrasporto";
            this.comboTrasporto.Size = new System.Drawing.Size(121, 21);
            this.comboTrasporto.TabIndex = 4;
            this.comboTrasporto.ValueMember = "Codice";
            // 
            // trasportoBindingSource
            // 
            this.trasportoBindingSource.DataMember = "Trasporto";
            this.trasportoBindingSource.DataSource = this.progettoDB16DataSet;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker3.Location = new System.Drawing.Point(426, 176);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker3.TabIndex = 2;
            // 
            // label47
            // 
            this.label47.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(241, 178);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(127, 13);
            this.label47.TabIndex = 1;
            this.label47.Text = "Data consegna (effettiva)";
            // 
            // label48
            // 
            this.label48.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(241, 114);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(84, 13);
            this.label48.TabIndex = 0;
            this.label48.Text = "Codice trasporto";
            // 
            // addPagamentoPanel
            // 
            this.addPagamentoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPagamentoPanel.Controls.Add(this.comboFornitore);
            this.addPagamentoPanel.Controls.Add(this.label126);
            this.addPagamentoPanel.Controls.Add(this.comboFattura);
            this.addPagamentoPanel.Controls.Add(this.submitPagamentoBtn);
            this.addPagamentoPanel.Controls.Add(this.comboContratto);
            this.addPagamentoPanel.Controls.Add(this.textBox29);
            this.addPagamentoPanel.Controls.Add(this.label41);
            this.addPagamentoPanel.Controls.Add(this.dateTimePicker4);
            this.addPagamentoPanel.Controls.Add(this.label39);
            this.addPagamentoPanel.Controls.Add(this.contratto_AddPagLabel);
            this.addPagamentoPanel.Location = new System.Drawing.Point(1, -1);
            this.addPagamentoPanel.Name = "addPagamentoPanel";
            this.addPagamentoPanel.Size = new System.Drawing.Size(836, 471);
            this.addPagamentoPanel.TabIndex = 23;
            this.addPagamentoPanel.VisibleChanged += new System.EventHandler(this.addPagamentoPanel_VisibleChanged);
            // 
            // comboFornitore
            // 
            this.comboFornitore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboFornitore.DataSource = this.fornitoreBindingSource;
            this.comboFornitore.DisplayMember = "Ragione_Sociale";
            this.comboFornitore.FormattingEnabled = true;
            this.comboFornitore.Location = new System.Drawing.Point(413, 86);
            this.comboFornitore.Name = "comboFornitore";
            this.comboFornitore.Size = new System.Drawing.Size(186, 21);
            this.comboFornitore.TabIndex = 16;
            this.comboFornitore.ValueMember = "Partita_IVA";
            // 
            // label126
            // 
            this.label126.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label126.AutoSize = true;
            this.label126.Location = new System.Drawing.Point(231, 92);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(48, 13);
            this.label126.TabIndex = 15;
            this.label126.Text = "Fornitore";
            // 
            // comboFattura
            // 
            this.comboFattura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboFattura.DataSource = this.fatturadiacquistoBindingSource1;
            this.comboFattura.DisplayMember = "Numero";
            this.comboFattura.FormattingEnabled = true;
            this.comboFattura.Location = new System.Drawing.Point(414, 157);
            this.comboFattura.Name = "comboFattura";
            this.comboFattura.Size = new System.Drawing.Size(186, 21);
            this.comboFattura.TabIndex = 14;
            this.comboFattura.ValueMember = "Numero";
            // 
            // fatturadiacquistoBindingSource1
            // 
            this.fatturadiacquistoBindingSource1.DataMember = "Fattura_di_acquisto";
            this.fatturadiacquistoBindingSource1.DataSource = this.progettoDB16DataSet;
            // 
            // comboContratto
            // 
            this.comboContratto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboContratto.DataSource = this.contrattodivenditaBindingSource;
            this.comboContratto.DisplayMember = "Numero";
            this.comboContratto.FormattingEnabled = true;
            this.comboContratto.Location = new System.Drawing.Point(414, 157);
            this.comboContratto.Name = "comboContratto";
            this.comboContratto.Size = new System.Drawing.Size(186, 21);
            this.comboContratto.TabIndex = 1;
            this.comboContratto.ValueMember = "Numero";
            // 
            // contrattodivenditaBindingSource
            // 
            this.contrattodivenditaBindingSource.DataMember = "Contratto_di_vendita";
            this.contrattodivenditaBindingSource.DataSource = this.progettoDB16DataSet;
            // 
            // textBox29
            // 
            this.textBox29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox29.Location = new System.Drawing.Point(416, 306);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(183, 20);
            this.textBox29.TabIndex = 3;
            // 
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(231, 309);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(42, 13);
            this.label41.TabIndex = 13;
            this.label41.Text = "Importo";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker4.Location = new System.Drawing.Point(416, 231);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker4.TabIndex = 2;
            // 
            // label39
            // 
            this.label39.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(231, 233);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(30, 13);
            this.label39.TabIndex = 1;
            this.label39.Text = "Data";
            // 
            // contratto_AddPagLabel
            // 
            this.contratto_AddPagLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contratto_AddPagLabel.AutoSize = true;
            this.contratto_AddPagLabel.Location = new System.Drawing.Point(231, 161);
            this.contratto_AddPagLabel.Name = "contratto_AddPagLabel";
            this.contratto_AddPagLabel.Size = new System.Drawing.Size(50, 13);
            this.contratto_AddPagLabel.TabIndex = 0;
            this.contratto_AddPagLabel.Text = "Contratto";
            // 
            // addRiparazionePanel
            // 
            this.addRiparazionePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addRiparazionePanel.Controls.Add(this.submitRiparazione);
            this.addRiparazionePanel.Controls.Add(this.comboBox2);
            this.addRiparazionePanel.Controls.Add(this.dateTimePicker5);
            this.addRiparazionePanel.Controls.Add(this.label45);
            this.addRiparazionePanel.Controls.Add(this.label46);
            this.addRiparazionePanel.Controls.Add(this.label49);
            this.addRiparazionePanel.Controls.Add(this.label53);
            this.addRiparazionePanel.Controls.Add(this.textBox42);
            this.addRiparazionePanel.Controls.Add(this.textBox43);
            this.addRiparazionePanel.Location = new System.Drawing.Point(1, -2);
            this.addRiparazionePanel.Name = "addRiparazionePanel";
            this.addRiparazionePanel.Size = new System.Drawing.Size(836, 471);
            this.addRiparazionePanel.TabIndex = 32;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.DataSource = this.veicolovendutoBindingSource1;
            this.comboBox2.DisplayMember = "Numero_telaio";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(410, 82);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(188, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "Numero_telaio";
            // 
            // veicolovendutoBindingSource1
            // 
            this.veicolovendutoBindingSource1.DataMember = "Veicolo_venduto";
            this.veicolovendutoBindingSource1.DataSource = this.progettoDB16DataSet;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker5.Location = new System.Drawing.Point(411, 166);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(189, 20);
            this.dateTimePicker5.TabIndex = 3;
            // 
            // label45
            // 
            this.label45.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(230, 88);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(96, 13);
            this.label45.TabIndex = 7;
            this.label45.Text = "Veicolo interessato";
            // 
            // label46
            // 
            this.label46.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(231, 214);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(103, 13);
            this.label46.TabIndex = 6;
            this.label46.Text = "Importo complessivo";
            // 
            // label49
            // 
            this.label49.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(231, 173);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(30, 13);
            this.label49.TabIndex = 5;
            this.label49.Text = "Data";
            // 
            // label53
            // 
            this.label53.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(231, 129);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(44, 13);
            this.label53.TabIndex = 4;
            this.label53.Text = "Numero";
            // 
            // textBox42
            // 
            this.textBox42.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox42.Location = new System.Drawing.Point(411, 207);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(188, 20);
            this.textBox42.TabIndex = 4;
            // 
            // textBox43
            // 
            this.textBox43.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox43.Location = new System.Drawing.Point(411, 122);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(188, 20);
            this.textBox43.TabIndex = 2;
            // 
            // addUtilizzoRicambioRipPanel
            // 
            this.addUtilizzoRicambioRipPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addUtilizzoRicambioRipPanel.Controls.Add(this.comboBox25);
            this.addUtilizzoRicambioRipPanel.Controls.Add(this.label120);
            this.addUtilizzoRicambioRipPanel.Controls.Add(this.comboBox11);
            this.addUtilizzoRicambioRipPanel.Controls.Add(this.label54);
            this.addUtilizzoRicambioRipPanel.Controls.Add(this.comboBox10);
            this.addUtilizzoRicambioRipPanel.Controls.Add(this.submitDettaglioBtn);
            this.addUtilizzoRicambioRipPanel.Controls.Add(this.label21);
            this.addUtilizzoRicambioRipPanel.Controls.Add(this.label40);
            this.addUtilizzoRicambioRipPanel.Controls.Add(this.textBox16);
            this.addUtilizzoRicambioRipPanel.Location = new System.Drawing.Point(0, -2);
            this.addUtilizzoRicambioRipPanel.Name = "addUtilizzoRicambioRipPanel";
            this.addUtilizzoRicambioRipPanel.Size = new System.Drawing.Size(836, 471);
            this.addUtilizzoRicambioRipPanel.TabIndex = 33;
            // 
            // comboBox25
            // 
            this.comboBox25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox25.DataSource = this.riparazioneBindingSource;
            this.comboBox25.DisplayMember = "Veicolo_Numero_telaio";
            this.comboBox25.FormattingEnabled = true;
            this.comboBox25.Location = new System.Drawing.Point(406, 76);
            this.comboBox25.Name = "comboBox25";
            this.comboBox25.Size = new System.Drawing.Size(188, 21);
            this.comboBox25.TabIndex = 1;
            this.comboBox25.ValueMember = "Veicolo_Numero_telaio";
            // 
            // riparazioneBindingSource
            // 
            this.riparazioneBindingSource.DataMember = "Riparazione";
            this.riparazioneBindingSource.DataSource = this.progettoDB16DataSet;
            // 
            // label120
            // 
            this.label120.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(226, 82);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(42, 13);
            this.label120.TabIndex = 12;
            this.label120.Text = "Veicolo";
            // 
            // comboBox11
            // 
            this.comboBox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox11.DataSource = this.riparazioneBindingSource;
            this.comboBox11.DisplayMember = "Numero";
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(406, 122);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(188, 21);
            this.comboBox11.TabIndex = 2;
            this.comboBox11.ValueMember = "Numero";
            // 
            // label54
            // 
            this.label54.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(226, 128);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(63, 13);
            this.label54.TabIndex = 10;
            this.label54.Text = "Riparazione";
            // 
            // comboBox10
            // 
            this.comboBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox10.DataSource = this.ricambioBindingSource;
            this.comboBox10.DisplayMember = "Codice";
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(406, 169);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(188, 21);
            this.comboBox10.TabIndex = 3;
            this.comboBox10.ValueMember = "Codice";
            // 
            // ricambioBindingSource
            // 
            this.ricambioBindingSource.DataMember = "Ricambio";
            this.ricambioBindingSource.DataSource = this.progettoDB16DataSet;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(226, 173);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(105, 13);
            this.label21.TabIndex = 7;
            this.label21.Text = "Ricambio interessato";
            // 
            // label40
            // 
            this.label40.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(226, 217);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(47, 13);
            this.label40.TabIndex = 6;
            this.label40.Text = "Quantità";
            // 
            // textBox16
            // 
            this.textBox16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox16.Location = new System.Drawing.Point(406, 214);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(188, 20);
            this.textBox16.TabIndex = 4;
            // 
            // addRicambioPanel
            // 
            this.addRicambioPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addRicambioPanel.Controls.Add(this.label119);
            this.addRicambioPanel.Controls.Add(this.comboBox13);
            this.addRicambioPanel.Controls.Add(this.label64);
            this.addRicambioPanel.Controls.Add(this.groupBox4);
            this.addRicambioPanel.Controls.Add(this.label43);
            this.addRicambioPanel.Controls.Add(this.submitRicambioBtn);
            this.addRicambioPanel.Controls.Add(this.textBox41);
            this.addRicambioPanel.Controls.Add(this.label56);
            this.addRicambioPanel.Controls.Add(this.label57);
            this.addRicambioPanel.Controls.Add(this.textBox39);
            this.addRicambioPanel.Controls.Add(this.textBox40);
            this.addRicambioPanel.Location = new System.Drawing.Point(1, -4);
            this.addRicambioPanel.Name = "addRicambioPanel";
            this.addRicambioPanel.Size = new System.Drawing.Size(836, 471);
            this.addRicambioPanel.TabIndex = 34;
            // 
            // label119
            // 
            this.label119.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(636, 209);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(39, 13);
            this.label119.TabIndex = 13;
            this.label119.Text = "--> tipo";
            // 
            // comboBox13
            // 
            this.comboBox13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox13.DataSource = this.fornitoreBindingSource;
            this.comboBox13.DisplayMember = "Partita_IVA";
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Location = new System.Drawing.Point(416, 204);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(191, 21);
            this.comboBox13.TabIndex = 5;
            this.comboBox13.ValueMember = "Partita_IVA";
            // 
            // label64
            // 
            this.label64.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(241, 207);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(48, 13);
            this.label64.TabIndex = 12;
            this.label64.Text = "Fornitore";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.label55);
            this.groupBox4.Controls.Add(this.label58);
            this.groupBox4.Controls.Add(this.textBox45);
            this.groupBox4.Controls.Add(this.textBox44);
            this.groupBox4.Location = new System.Drawing.Point(243, 121);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(365, 76);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Prezzi";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(7, 47);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(43, 13);
            this.label55.TabIndex = 13;
            this.label55.Text = "Vendita";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(8, 20);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(48, 13);
            this.label58.TabIndex = 12;
            this.label58.Text = "Acquisto";
            // 
            // textBox45
            // 
            this.textBox45.Location = new System.Drawing.Point(173, 17);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(188, 20);
            this.textBox45.TabIndex = 3;
            // 
            // textBox44
            // 
            this.textBox44.Location = new System.Drawing.Point(173, 44);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(188, 20);
            this.textBox44.TabIndex = 4;
            // 
            // label43
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(240, 238);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(57, 13);
            this.label43.TabIndex = 8;
            this.label43.Text = "Decrizione";
            // 
            // textBox41
            // 
            this.textBox41.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox41.Location = new System.Drawing.Point(374, 240);
            this.textBox41.Multiline = true;
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(233, 85);
            this.textBox41.TabIndex = 6;
            // 
            // label56
            // 
            this.label56.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(240, 102);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(35, 13);
            this.label56.TabIndex = 6;
            this.label56.Text = "Nome";
            // 
            // label57
            // 
            this.label57.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(241, 75);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(40, 13);
            this.label57.TabIndex = 4;
            this.label57.Text = "Codice";
            // 
            // textBox39
            // 
            this.textBox39.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox39.Location = new System.Drawing.Point(417, 99);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(191, 20);
            this.textBox39.TabIndex = 2;
            // 
            // textBox40
            // 
            this.textBox40.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox40.Location = new System.Drawing.Point(417, 72);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(192, 20);
            this.textBox40.TabIndex = 1;
            // 
            // addGiacenzaPanel
            // 
            this.addGiacenzaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addGiacenzaPanel.Controls.Add(this.textBox4);
            this.addGiacenzaPanel.Controls.Add(this.textBox48);
            this.addGiacenzaPanel.Controls.Add(this.submitGiacenzaBtn);
            this.addGiacenzaPanel.Controls.Add(this.label63);
            this.addGiacenzaPanel.Controls.Add(this.label62);
            this.addGiacenzaPanel.Controls.Add(this.comboBox12);
            this.addGiacenzaPanel.Controls.Add(this.textBox46);
            this.addGiacenzaPanel.Controls.Add(this.label59);
            this.addGiacenzaPanel.Controls.Add(this.dateTimePicker6);
            this.addGiacenzaPanel.Controls.Add(this.label60);
            this.addGiacenzaPanel.Controls.Add(this.label61);
            this.addGiacenzaPanel.Location = new System.Drawing.Point(1, -3);
            this.addGiacenzaPanel.Name = "addGiacenzaPanel";
            this.addGiacenzaPanel.Size = new System.Drawing.Size(836, 471);
            this.addGiacenzaPanel.TabIndex = 24;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Location = new System.Drawing.Point(416, 124);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(185, 20);
            this.textBox4.TabIndex = 19;
            // 
            // textBox48
            // 
            this.textBox48.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox48.Location = new System.Drawing.Point(366, 277);
            this.textBox48.Multiline = true;
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(235, 112);
            this.textBox48.TabIndex = 4;
            // 
            // label63
            // 
            this.label63.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(234, 280);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(45, 13);
            this.label63.TabIndex = 18;
            this.label63.Text = "Causale";
            // 
            // label62
            // 
            this.label62.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(235, 127);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(44, 13);
            this.label62.TabIndex = 16;
            this.label62.Text = "Numero";
            // 
            // comboBox12
            // 
            this.comboBox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox12.DataSource = this.ricambioBindingSource;
            this.comboBox12.DisplayMember = "Codice";
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Location = new System.Drawing.Point(416, 81);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(186, 21);
            this.comboBox12.TabIndex = 1;
            this.comboBox12.ValueMember = "Codice";
            // 
            // textBox46
            // 
            this.textBox46.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox46.Location = new System.Drawing.Point(416, 220);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(185, 20);
            this.textBox46.TabIndex = 3;
            // 
            // label59
            // 
            this.label59.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(233, 223);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(85, 13);
            this.label59.TabIndex = 13;
            this.label59.Text = "Nuova giacenza";
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker6.Location = new System.Drawing.Point(416, 165);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(186, 20);
            this.dateTimePicker6.TabIndex = 2;
            // 
            // label60
            // 
            this.label60.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(234, 167);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(30, 13);
            this.label60.TabIndex = 1;
            this.label60.Text = "Data";
            // 
            // label61
            // 
            this.label61.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(234, 85);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(51, 13);
            this.label61.TabIndex = 0;
            this.label61.Text = "Ricambio";
            // 
            // addVeicoloPanel
            // 
            this.addVeicoloPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addVeicoloPanel.Controls.Add(this.groupBox21);
            this.addVeicoloPanel.Controls.Add(this.submitVeicoloBtn);
            this.addVeicoloPanel.Controls.Add(this.groupBox6);
            this.addVeicoloPanel.Controls.Add(this.groupBox5);
            this.addVeicoloPanel.Controls.Add(this.label70);
            this.addVeicoloPanel.Controls.Add(this.textBox53);
            this.addVeicoloPanel.Location = new System.Drawing.Point(1, -3);
            this.addVeicoloPanel.Name = "addVeicoloPanel";
            this.addVeicoloPanel.Size = new System.Drawing.Size(836, 471);
            this.addVeicoloPanel.TabIndex = 35;
            // 
            // groupBox21
            // 
            this.groupBox21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox21.Controls.Add(this.dateTimePicker14);
            this.groupBox21.Controls.Add(this.comboBox24);
            this.groupBox21.Controls.Add(this.label65);
            this.groupBox21.Controls.Add(this.label118);
            this.groupBox21.Controls.Add(this.comboBox14);
            this.groupBox21.Controls.Add(this.label117);
            this.groupBox21.Location = new System.Drawing.Point(202, 75);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(428, 98);
            this.groupBox21.TabIndex = 2;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Produzione";
            // 
            // dateTimePicker14
            // 
            this.dateTimePicker14.Location = new System.Drawing.Point(202, 70);
            this.dateTimePicker14.Name = "dateTimePicker14";
            this.dateTimePicker14.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker14.TabIndex = 20;
            // 
            // comboBox24
            // 
            this.comboBox24.DataSource = this.fornitoreBindingSource;
            this.comboBox24.DisplayMember = "Partita_IVA";
            this.comboBox24.FormattingEnabled = true;
            this.comboBox24.Location = new System.Drawing.Point(208, 43);
            this.comboBox24.Name = "comboBox24";
            this.comboBox24.Size = new System.Drawing.Size(191, 21);
            this.comboBox24.TabIndex = 3;
            this.comboBox24.ValueMember = "Partita_IVA";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(24, 18);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(44, 13);
            this.label65.TabIndex = 12;
            this.label65.Text = "Modello";
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(24, 49);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(48, 13);
            this.label118.TabIndex = 19;
            this.label118.Text = "Fornitore";
            // 
            // comboBox14
            // 
            this.comboBox14.DataSource = this.modelloveicoloBindingSource;
            this.comboBox14.DisplayMember = "Nome";
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Location = new System.Drawing.Point(208, 12);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(191, 21);
            this.comboBox14.TabIndex = 2;
            this.comboBox14.ValueMember = "Nome";
            // 
            // modelloveicoloBindingSource
            // 
            this.modelloveicoloBindingSource.DataMember = "Modello_veicolo";
            this.modelloveicoloBindingSource.DataSource = this.progettoDB16DataSet;
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(24, 77);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(32, 13);
            this.label117.TabIndex = 17;
            this.label117.Text = "Anno";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox6.Controls.Add(this.label75);
            this.groupBox6.Controls.Add(this.textBox58);
            this.groupBox6.Controls.Add(this.label76);
            this.groupBox6.Controls.Add(this.textBox59);
            this.groupBox6.Controls.Add(this.label68);
            this.groupBox6.Controls.Add(this.textBox51);
            this.groupBox6.Controls.Add(this.textBox55);
            this.groupBox6.Controls.Add(this.label72);
            this.groupBox6.Location = new System.Drawing.Point(202, 176);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(428, 82);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Informazioni base";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(15, 56);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(102, 13);
            this.label75.TabIndex = 28;
            this.label75.Text = "Capienza bagagliaio";
            // 
            // textBox58
            // 
            this.textBox58.Location = new System.Drawing.Point(280, 51);
            this.textBox58.Name = "textBox58";
            this.textBox58.Size = new System.Drawing.Size(78, 20);
            this.textBox58.TabIndex = 8;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(240, 54);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(32, 13);
            this.label76.TabIndex = 26;
            this.label76.Text = "Porte";
            // 
            // textBox59
            // 
            this.textBox59.Location = new System.Drawing.Point(129, 54);
            this.textBox59.Name = "textBox59";
            this.textBox59.Size = new System.Drawing.Size(78, 20);
            this.textBox59.TabIndex = 7;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(15, 25);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(65, 13);
            this.label68.TabIndex = 14;
            this.label68.Text = "Prezzo base";
            // 
            // textBox51
            // 
            this.textBox51.Location = new System.Drawing.Point(129, 25);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(78, 20);
            this.textBox51.TabIndex = 5;
            // 
            // textBox55
            // 
            this.textBox55.Location = new System.Drawing.Point(280, 22);
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(78, 20);
            this.textBox55.TabIndex = 6;
            this.textBox55.UseWaitCursor = true;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(240, 26);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(30, 13);
            this.label72.TabIndex = 16;
            this.label72.Text = "Posti";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.Controls.Add(this.textBox60);
            this.groupBox5.Controls.Add(this.label77);
            this.groupBox5.Controls.Add(this.textBox61);
            this.groupBox5.Controls.Add(this.label78);
            this.groupBox5.Controls.Add(this.textBox49);
            this.groupBox5.Controls.Add(this.label66);
            this.groupBox5.Controls.Add(this.label73);
            this.groupBox5.Controls.Add(this.textBox52);
            this.groupBox5.Controls.Add(this.label69);
            this.groupBox5.Controls.Add(this.label67);
            this.groupBox5.Controls.Add(this.label71);
            this.groupBox5.Controls.Add(this.textBox56);
            this.groupBox5.Controls.Add(this.textBox54);
            this.groupBox5.Controls.Add(this.textBox57);
            this.groupBox5.Controls.Add(this.textBox50);
            this.groupBox5.Controls.Add(this.label74);
            this.groupBox5.Location = new System.Drawing.Point(202, 264);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(428, 123);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Motore e prestazioni";
            // 
            // textBox60
            // 
            this.textBox60.Location = new System.Drawing.Point(317, 42);
            this.textBox60.Name = "textBox60";
            this.textBox60.Size = new System.Drawing.Size(78, 20);
            this.textBox60.TabIndex = 12;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(245, 45);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(42, 13);
            this.label77.TabIndex = 30;
            this.label77.Text = "Cambio";
            // 
            // textBox61
            // 
            this.textBox61.Location = new System.Drawing.Point(105, 42);
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(78, 20);
            this.textBox61.TabIndex = 11;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(41, 49);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(48, 13);
            this.label78.TabIndex = 28;
            this.label78.Text = "Trazione";
            // 
            // textBox49
            // 
            this.textBox49.Location = new System.Drawing.Point(317, 15);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(78, 20);
            this.textBox49.TabIndex = 10;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(241, 19);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(50, 13);
            this.label66.TabIndex = 1;
            this.label66.Text = "Cilindrata";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(217, 99);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(95, 13);
            this.label73.TabIndex = 22;
            this.label73.Text = "Capacità serbatoio";
            // 
            // textBox52
            // 
            this.textBox52.Location = new System.Drawing.Point(105, 16);
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(78, 20);
            this.textBox52.TabIndex = 9;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(41, 22);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(46, 13);
            this.label69.TabIndex = 6;
            this.label69.Text = "Potenza";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(217, 72);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(95, 13);
            this.label67.TabIndex = 24;
            this.label67.Text = "Tipo alimentazione";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(42, 74);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(47, 13);
            this.label71.TabIndex = 18;
            this.label71.Text = "Consumi";
            // 
            // textBox56
            // 
            this.textBox56.Location = new System.Drawing.Point(316, 96);
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(78, 20);
            this.textBox56.TabIndex = 16;
            // 
            // textBox54
            // 
            this.textBox54.Location = new System.Drawing.Point(105, 71);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(78, 20);
            this.textBox54.TabIndex = 13;
            // 
            // textBox57
            // 
            this.textBox57.Location = new System.Drawing.Point(105, 99);
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(78, 20);
            this.textBox57.TabIndex = 15;
            // 
            // textBox50
            // 
            this.textBox50.Location = new System.Drawing.Point(316, 69);
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(78, 20);
            this.textBox50.TabIndex = 14;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(27, 102);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(74, 13);
            this.label74.TabIndex = 20;
            this.label74.Text = "Omologazione";
            // 
            // label70
            // 
            this.label70.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(216, 49);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(40, 13);
            this.label70.TabIndex = 4;
            this.label70.Text = "Codice";
            // 
            // textBox53
            // 
            this.textBox53.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox53.Location = new System.Drawing.Point(333, 45);
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(79, 20);
            this.textBox53.TabIndex = 1;
            // 
            // addModelloPanel
            // 
            this.addModelloPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addModelloPanel.Controls.Add(this.dateTimePicker15);
            this.addModelloPanel.Controls.Add(this.label79);
            this.addModelloPanel.Controls.Add(this.submitModelloBtn);
            this.addModelloPanel.Controls.Add(this.comboBox15);
            this.addModelloPanel.Controls.Add(this.label91);
            this.addModelloPanel.Controls.Add(this.label92);
            this.addModelloPanel.Controls.Add(this.textBox74);
            this.addModelloPanel.Location = new System.Drawing.Point(1, -3);
            this.addModelloPanel.Name = "addModelloPanel";
            this.addModelloPanel.Size = new System.Drawing.Size(836, 471);
            this.addModelloPanel.TabIndex = 36;
            // 
            // dateTimePicker15
            // 
            this.dateTimePicker15.Location = new System.Drawing.Point(381, 241);
            this.dateTimePicker15.Name = "dateTimePicker15";
            this.dateTimePicker15.Size = new System.Drawing.Size(192, 20);
            this.dateTimePicker15.TabIndex = 14;
            // 
            // label79
            // 
            this.label79.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(258, 237);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(32, 13);
            this.label79.TabIndex = 13;
            this.label79.Text = "Anno";
            // 
            // comboBox15
            // 
            this.comboBox15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox15.DataSource = this.fornitoreBindingSource;
            this.comboBox15.DisplayMember = "Partita_IVA";
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.ItemHeight = 13;
            this.comboBox15.Location = new System.Drawing.Point(382, 177);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(191, 21);
            this.comboBox15.TabIndex = 3;
            this.comboBox15.ValueMember = "Partita_IVA";
            // 
            // label91
            // 
            this.label91.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(256, 181);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(84, 13);
            this.label91.TabIndex = 12;
            this.label91.Text = "Casa produttrice";
            // 
            // label92
            // 
            this.label92.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(257, 127);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(35, 13);
            this.label92.TabIndex = 4;
            this.label92.Text = "Nome";
            // 
            // textBox74
            // 
            this.textBox74.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox74.Location = new System.Drawing.Point(381, 123);
            this.textBox74.Name = "textBox74";
            this.textBox74.Size = new System.Drawing.Size(192, 20);
            this.textBox74.TabIndex = 1;
            // 
            // addOptionalPanel
            // 
            this.addOptionalPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addOptionalPanel.Controls.Add(this.textBox66);
            this.addOptionalPanel.Controls.Add(this.label83);
            this.addOptionalPanel.Controls.Add(this.textBox65);
            this.addOptionalPanel.Controls.Add(this.textBox63);
            this.addOptionalPanel.Controls.Add(this.label80);
            this.addOptionalPanel.Controls.Add(this.label81);
            this.addOptionalPanel.Controls.Add(this.label82);
            this.addOptionalPanel.Controls.Add(this.textBox64);
            this.addOptionalPanel.Controls.Add(this.submitOptionalBtn);
            this.addOptionalPanel.Location = new System.Drawing.Point(0, -2);
            this.addOptionalPanel.Name = "addOptionalPanel";
            this.addOptionalPanel.Size = new System.Drawing.Size(836, 471);
            this.addOptionalPanel.TabIndex = 37;
            // 
            // textBox66
            // 
            this.textBox66.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox66.Location = new System.Drawing.Point(400, 212);
            this.textBox66.Multiline = true;
            this.textBox66.Name = "textBox66";
            this.textBox66.Size = new System.Drawing.Size(216, 109);
            this.textBox66.TabIndex = 4;
            // 
            // label83
            // 
            this.label83.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(272, 90);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(40, 13);
            this.label83.TabIndex = 16;
            this.label83.Text = "Codice";
            // 
            // textBox65
            // 
            this.textBox65.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox65.Location = new System.Drawing.Point(399, 86);
            this.textBox65.Name = "textBox65";
            this.textBox65.Size = new System.Drawing.Size(150, 20);
            this.textBox65.TabIndex = 1;
            // 
            // textBox63
            // 
            this.textBox63.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox63.Location = new System.Drawing.Point(400, 173);
            this.textBox63.Name = "textBox63";
            this.textBox63.Size = new System.Drawing.Size(150, 20);
            this.textBox63.TabIndex = 3;
            // 
            // label80
            // 
            this.label80.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(273, 177);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(39, 13);
            this.label80.TabIndex = 13;
            this.label80.Text = "Prezzo";
            // 
            // label81
            // 
            this.label81.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(273, 215);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(62, 13);
            this.label81.TabIndex = 12;
            this.label81.Text = "Descrizione";
            // 
            // label82
            // 
            this.label82.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(273, 133);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(35, 13);
            this.label82.TabIndex = 4;
            this.label82.Text = "Nome";
            // 
            // textBox64
            // 
            this.textBox64.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox64.Location = new System.Drawing.Point(400, 129);
            this.textBox64.Name = "textBox64";
            this.textBox64.Size = new System.Drawing.Size(150, 20);
            this.textBox64.TabIndex = 2;
            // 
            // addOptToVeicPanel
            // 
            this.addOptToVeicPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addOptToVeicPanel.Controls.Add(this.comboRic);
            this.addOptToVeicPanel.Controls.Add(this.comboVeicCat);
            this.addOptToVeicPanel.Controls.Add(this.comboOpt);
            this.addOptToVeicPanel.Controls.Add(this.comboVeicVend);
            this.addOptToVeicPanel.Controls.Add(this.label84);
            this.addOptToVeicPanel.Controls.Add(this.label87);
            this.addOptToVeicPanel.Controls.Add(this.submitOptToVeicBtn);
            this.addOptToVeicPanel.Location = new System.Drawing.Point(0, -2);
            this.addOptToVeicPanel.Name = "addOptToVeicPanel";
            this.addOptToVeicPanel.Size = new System.Drawing.Size(836, 471);
            this.addOptToVeicPanel.TabIndex = 38;
            this.addOptToVeicPanel.VisibleChanged += new System.EventHandler(this.addOptToVeicPanel_VisibleChanged);
            // 
            // comboRic
            // 
            this.comboRic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboRic.DataSource = this.riparazioneBindingSource;
            this.comboRic.DisplayMember = "Codice";
            this.comboRic.FormattingEnabled = true;
            this.comboRic.Location = new System.Drawing.Point(383, 173);
            this.comboRic.Name = "comboRic";
            this.comboRic.Size = new System.Drawing.Size(121, 21);
            this.comboRic.TabIndex = 18;
            this.comboRic.ValueMember = "Codice";
            // 
            // comboVeicCat
            // 
            this.comboVeicCat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboVeicCat.DataSource = this.veicoloincatalogoBindingSource;
            this.comboVeicCat.DisplayMember = "Codice";
            this.comboVeicCat.FormattingEnabled = true;
            this.comboVeicCat.Location = new System.Drawing.Point(384, 115);
            this.comboVeicCat.Name = "comboVeicCat";
            this.comboVeicCat.Size = new System.Drawing.Size(121, 21);
            this.comboVeicCat.TabIndex = 17;
            this.comboVeicCat.ValueMember = "Codice";
            // 
            // veicoloincatalogoBindingSource
            // 
            this.veicoloincatalogoBindingSource.DataMember = "Veicolo_in_catalogo";
            this.veicoloincatalogoBindingSource.DataSource = this.progettoDB16DataSet;
            // 
            // comboOpt
            // 
            this.comboOpt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboOpt.DataSource = this.optionalBindingSource;
            this.comboOpt.DisplayMember = "Codice";
            this.comboOpt.FormattingEnabled = true;
            this.comboOpt.Location = new System.Drawing.Point(383, 173);
            this.comboOpt.Name = "comboOpt";
            this.comboOpt.Size = new System.Drawing.Size(121, 21);
            this.comboOpt.TabIndex = 2;
            this.comboOpt.ValueMember = "Codice";
            // 
            // optionalBindingSource
            // 
            this.optionalBindingSource.DataMember = "Optional";
            this.optionalBindingSource.DataSource = this.progettoDB16DataSet;
            // 
            // comboVeicVend
            // 
            this.comboVeicVend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboVeicVend.DataSource = this.veicolovendutoBindingSource2;
            this.comboVeicVend.DisplayMember = "Numero_telaio";
            this.comboVeicVend.FormattingEnabled = true;
            this.comboVeicVend.Location = new System.Drawing.Point(384, 115);
            this.comboVeicVend.Name = "comboVeicVend";
            this.comboVeicVend.Size = new System.Drawing.Size(121, 21);
            this.comboVeicVend.TabIndex = 1;
            this.comboVeicVend.ValueMember = "Numero_telaio";
            // 
            // veicolovendutoBindingSource2
            // 
            this.veicolovendutoBindingSource2.DataMember = "Veicolo_venduto";
            this.veicolovendutoBindingSource2.DataSource = this.progettoDB16DataSet;
            // 
            // label84
            // 
            this.label84.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(285, 178);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(46, 13);
            this.label84.TabIndex = 16;
            this.label84.Text = "Optional";
            // 
            // label87
            // 
            this.label87.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(286, 118);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(42, 13);
            this.label87.TabIndex = 4;
            this.label87.Text = "Veicolo";
            // 
            // addVenditaPanel
            // 
            this.addVenditaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addVenditaPanel.Controls.Add(this.comboBox20);
            this.addVenditaPanel.Controls.Add(this.label95);
            this.addVenditaPanel.Controls.Add(this.textBox67);
            this.addVenditaPanel.Controls.Add(this.submitVenditaBtn);
            this.addVenditaPanel.Controls.Add(this.label85);
            this.addVenditaPanel.Controls.Add(this.comboBox18);
            this.addVenditaPanel.Controls.Add(this.comboBox19);
            this.addVenditaPanel.Controls.Add(this.label86);
            this.addVenditaPanel.Controls.Add(this.label88);
            this.addVenditaPanel.Location = new System.Drawing.Point(1, -2);
            this.addVenditaPanel.Name = "addVenditaPanel";
            this.addVenditaPanel.Size = new System.Drawing.Size(836, 471);
            this.addVenditaPanel.TabIndex = 39;
            // 
            // comboBox20
            // 
            this.comboBox20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox20.DataSource = this.contrattodivenditaBindingSource;
            this.comboBox20.DisplayMember = "Numero";
            this.comboBox20.FormattingEnabled = true;
            this.comboBox20.Location = new System.Drawing.Point(399, 189);
            this.comboBox20.Name = "comboBox20";
            this.comboBox20.Size = new System.Drawing.Size(121, 21);
            this.comboBox20.TabIndex = 3;
            this.comboBox20.ValueMember = "Numero";
            // 
            // label95
            // 
            this.label95.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(301, 194);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(50, 13);
            this.label95.TabIndex = 21;
            this.label95.Text = "Contratto";
            // 
            // textBox67
            // 
            this.textBox67.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox67.Location = new System.Drawing.Point(399, 101);
            this.textBox67.Name = "textBox67";
            this.textBox67.Size = new System.Drawing.Size(121, 20);
            this.textBox67.TabIndex = 1;
            // 
            // label85
            // 
            this.label85.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(301, 102);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(36, 13);
            this.label85.TabIndex = 19;
            this.label85.Text = "Telaio";
            // 
            // comboBox18
            // 
            this.comboBox18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox18.DataSource = this.ordineBindingSource;
            this.comboBox18.DisplayMember = "ID_ordine";
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Location = new System.Drawing.Point(399, 234);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(121, 21);
            this.comboBox18.TabIndex = 4;
            this.comboBox18.ValueMember = "ID_ordine";
            // 
            // comboBox19
            // 
            this.comboBox19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox19.DataSource = this.veicoloincatalogoBindingSource;
            this.comboBox19.DisplayMember = "Codice";
            this.comboBox19.FormattingEnabled = true;
            this.comboBox19.Location = new System.Drawing.Point(399, 144);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(121, 21);
            this.comboBox19.TabIndex = 2;
            this.comboBox19.ValueMember = "Codice";
            // 
            // label86
            // 
            this.label86.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(301, 239);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(91, 13);
            this.label86.TabIndex = 16;
            this.label86.Text = "Ordine spedizione";
            // 
            // label88
            // 
            this.label88.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(301, 147);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(42, 13);
            this.label88.TabIndex = 4;
            this.label88.Text = "Veicolo";
            // 
            // addRevisionePanel
            // 
            this.addRevisionePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addRevisionePanel.Controls.Add(this.textBox13);
            this.addRevisionePanel.Controls.Add(this.label90);
            this.addRevisionePanel.Controls.Add(this.dateTimePicker8);
            this.addRevisionePanel.Controls.Add(this.submitRevisioneBtn);
            this.addRevisionePanel.Controls.Add(this.label89);
            this.addRevisionePanel.Controls.Add(this.comboBox21);
            this.addRevisionePanel.Controls.Add(this.label93);
            this.addRevisionePanel.Location = new System.Drawing.Point(0, -3);
            this.addRevisionePanel.Name = "addRevisionePanel";
            this.addRevisionePanel.Size = new System.Drawing.Size(836, 471);
            this.addRevisionePanel.TabIndex = 40;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(359, 100);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(146, 20);
            this.textBox13.TabIndex = 22;
            // 
            // label90
            // 
            this.label90.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(261, 211);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(55, 13);
            this.label90.TabIndex = 21;
            this.label90.Text = "Scadenza";
            // 
            // dateTimePicker8
            // 
            this.dateTimePicker8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker8.Location = new System.Drawing.Point(359, 208);
            this.dateTimePicker8.Name = "dateTimePicker8";
            this.dateTimePicker8.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker8.TabIndex = 2;
            // 
            // label89
            // 
            this.label89.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(263, 103);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(44, 13);
            this.label89.TabIndex = 19;
            this.label89.Text = "Numero";
            // 
            // comboBox21
            // 
            this.comboBox21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox21.DataSource = this.veicolovendutoBindingSource;
            this.comboBox21.DisplayMember = "Numero_telaio";
            this.comboBox21.FormattingEnabled = true;
            this.comboBox21.Location = new System.Drawing.Point(359, 154);
            this.comboBox21.Name = "comboBox21";
            this.comboBox21.Size = new System.Drawing.Size(121, 21);
            this.comboBox21.TabIndex = 1;
            this.comboBox21.ValueMember = "Numero_telaio";
            // 
            // veicolovendutoBindingSource
            // 
            this.veicolovendutoBindingSource.DataMember = "Veicolo_venduto";
            this.veicolovendutoBindingSource.DataSource = this.progettoDB16DataSet;
            // 
            // label93
            // 
            this.label93.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(263, 156);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(42, 13);
            this.label93.TabIndex = 4;
            this.label93.Text = "Veicolo";
            // 
            // addOrdinePanel
            // 
            this.addOrdinePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addOrdinePanel.Controls.Add(this.groupBox24);
            this.addOrdinePanel.Controls.Add(this.groupBox22);
            this.addOrdinePanel.Controls.Add(this.groupBox23);
            this.addOrdinePanel.Controls.Add(this.submitAddOrdineBtn);
            this.addOrdinePanel.Location = new System.Drawing.Point(1, -2);
            this.addOrdinePanel.Name = "addOrdinePanel";
            this.addOrdinePanel.Size = new System.Drawing.Size(836, 473);
            this.addOrdinePanel.TabIndex = 41;
            // 
            // groupBox24
            // 
            this.groupBox24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox24.Controls.Add(this.label122);
            this.groupBox24.Controls.Add(this.textBox6);
            this.groupBox24.Controls.Add(this.label17);
            this.groupBox24.Controls.Add(this.comboBox30);
            this.groupBox24.Controls.Add(this.label123);
            this.groupBox24.Controls.Add(this.comboBox29);
            this.groupBox24.Location = new System.Drawing.Point(128, 61);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(385, 115);
            this.groupBox24.TabIndex = 30;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Informazioni base";
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(25, 28);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(52, 13);
            this.label122.TabIndex = 21;
            this.label122.Text = "ID Ordine";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(172, 24);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(120, 20);
            this.textBox6.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "No. fattura";
            // 
            // comboBox30
            // 
            this.comboBox30.DataSource = this.fatturadiacquistoBindingSource;
            this.comboBox30.DisplayMember = "Fornitore_Partita_IVA";
            this.comboBox30.FormattingEnabled = true;
            this.comboBox30.Location = new System.Drawing.Point(171, 50);
            this.comboBox30.Name = "comboBox30";
            this.comboBox30.Size = new System.Drawing.Size(121, 21);
            this.comboBox30.TabIndex = 25;
            this.comboBox30.ValueMember = "Fornitore_Partita_IVA";
            // 
            // fatturadiacquistoBindingSource
            // 
            this.fatturadiacquistoBindingSource.DataMember = "Fattura_di_acquisto";
            this.fatturadiacquistoBindingSource.DataSource = this.progettoDB16DataSet;
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(25, 54);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(48, 13);
            this.label123.TabIndex = 22;
            this.label123.Text = "Fornitore";
            // 
            // comboBox29
            // 
            this.comboBox29.DataSource = this.fatturadiacquistoBindingSource;
            this.comboBox29.DisplayMember = "Numero";
            this.comboBox29.FormattingEnabled = true;
            this.comboBox29.Location = new System.Drawing.Point(172, 81);
            this.comboBox29.Name = "comboBox29";
            this.comboBox29.Size = new System.Drawing.Size(121, 21);
            this.comboBox29.TabIndex = 24;
            this.comboBox29.ValueMember = "Numero";
            // 
            // groupBox22
            // 
            this.groupBox22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox22.Controls.Add(this.label18);
            this.groupBox22.Controls.Add(this.label44);
            this.groupBox22.Controls.Add(this.label121);
            this.groupBox22.Controls.Add(this.dateTimePicker13);
            this.groupBox22.Controls.Add(this.dateTimePicker12);
            this.groupBox22.Controls.Add(this.dateTimePicker11);
            this.groupBox22.Location = new System.Drawing.Point(127, 210);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(385, 130);
            this.groupBox22.TabIndex = 17;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Date";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Emissione";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(22, 58);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(59, 13);
            this.label44.TabIndex = 29;
            this.label44.Text = "Spedizione";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(22, 91);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(101, 13);
            this.label121.TabIndex = 27;
            this.label121.Text = "Consegna (prevista)";
            // 
            // dateTimePicker13
            // 
            this.dateTimePicker13.Location = new System.Drawing.Point(173, 88);
            this.dateTimePicker13.Name = "dateTimePicker13";
            this.dateTimePicker13.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker13.TabIndex = 2;
            // 
            // dateTimePicker12
            // 
            this.dateTimePicker12.Location = new System.Drawing.Point(172, 54);
            this.dateTimePicker12.Name = "dateTimePicker12";
            this.dateTimePicker12.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker12.TabIndex = 1;
            // 
            // dateTimePicker11
            // 
            this.dateTimePicker11.Location = new System.Drawing.Point(173, 21);
            this.dateTimePicker11.Name = "dateTimePicker11";
            this.dateTimePicker11.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker11.TabIndex = 0;
            // 
            // groupBox23
            // 
            this.groupBox23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox23.Controls.Add(this.radioButton2);
            this.groupBox23.Controls.Add(this.radioButton1);
            this.groupBox23.Location = new System.Drawing.Point(607, 154);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(119, 79);
            this.groupBox23.TabIndex = 8;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Tipologia";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 17);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.Text = "Per veicolo";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Per ricambio";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // addVeicRicToOrdinePanel
            // 
            this.addVeicRicToOrdinePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addVeicRicToOrdinePanel.Controls.Add(this.comboVeicolo);
            this.addVeicRicToOrdinePanel.Controls.Add(this.textBox93);
            this.addVeicRicToOrdinePanel.Controls.Add(this.comboRicambio);
            this.addVeicRicToOrdinePanel.Controls.Add(this.submitAddVeicRicToOrderBtn);
            this.addVeicRicToOrdinePanel.Controls.Add(this.comboBox3);
            this.addVeicRicToOrdinePanel.Controls.Add(this.label129);
            this.addVeicRicToOrdinePanel.Controls.Add(this.label131);
            this.addVeicRicToOrdinePanel.Controls.Add(this.label130);
            this.addVeicRicToOrdinePanel.Location = new System.Drawing.Point(1, -3);
            this.addVeicRicToOrdinePanel.Name = "addVeicRicToOrdinePanel";
            this.addVeicRicToOrdinePanel.Size = new System.Drawing.Size(836, 473);
            this.addVeicRicToOrdinePanel.TabIndex = 42;
            this.addVeicRicToOrdinePanel.VisibleChanged += new System.EventHandler(this.addVeicRicToOrdinePanel_VisibleChanged);
            // 
            // comboVeicolo
            // 
            this.comboVeicolo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboVeicolo.DataSource = this.veicoloincatalogoBindingSource;
            this.comboVeicolo.DisplayMember = "Codice";
            this.comboVeicolo.FormattingEnabled = true;
            this.comboVeicolo.Location = new System.Drawing.Point(420, 161);
            this.comboVeicolo.Name = "comboVeicolo";
            this.comboVeicolo.Size = new System.Drawing.Size(121, 21);
            this.comboVeicolo.TabIndex = 21;
            this.comboVeicolo.ValueMember = "Codice";
            // 
            // textBox93
            // 
            this.textBox93.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox93.Location = new System.Drawing.Point(420, 245);
            this.textBox93.Name = "textBox93";
            this.textBox93.Size = new System.Drawing.Size(121, 20);
            this.textBox93.TabIndex = 20;
            // 
            // comboRicambio
            // 
            this.comboRicambio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboRicambio.DataSource = this.ordineBindingSource;
            this.comboRicambio.DisplayMember = "ID_ordine";
            this.comboRicambio.FormattingEnabled = true;
            this.comboRicambio.Location = new System.Drawing.Point(420, 161);
            this.comboRicambio.Name = "comboRicambio";
            this.comboRicambio.Size = new System.Drawing.Size(121, 21);
            this.comboRicambio.TabIndex = 19;
            this.comboRicambio.ValueMember = "ID_ordine";
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox3.DataSource = this.ordineBindingSource;
            this.comboBox3.DisplayMember = "ID_ordine";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(420, 203);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 18;
            this.comboBox3.ValueMember = "ID_ordine";
            // 
            // label129
            // 
            this.label129.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label129.AutoSize = true;
            this.label129.Location = new System.Drawing.Point(291, 163);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(42, 13);
            this.label129.TabIndex = 15;
            this.label129.Text = "Veicolo";
            // 
            // label131
            // 
            this.label131.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label131.AutoSize = true;
            this.label131.Location = new System.Drawing.Point(292, 204);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(38, 13);
            this.label131.TabIndex = 17;
            this.label131.Text = "Ordine";
            // 
            // label130
            // 
            this.label130.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label130.AutoSize = true;
            this.label130.Location = new System.Drawing.Point(291, 247);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(47, 13);
            this.label130.TabIndex = 16;
            this.label130.Text = "Quantità";
            // 
            // addEsecRevPanel
            // 
            this.addEsecRevPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addEsecRevPanel.Controls.Add(this.comboBox27);
            this.addEsecRevPanel.Controls.Add(this.label125);
            this.addEsecRevPanel.Controls.Add(this.comboBox26);
            this.addEsecRevPanel.Controls.Add(this.dateTimePicker7);
            this.addEsecRevPanel.Controls.Add(this.button1);
            this.addEsecRevPanel.Controls.Add(this.label94);
            this.addEsecRevPanel.Controls.Add(this.label124);
            this.addEsecRevPanel.Location = new System.Drawing.Point(0, 0);
            this.addEsecRevPanel.Name = "addEsecRevPanel";
            this.addEsecRevPanel.Size = new System.Drawing.Size(836, 471);
            this.addEsecRevPanel.TabIndex = 23;
            // 
            // comboBox27
            // 
            this.comboBox27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox27.DataSource = this.revisioneBindingSource;
            this.comboBox27.DisplayMember = "Numero";
            this.comboBox27.FormattingEnabled = true;
            this.comboBox27.Location = new System.Drawing.Point(426, 164);
            this.comboBox27.Name = "comboBox27";
            this.comboBox27.Size = new System.Drawing.Size(121, 21);
            this.comboBox27.TabIndex = 6;
            this.comboBox27.ValueMember = "Numero";
            // 
            // revisioneBindingSource
            // 
            this.revisioneBindingSource.DataMember = "Revisione";
            this.revisioneBindingSource.DataSource = this.progettoDB16DataSet;
            // 
            // label125
            // 
            this.label125.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(241, 167);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(69, 13);
            this.label125.TabIndex = 5;
            this.label125.Text = "No. revisione";
            // 
            // comboBox26
            // 
            this.comboBox26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox26.DataSource = this.revisioneBindingSource;
            this.comboBox26.DisplayMember = "Veicolo_Numero_telaio";
            this.comboBox26.FormattingEnabled = true;
            this.comboBox26.Location = new System.Drawing.Point(426, 111);
            this.comboBox26.Name = "comboBox26";
            this.comboBox26.Size = new System.Drawing.Size(121, 21);
            this.comboBox26.TabIndex = 4;
            this.comboBox26.ValueMember = "Veicolo_Numero_telaio";
            // 
            // dateTimePicker7
            // 
            this.dateTimePicker7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker7.Location = new System.Drawing.Point(426, 219);
            this.dateTimePicker7.Name = "dateTimePicker7";
            this.dateTimePicker7.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker7.TabIndex = 2;
            // 
            // label94
            // 
            this.label94.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(241, 221);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(87, 13);
            this.label94.TabIndex = 1;
            this.label94.Text = "Data esecuzione";
            // 
            // label124
            // 
            this.label124.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(241, 114);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(42, 13);
            this.label124.TabIndex = 0;
            this.label124.Text = "Veicolo";
            // 
            // ricambioTableAdapter
            // 
            this.ricambioTableAdapter.ClearBeforeFill = true;
            // 
            // contratto_di_venditaTableAdapter
            // 
            this.contratto_di_venditaTableAdapter.ClearBeforeFill = true;
            // 
            // veicolo_vendutoTableAdapter
            // 
            this.veicolo_vendutoTableAdapter.ClearBeforeFill = true;
            // 
            // revisioneTableAdapter
            // 
            this.revisioneTableAdapter.ClearBeforeFill = true;
            // 
            // trasportoTableAdapter
            // 
            this.trasportoTableAdapter.ClearBeforeFill = true;
            // 
            // corriereTableAdapter
            // 
            this.corriereTableAdapter.ClearBeforeFill = true;
            // 
            // fornitoreTableAdapter
            // 
            this.fornitoreTableAdapter.ClearBeforeFill = true;
            // 
            // veicolo_in_catalogoTableAdapter
            // 
            this.veicolo_in_catalogoTableAdapter.ClearBeforeFill = true;
            // 
            // ordineTableAdapter
            // 
            this.ordineTableAdapter.ClearBeforeFill = true;
            // 
            // optionalTableAdapter
            // 
            this.optionalTableAdapter.ClearBeforeFill = true;
            // 
            // modello_veicoloTableAdapter
            // 
            this.modello_veicoloTableAdapter.ClearBeforeFill = true;
            // 
            // riparazioneTableAdapter
            // 
            this.riparazioneTableAdapter.ClearBeforeFill = true;
            // 
            // fattura_di_acquistoTableAdapter
            // 
            this.fattura_di_acquistoTableAdapter.ClearBeforeFill = true;
            // 
            // modalita_di_pagamentoTableAdapter
            // 
            this.modalita_di_pagamentoTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // nostre_modalita_di_pagamentoTableAdapter
            // 
            this.nostre_modalita_di_pagamentoTableAdapter.ClearBeforeFill = true;
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 467);
            this.Controls.Add(this.addRicambioPanel);
            this.Controls.Add(this.addUtilizzoRicambioRipPanel);
            this.Controls.Add(this.addRiparazionePanel);
            this.Controls.Add(this.addVeicRicToOrdinePanel);
            this.Controls.Add(this.addOrdinePanel);
            this.Controls.Add(this.addFornitorePanel);
            this.Controls.Add(this.addFatturaPanel);
            this.Controls.Add(this.addContrattoPanel);
            this.Controls.Add(this.addClientePanel);
            this.Controls.Add(this.addGiacenzaPanel);
            this.Controls.Add(this.addPagamentoPanel);
            this.Controls.Add(this.addEsecRevPanel);
            this.Controls.Add(this.addPerfPanel);
            this.Controls.Add(this.addTrasportoPanel);
            this.Controls.Add(this.addModalitaPagPanel);
            this.Controls.Add(this.addRevisionePanel);
            this.Controls.Add(this.addVenditaPanel);
            this.Controls.Add(this.addOptToVeicPanel);
            this.Controls.Add(this.addOptionalPanel);
            this.Controls.Add(this.addModelloPanel);
            this.Controls.Add(this.addVeicoloPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntryForm";
            this.addFornitorePanel.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.addFatturaPanel.ResumeLayout(false);
            this.addFatturaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modalitadipagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progettoDB16DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornitoreBindingSource)).EndInit();
            this.addModalitaPagPanel.ResumeLayout(false);
            this.addModalitaPagPanel.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.addClientePanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.addContrattoPanel.ResumeLayout(false);
            this.addContrattoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nostremodalitadipagamentoBindingSource)).EndInit();
            this.addTrasportoPanel.ResumeLayout(false);
            this.addTrasportoPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrattodivenditaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corriereBindingSource)).EndInit();
            this.addPerfPanel.ResumeLayout(false);
            this.addPerfPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trasportoBindingSource)).EndInit();
            this.addPagamentoPanel.ResumeLayout(false);
            this.addPagamentoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fatturadiacquistoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrattodivenditaBindingSource)).EndInit();
            this.addRiparazionePanel.ResumeLayout(false);
            this.addRiparazionePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veicolovendutoBindingSource1)).EndInit();
            this.addUtilizzoRicambioRipPanel.ResumeLayout(false);
            this.addUtilizzoRicambioRipPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riparazioneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricambioBindingSource)).EndInit();
            this.addRicambioPanel.ResumeLayout(false);
            this.addRicambioPanel.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.addGiacenzaPanel.ResumeLayout(false);
            this.addGiacenzaPanel.PerformLayout();
            this.addVeicoloPanel.ResumeLayout(false);
            this.addVeicoloPanel.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelloveicoloBindingSource)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.addModelloPanel.ResumeLayout(false);
            this.addModelloPanel.PerformLayout();
            this.addOptionalPanel.ResumeLayout(false);
            this.addOptionalPanel.PerformLayout();
            this.addOptToVeicPanel.ResumeLayout(false);
            this.addOptToVeicPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veicoloincatalogoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veicolovendutoBindingSource2)).EndInit();
            this.addVenditaPanel.ResumeLayout(false);
            this.addVenditaPanel.PerformLayout();
            this.addRevisionePanel.ResumeLayout(false);
            this.addRevisionePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veicolovendutoBindingSource)).EndInit();
            this.addOrdinePanel.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fatturadiacquistoBindingSource)).EndInit();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.addVeicRicToOrdinePanel.ResumeLayout(false);
            this.addVeicRicToOrdinePanel.PerformLayout();
            this.addEsecRevPanel.ResumeLayout(false);
            this.addEsecRevPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.revisioneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addFornitorePanel;
        private System.Windows.Forms.Panel addFatturaPanel;
        private System.Windows.Forms.Panel addModalitaPagPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFornRec1;
        private System.Windows.Forms.Button submitTrasportoBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox fornAddModPagComboBox;
        private System.Windows.Forms.Label fornAddModPagLabel;
        private Panel addClientePanel;
        private Panel addContrattoPanel;
        private TextBox textBox21;
        private Label label19;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private ComboBox comboBox6;
        private ComboBox comboBox5;
        private Panel addTrasportoPanel;
        private ComboBox comboBox7;
        private Label label32;
        private Label label34;
        private ComboBox comboBox8;
        private Label label31;
        private TextBox textBox27;
        private TextBox textBox24;
        private Label label38;
        private Label label37;
        private Label label36;
        private Label label35;
        private TextBox textBox20;
        private TextBox textBox19;
        private DateTimePicker dateTimePicker2;
        private Label label29;
        private TextBox textBox25;
        private TextBox textBox26;
        private Label label33;
        private Panel addPerfPanel;
        private DateTimePicker dateTimePicker3;
        private Label label47;
        private Label label48;
        private Panel addPagamentoPanel;
        private TextBox textBox29;
        private Label label41;
        private DateTimePicker dateTimePicker4;
        private Label label39;
        private Label contratto_AddPagLabel;
        private ComboBox comboContratto;
        private TextBox textBoxFornCitta;
        private TextBox textBoxFornProvincia;
        private Label label42;
        private Label label50;
        private Label label51;
        private Label label52;
        private TextBox textBoxFornCAP;
        private TextBox textBoxFornIndirizzo;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel addRiparazionePanel;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker5;
        private Label label45;
        private Label label46;
        private Label label49;
        private Label label53;
        private TextBox textBox42;
        private TextBox textBox43;
        private Panel addUtilizzoRicambioRipPanel;
        private ComboBox comboBox11;
        private Label label54;
        private ComboBox comboBox10;
        private Label label21;
        private Label label40;
        private TextBox textBox16;
        private Panel addRicambioPanel;
        private Label label56;
        private Label label57;
        private TextBox textBox39;
        private TextBox textBox40;
        private Label label43;
        private TextBox textBox41;
        private GroupBox groupBox4;
        private Label label55;
        private Label label58;
        private TextBox textBox45;
        private TextBox textBox44;
        private Panel addGiacenzaPanel;
        private Label label62;
        private ComboBox comboBox12;
        private TextBox textBox46;
        private Label label59;
        private DateTimePicker dateTimePicker6;
        private Label label60;
        private Label label61;
        private TextBox textBox48;
        private Label label63;
        private ComboBox comboBox13;
        private Label label64;
        private Panel addVeicoloPanel;
        private GroupBox groupBox6;
        private Label label68;
        private TextBox textBox51;
        private Label label73;
        private Label label67;
        private TextBox textBox56;
        private TextBox textBox50;
        private Label label74;
        private TextBox textBox55;
        private TextBox textBox57;
        private Label label72;
        private TextBox textBox54;
        private Label label71;
        private GroupBox groupBox5;
        private TextBox textBox49;
        private Label label66;
        private TextBox textBox52;
        private Label label69;
        private ComboBox comboBox14;
        private Label label65;
        private Label label70;
        private TextBox textBox53;
        private Label label75;
        private TextBox textBox58;
        private Label label76;
        private TextBox textBox59;
        private TextBox textBox60;
        private Label label77;
        private TextBox textBox61;
        private Label label78;
        private Panel addModelloPanel;
        private Label label79;
        private ComboBox comboBox15;
        private Label label91;
        private Label label92;
        private TextBox textBox74;
        private Panel addOptionalPanel;
        private TextBox textBox66;
        private Label label83;
        private TextBox textBox65;
        private TextBox textBox63;
        private Label label80;
        private Label label81;
        private Label label82;
        private TextBox textBox64;
        private Panel addOptToVeicPanel;
        private ComboBox comboOpt;
        private ComboBox comboVeicVend;
        private Label label84;
        private Label label87;
        private Panel addVenditaPanel;
        private TextBox textBox67;
        private Label label85;
        private ComboBox comboBox18;
        private ComboBox comboBox19;
        private Label label86;
        private Label label88;
        private Panel addRevisionePanel;
        private Label label90;
        private Label label89;
        private ComboBox comboBox21;
        private Label label93;
        private DateTimePicker dateTimePicker8;
        private ComboBox comboBox20;
        private Label label95;
        private DateTimePicker dateTimePicker9;
        private Button submitModalitaPagBtn;
        private Button submitRevisioneBtn;
        private Button submitVenditaBtn;
        private Button submitFatturaBtn;
        private Button submitOptionalBtn;
        private Button submitRicambioBtn;
        private Button submitDettaglioBtn;
        private Button submitFornitoreBtn;
        private Button submitOptToVeicBtn;
        private Button submitModelloBtn;
        private Button submitRiparazione;
        private Button submitVeicoloBtn;
        private Button submitContrattoBtn;
        private Button submitPerfTraspBtn;
        private Button submitClienteABtn;
        private Button submitGiacenzaBtn;
        private Button submitPagamentoBtn;
        private GroupBox groupBox8;
        private Label label97;
        private Label label96;
        private TextBox textBoxFornRec3;
        private TextBox textBoxFornRec2;
        private GroupBox groupBox9;
        private Label label98;
        private TextBox textBoxFornEmail1;
        private Label label100;
        private TextBox textBoxFornEmail2;
        private GroupBox groupBox10;
        private CheckBox checkBoxFornRic;
        private CheckBox checkBoxFornVeic;
        private GroupBox groupBox11;
        private TextBox textBoxFornPIVA;
        private TextBox textBoxFornRagSoc;
        private Label label4;
        private ComboBox comboBox22;
        private TextBox textBox5;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox3;
        private TextBox textBox28;
        private Label label14;
        private TextBox textBox30;
        private TextBox textBox31;
        private TextBox textBox32;
        private Label label15;
        private Label label16;
        private Label label30;
        private TabPage tabPage2;
        private TextBox textBox77;
        private Label label105;
        private GroupBox groupBox13;
        private GroupBox groupBox14;
        private TextBox textBox80;
        private Label label108;
        private TextBox textBox82;
        private Label label109;
        private TextBox textBox15;
        private Label label106;
        private TextBox textBox81;
        private Label label107;
        private Button submitClientePBtn;
        private GroupBox groupBox15;
        private TextBox textBox14;
        private Label label23;
        private TextBox textBox18;
        private Label label24;
        private GroupBox groupBox17;
        private TextBox textBox85;
        private Label label112;
        private TextBox textBox86;
        private TextBox textBox87;
        private TextBox textBox88;
        private Label label113;
        private Label label114;
        private Label label115;
        private GroupBox groupBox12;
        private TextBox textBox23;
        private Label label99;
        private TextBox textBox73;
        private Label label101;
        private Label label102;
        private TextBox textBox2;
        private Label label20;
        private DateTimePicker dateTimePicker10;
        private GroupBox groupBox16;
        private TextBox textBox75;
        private Label label103;
        private TextBox textBox76;
        private Label label104;
        private TextBox textBox78;
        private Label label110;
        private GroupBox groupBox18;
        private TextBox textBox1;
        private Label label22;
        private TextBox textBox17;
        private Label label111;
        private TextBox textBox79;
        private Label label116;
        private GroupBox groupBox20;
        private GroupBox groupBox19;
        private GroupBox groupBox21;
        private ComboBox comboBox24;
        private Label label118;
        private Label label117;
        private Label label119;
        private ComboBox comboBox25;
        private Label label120;
        private Panel addOrdinePanel;
        private Label label17;
        private GroupBox groupBox23;
        private Button submitAddOrdineBtn;
        private Panel addVeicRicToOrdinePanel;
        private Button submitAddVeicRicToOrderBtn;
        private TextBox textBox93;
        private ComboBox comboRicambio;
        private ComboBox comboBox3;
        private Label label131;
        private Label label130;
        private Label label129;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label122;
        private Label label123;
        private TextBox textBox6;
        private ComboBox comboBox30;
        private ComboBox comboBox29;
        private GroupBox groupBox24;
        private GroupBox groupBox22;
        private Label label18;
        private Label label44;
        private Label label121;
        private DateTimePicker dateTimePicker13;
        private DateTimePicker dateTimePicker12;
        private DateTimePicker dateTimePicker11;
        private ComboBox comboTrasporto;
        private Panel addEsecRevPanel;
        private ComboBox comboBox26;
        private DateTimePicker dateTimePicker7;
        private Button button1;
        private Label label94;
        private Label label124;
        private ComboBox comboBox27;
        private Label label125;
        private DateTimePicker dateTimePicker14;
        private ProgettoDB16DataSet progettoDB16DataSet;
        private BindingSource ricambioBindingSource;
        private ProgettoDB16DataSetTableAdapters.RicambioTableAdapter ricambioTableAdapter;
        private BindingSource contrattodivenditaBindingSource;
        private ProgettoDB16DataSetTableAdapters.Contratto_di_venditaTableAdapter contratto_di_venditaTableAdapter;
        private BindingSource veicolovendutoBindingSource;
        private ProgettoDB16DataSetTableAdapters.Veicolo_vendutoTableAdapter veicolo_vendutoTableAdapter;
        private BindingSource revisioneBindingSource;
        private ProgettoDB16DataSetTableAdapters.RevisioneTableAdapter revisioneTableAdapter;
        private BindingSource trasportoBindingSource;
        private ProgettoDB16DataSetTableAdapters.TrasportoTableAdapter trasportoTableAdapter;
        private BindingSource contrattodivenditaBindingSource1;
        private BindingSource corriereBindingSource;
        private ProgettoDB16DataSetTableAdapters.CorriereTableAdapter corriereTableAdapter;
        private BindingSource fornitoreBindingSource;
        private ProgettoDB16DataSetTableAdapters.FornitoreTableAdapter fornitoreTableAdapter;
        private BindingSource veicolovendutoBindingSource1;
        private BindingSource veicoloincatalogoBindingSource;
        private ProgettoDB16DataSetTableAdapters.Veicolo_in_catalogoTableAdapter veicolo_in_catalogoTableAdapter;
        private BindingSource veicolovendutoBindingSource2;
        private BindingSource ordineBindingSource;
        private ProgettoDB16DataSetTableAdapters.OrdineTableAdapter ordineTableAdapter;
        private ComboBox comboVeicCat;
        private BindingSource optionalBindingSource;
        private ProgettoDB16DataSetTableAdapters.OptionalTableAdapter optionalTableAdapter;
        private ComboBox comboRic;
        private DateTimePicker dateTimePicker15;
        private BindingSource modelloveicoloBindingSource;
        private ProgettoDB16DataSetTableAdapters.Modello_veicoloTableAdapter modello_veicoloTableAdapter;
        private BindingSource riparazioneBindingSource;
        private ProgettoDB16DataSetTableAdapters.RiparazioneTableAdapter riparazioneTableAdapter;
        private ComboBox comboVeicolo;
        private BindingSource fatturadiacquistoBindingSource;
        private ProgettoDB16DataSetTableAdapters.Fattura_di_acquistoTableAdapter fattura_di_acquistoTableAdapter;
        private BindingSource modalitadipagamentoBindingSource;
        private ProgettoDB16DataSetTableAdapters.Modalita_di_pagamentoTableAdapter modalita_di_pagamentoTableAdapter;
        private BindingSource clienteBindingSource;
        private ProgettoDB16DataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private BindingSource nostremodalitadipagamentoBindingSource;
        private ProgettoDB16DataSetTableAdapters.Nostre_modalita_di_pagamentoTableAdapter nostre_modalita_di_pagamentoTableAdapter;
        private ComboBox comboFattura;
        private ComboBox comboFornitore;
        private Label label126;
        private BindingSource fatturadiacquistoBindingSource1;
        private ComboBox comboOrdine;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox13;
    }
}
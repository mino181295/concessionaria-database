namespace DBProject
{
    partial class opForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(opForm));
            this.panelIncassi = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelIncassi = new System.Windows.Forms.Label();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.panelOpionalToVeic = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridViewOptional = new System.Windows.Forms.DataGridView();
            this.panelHome = new System.Windows.Forms.Panel();
            this.buttonC3 = new System.Windows.Forms.Button();
            this.buttonB3 = new System.Windows.Forms.Button();
            this.buttonA1 = new System.Windows.Forms.Button();
            this.panelClassificaVendite = new System.Windows.Forms.Panel();
            this.fornitoriPanel_backBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewVendite = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panelIncassi.SuspendLayout();
            this.panelOpionalToVeic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOptional)).BeginInit();
            this.panelHome.SuspendLayout();
            this.panelClassificaVendite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendite)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIncassi
            // 
            this.panelIncassi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelIncassi.Controls.Add(this.button5);
            this.panelIncassi.Controls.Add(this.label5);
            this.panelIncassi.Controls.Add(this.label4);
            this.panelIncassi.Controls.Add(this.label3);
            this.panelIncassi.Controls.Add(this.labelIncassi);
            this.panelIncassi.Controls.Add(this.dateTimePicker5);
            this.panelIncassi.Controls.Add(this.dateTimePicker4);
            this.panelIncassi.Location = new System.Drawing.Point(0, 1);
            this.panelIncassi.Name = "panelIncassi";
            this.panelIncassi.Size = new System.Drawing.Size(685, 440);
            this.panelIncassi.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button5.AutoSize = true;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(319, 334);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 41);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "TOTALE INCASSI:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Da";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "A";
            // 
            // labelIncassi
            // 
            this.labelIncassi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIncassi.AutoSize = true;
            this.labelIncassi.Location = new System.Drawing.Point(364, 239);
            this.labelIncassi.Name = "labelIncassi";
            this.labelIncassi.Size = new System.Drawing.Size(13, 13);
            this.labelIncassi.TabIndex = 3;
            this.labelIncassi.Text = "0";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker5.Location = new System.Drawing.Point(261, 170);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker5.TabIndex = 2;
            this.dateTimePicker5.ValueChanged += new System.EventHandler(this.dateTimePickerIncassi_ValueChanged);
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker4.Location = new System.Drawing.Point(261, 126);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker4.TabIndex = 1;
            this.dateTimePicker4.ValueChanged += new System.EventHandler(this.dateTimePickerIncassi_ValueChanged);
            // 
            // panelOpionalToVeic
            // 
            this.panelOpionalToVeic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOpionalToVeic.Controls.Add(this.label6);
            this.panelOpionalToVeic.Controls.Add(this.button4);
            this.panelOpionalToVeic.Controls.Add(this.comboBox1);
            this.panelOpionalToVeic.Controls.Add(this.dataGridViewOptional);
            this.panelOpionalToVeic.Location = new System.Drawing.Point(0, 0);
            this.panelOpionalToVeic.Name = "panelOpionalToVeic";
            this.panelOpionalToVeic.Size = new System.Drawing.Size(685, 432);
            this.panelOpionalToVeic.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.AutoSize = true;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(610, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 41);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 355);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridViewOptional
            // 
            this.dataGridViewOptional.AllowUserToAddRows = false;
            this.dataGridViewOptional.AllowUserToDeleteRows = false;
            this.dataGridViewOptional.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOptional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOptional.Location = new System.Drawing.Point(5, 4);
            this.dataGridViewOptional.Name = "dataGridViewOptional";
            this.dataGridViewOptional.ReadOnly = true;
            this.dataGridViewOptional.Size = new System.Drawing.Size(675, 296);
            this.dataGridViewOptional.TabIndex = 0;
            // 
            // panelHome
            // 
            this.panelHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHome.Controls.Add(this.buttonC3);
            this.panelHome.Controls.Add(this.buttonB3);
            this.panelHome.Controls.Add(this.buttonA1);
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(685, 438);
            this.panelHome.TabIndex = 11;
            // 
            // buttonC3
            // 
            this.buttonC3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonC3.Location = new System.Drawing.Point(272, 273);
            this.buttonC3.Name = "buttonC3";
            this.buttonC3.Size = new System.Drawing.Size(116, 45);
            this.buttonC3.TabIndex = 2;
            this.buttonC3.Text = "[C3] Incassi del periodo";
            this.buttonC3.UseVisualStyleBackColor = true;
            this.buttonC3.Click += new System.EventHandler(this.buttonOp_Click);
            // 
            // buttonB3
            // 
            this.buttonB3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonB3.Location = new System.Drawing.Point(272, 197);
            this.buttonB3.Name = "buttonB3";
            this.buttonB3.Size = new System.Drawing.Size(116, 47);
            this.buttonB3.TabIndex = 1;
            this.buttonB3.Text = "[B3] Classifica veicoli venduti nel periodo";
            this.buttonB3.UseVisualStyleBackColor = true;
            this.buttonB3.Click += new System.EventHandler(this.buttonOp_Click);
            // 
            // buttonA1
            // 
            this.buttonA1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonA1.Location = new System.Drawing.Point(272, 136);
            this.buttonA1.Name = "buttonA1";
            this.buttonA1.Size = new System.Drawing.Size(116, 23);
            this.buttonA1.TabIndex = 0;
            this.buttonA1.Text = "[A1] Optional veicolo";
            this.buttonA1.UseVisualStyleBackColor = true;
            this.buttonA1.Click += new System.EventHandler(this.buttonOp_Click);
            // 
            // panelClassificaVendite
            // 
            this.panelClassificaVendite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClassificaVendite.Controls.Add(this.fornitoriPanel_backBtn);
            this.panelClassificaVendite.Controls.Add(this.label2);
            this.panelClassificaVendite.Controls.Add(this.label1);
            this.panelClassificaVendite.Controls.Add(this.dateTimePicker3);
            this.panelClassificaVendite.Controls.Add(this.dateTimePicker2);
            this.panelClassificaVendite.Controls.Add(this.dataGridViewVendite);
            this.panelClassificaVendite.Location = new System.Drawing.Point(0, 0);
            this.panelClassificaVendite.Name = "panelClassificaVendite";
            this.panelClassificaVendite.Size = new System.Drawing.Size(685, 435);
            this.panelClassificaVendite.TabIndex = 12;
            // 
            // fornitoriPanel_backBtn
            // 
            this.fornitoriPanel_backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fornitoriPanel_backBtn.AutoSize = true;
            this.fornitoriPanel_backBtn.Image = ((System.Drawing.Image)(resources.GetObject("fornitoriPanel_backBtn.Image")));
            this.fornitoriPanel_backBtn.Location = new System.Drawing.Point(620, 344);
            this.fornitoriPanel_backBtn.Name = "fornitoriPanel_backBtn";
            this.fornitoriPanel_backBtn.Size = new System.Drawing.Size(41, 41);
            this.fornitoriPanel_backBtn.TabIndex = 5;
            this.fornitoriPanel_backBtn.UseVisualStyleBackColor = true;
            this.fornitoriPanel_backBtn.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data finale";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data iniziale";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimePicker3.Location = new System.Drawing.Point(214, 370);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(288, 20);
            this.dateTimePicker3.TabIndex = 2;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimeVendite_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimePicker2.Location = new System.Drawing.Point(214, 336);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(288, 20);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimeVendite_ValueChanged);
            // 
            // dataGridViewVendite
            // 
            this.dataGridViewVendite.AllowUserToAddRows = false;
            this.dataGridViewVendite.AllowUserToDeleteRows = false;
            this.dataGridViewVendite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVendite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVendite.Location = new System.Drawing.Point(5, 5);
            this.dataGridViewVendite.Name = "dataGridViewVendite";
            this.dataGridViewVendite.ReadOnly = true;
            this.dataGridViewVendite.Size = new System.Drawing.Size(675, 296);
            this.dataGridViewVendite.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Veicolo in catalogo";
            // 
            // opForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelClassificaVendite);
            this.Controls.Add(this.panelOpionalToVeic);
            this.Controls.Add(this.panelIncassi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "opForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Operazioni";
            this.panelIncassi.ResumeLayout(false);
            this.panelIncassi.PerformLayout();
            this.panelOpionalToVeic.ResumeLayout(false);
            this.panelOpionalToVeic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOptional)).EndInit();
            this.panelHome.ResumeLayout(false);
            this.panelClassificaVendite.ResumeLayout(false);
            this.panelClassificaVendite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelIncassi;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label labelIncassi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelOpionalToVeic;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridViewOptional;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button buttonC3;
        private System.Windows.Forms.Button buttonB3;
        private System.Windows.Forms.Button buttonA1;
        private System.Windows.Forms.Panel panelClassificaVendite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridViewVendite;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button fornitoriPanel_backBtn;
        private System.Windows.Forms.Label label6;
    }
}
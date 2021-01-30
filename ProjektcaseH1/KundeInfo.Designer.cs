namespace ProjektcaseH1
{
    partial class KundeInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KID = new System.Windows.Forms.Label();
            this.KundeID = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.Pnr = new System.Windows.Forms.TextBox();
            this.bby = new System.Windows.Forms.TextBox();
            this.Mnr = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.EF = new System.Windows.Forms.TextBox();
            this.FN = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.Label();
            this.PostNr = new System.Windows.Forms.Label();
            this.By = new System.Windows.Forms.Label();
            this.Mobil = new System.Windows.Forms.Label();
            this.Efternavn = new System.Windows.Forms.Label();
            this.Fornavn = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.opdatering = new System.Windows.Forms.Button();
            this.Vis = new System.Windows.Forms.Button();
            this.TilbageKnap = new System.Windows.Forms.Button();
            this.SletKnap = new System.Windows.Forms.Button();
            this.GemKnap = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fornavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efternavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.byDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kundeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kundeInfoNyeNyeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektcaseDBDataSet2 = new ProjektcaseH1.ProjektcaseDBDataSet2();
            this.kundeInfoNyeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektcaseDBDataSet1 = new ProjektcaseH1.ProjektcaseDBDataSet1();
            this.kundeInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektcaseDBDataSet = new ProjektcaseH1.ProjektcaseDBDataSet();
            this.kundeInfoTableAdapter = new ProjektcaseH1.ProjektcaseDBDataSetTableAdapters.KundeInfoTableAdapter();
            this.kundeInfoNyeTableAdapter = new ProjektcaseH1.ProjektcaseDBDataSet1TableAdapters.KundeInfoNyeTableAdapter();
            this.kundeInfoNyeNyeTableAdapter = new ProjektcaseH1.ProjektcaseDBDataSet2TableAdapters.KundeInfoNyeNyeTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeInfoNyeNyeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektcaseDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeInfoNyeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektcaseDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektcaseDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.KID);
            this.groupBox1.Controls.Add(this.KundeID);
            this.groupBox1.Controls.Add(this.mail);
            this.groupBox1.Controls.Add(this.Pnr);
            this.groupBox1.Controls.Add(this.bby);
            this.groupBox1.Controls.Add(this.Mnr);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.EF);
            this.groupBox1.Controls.Add(this.FN);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.Adresse);
            this.groupBox1.Controls.Add(this.PostNr);
            this.groupBox1.Controls.Add(this.By);
            this.groupBox1.Controls.Add(this.Mobil);
            this.groupBox1.Controls.Add(this.Efternavn);
            this.groupBox1.Controls.Add(this.Fornavn);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kunde info";
            // 
            // KID
            // 
            this.KID.AutoSize = true;
            this.KID.Location = new System.Drawing.Point(363, 128);
            this.KID.Name = "KID";
            this.KID.Size = new System.Drawing.Size(52, 13);
            this.KID.TabIndex = 16;
            this.KID.Text = "Kunde ID";
            // 
            // KundeID
            // 
            this.KundeID.AutoSize = true;
            this.KundeID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KundeID.Location = new System.Drawing.Point(435, 128);
            this.KundeID.Name = "KundeID";
            this.KundeID.Size = new System.Drawing.Size(0, 13);
            this.KundeID.TabIndex = 15;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(100, 125);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(100, 20);
            this.mail.TabIndex = 10;
            // 
            // Pnr
            // 
            this.Pnr.Location = new System.Drawing.Point(438, 59);
            this.Pnr.Name = "Pnr";
            this.Pnr.Size = new System.Drawing.Size(100, 20);
            this.Pnr.TabIndex = 12;
            // 
            // bby
            // 
            this.bby.Location = new System.Drawing.Point(438, 26);
            this.bby.Name = "bby";
            this.bby.Size = new System.Drawing.Size(100, 20);
            this.bby.TabIndex = 11;
            // 
            // Mnr
            // 
            this.Mnr.Location = new System.Drawing.Point(100, 96);
            this.Mnr.Name = "Mnr";
            this.Mnr.Size = new System.Drawing.Size(100, 20);
            this.Mnr.TabIndex = 9;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(438, 89);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(100, 20);
            this.address.TabIndex = 13;
            // 
            // EF
            // 
            this.EF.Location = new System.Drawing.Point(100, 62);
            this.EF.Name = "EF";
            this.EF.Size = new System.Drawing.Size(100, 20);
            this.EF.TabIndex = 8;
            // 
            // FN
            // 
            this.FN.Location = new System.Drawing.Point(100, 26);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(100, 20);
            this.FN.TabIndex = 7;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(25, 128);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email";
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Location = new System.Drawing.Point(363, 91);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(45, 13);
            this.Adresse.TabIndex = 6;
            this.Adresse.Text = "Adresse";
            // 
            // PostNr
            // 
            this.PostNr.AutoSize = true;
            this.PostNr.Location = new System.Drawing.Point(363, 62);
            this.PostNr.Name = "PostNr";
            this.PostNr.Size = new System.Drawing.Size(39, 13);
            this.PostNr.TabIndex = 5;
            this.PostNr.Text = "PostNr";
            // 
            // By
            // 
            this.By.AutoSize = true;
            this.By.Location = new System.Drawing.Point(363, 29);
            this.By.Name = "By";
            this.By.Size = new System.Drawing.Size(19, 13);
            this.By.TabIndex = 4;
            this.By.Text = "By";
            // 
            // Mobil
            // 
            this.Mobil.AutoSize = true;
            this.Mobil.Location = new System.Drawing.Point(25, 96);
            this.Mobil.Name = "Mobil";
            this.Mobil.Size = new System.Drawing.Size(32, 13);
            this.Mobil.TabIndex = 2;
            this.Mobil.Text = "Mobil";
            // 
            // Efternavn
            // 
            this.Efternavn.AutoSize = true;
            this.Efternavn.Location = new System.Drawing.Point(25, 62);
            this.Efternavn.Name = "Efternavn";
            this.Efternavn.Size = new System.Drawing.Size(53, 13);
            this.Efternavn.TabIndex = 1;
            this.Efternavn.Text = "Efternavn";
            // 
            // Fornavn
            // 
            this.Fornavn.AutoSize = true;
            this.Fornavn.Location = new System.Drawing.Point(25, 29);
            this.Fornavn.Name = "Fornavn";
            this.Fornavn.Size = new System.Drawing.Size(46, 13);
            this.Fornavn.TabIndex = 0;
            this.Fornavn.Text = "Fornavn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.opdatering);
            this.groupBox2.Controls.Add(this.Vis);
            this.groupBox2.Controls.Add(this.TilbageKnap);
            this.groupBox2.Controls.Add(this.SletKnap);
            this.groupBox2.Controls.Add(this.GemKnap);
            this.groupBox2.Location = new System.Drawing.Point(26, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 49);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // opdatering
            // 
            this.opdatering.Location = new System.Drawing.Point(142, 10);
            this.opdatering.Name = "opdatering";
            this.opdatering.Size = new System.Drawing.Size(129, 33);
            this.opdatering.TabIndex = 4;
            this.opdatering.Text = "Opdatering";
            this.opdatering.UseVisualStyleBackColor = true;
            this.opdatering.Click += new System.EventHandler(this.opdatering_Click);
            // 
            // Vis
            // 
            this.Vis.Location = new System.Drawing.Point(279, 10);
            this.Vis.Name = "Vis";
            this.Vis.Size = new System.Drawing.Size(129, 33);
            this.Vis.TabIndex = 2;
            this.Vis.Text = "Vis";
            this.Vis.UseVisualStyleBackColor = true;
            this.Vis.Click += new System.EventHandler(this.Vis_Click);
            // 
            // TilbageKnap
            // 
            this.TilbageKnap.Location = new System.Drawing.Point(572, 10);
            this.TilbageKnap.Name = "TilbageKnap";
            this.TilbageKnap.Size = new System.Drawing.Size(128, 33);
            this.TilbageKnap.TabIndex = 3;
            this.TilbageKnap.Text = "Tilbage";
            this.TilbageKnap.UseVisualStyleBackColor = true;
            this.TilbageKnap.Click += new System.EventHandler(this.TilbageKnap_Click);
            // 
            // SletKnap
            // 
            this.SletKnap.Location = new System.Drawing.Point(437, 10);
            this.SletKnap.Name = "SletKnap";
            this.SletKnap.Size = new System.Drawing.Size(129, 33);
            this.SletKnap.TabIndex = 1;
            this.SletKnap.Text = "Slet";
            this.SletKnap.UseVisualStyleBackColor = true;
            this.SletKnap.Click += new System.EventHandler(this.SletKnap_Click);
            // 
            // GemKnap
            // 
            this.GemKnap.Location = new System.Drawing.Point(6, 10);
            this.GemKnap.Name = "GemKnap";
            this.GemKnap.Size = new System.Drawing.Size(130, 33);
            this.GemKnap.TabIndex = 0;
            this.GemKnap.Text = "Gem";
            this.GemKnap.UseVisualStyleBackColor = true;
            this.GemKnap.Click += new System.EventHandler(this.GemKnap_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fornavnDataGridViewTextBoxColumn,
            this.efternavnDataGridViewTextBoxColumn,
            this.mobilDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.byDataGridViewTextBoxColumn,
            this.postNrDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.kundeIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kundeInfoNyeNyeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(706, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // fornavnDataGridViewTextBoxColumn
            // 
            this.fornavnDataGridViewTextBoxColumn.DataPropertyName = "Fornavn";
            this.fornavnDataGridViewTextBoxColumn.HeaderText = "Fornavn";
            this.fornavnDataGridViewTextBoxColumn.Name = "fornavnDataGridViewTextBoxColumn";
            // 
            // efternavnDataGridViewTextBoxColumn
            // 
            this.efternavnDataGridViewTextBoxColumn.DataPropertyName = "Efternavn";
            this.efternavnDataGridViewTextBoxColumn.HeaderText = "Efternavn";
            this.efternavnDataGridViewTextBoxColumn.Name = "efternavnDataGridViewTextBoxColumn";
            // 
            // mobilDataGridViewTextBoxColumn
            // 
            this.mobilDataGridViewTextBoxColumn.DataPropertyName = "Mobil";
            this.mobilDataGridViewTextBoxColumn.HeaderText = "Mobil";
            this.mobilDataGridViewTextBoxColumn.Name = "mobilDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // byDataGridViewTextBoxColumn
            // 
            this.byDataGridViewTextBoxColumn.DataPropertyName = "By";
            this.byDataGridViewTextBoxColumn.HeaderText = "By";
            this.byDataGridViewTextBoxColumn.Name = "byDataGridViewTextBoxColumn";
            // 
            // postNrDataGridViewTextBoxColumn
            // 
            this.postNrDataGridViewTextBoxColumn.DataPropertyName = "PostNr";
            this.postNrDataGridViewTextBoxColumn.HeaderText = "PostNr";
            this.postNrDataGridViewTextBoxColumn.Name = "postNrDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // kundeIDDataGridViewTextBoxColumn
            // 
            this.kundeIDDataGridViewTextBoxColumn.DataPropertyName = "KundeID";
            this.kundeIDDataGridViewTextBoxColumn.HeaderText = "KundeID";
            this.kundeIDDataGridViewTextBoxColumn.Name = "kundeIDDataGridViewTextBoxColumn";
            this.kundeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kundeInfoNyeNyeBindingSource
            // 
            this.kundeInfoNyeNyeBindingSource.DataMember = "KundeInfoNyeNye";
            this.kundeInfoNyeNyeBindingSource.DataSource = this.projektcaseDBDataSet2;
            // 
            // projektcaseDBDataSet2
            // 
            this.projektcaseDBDataSet2.DataSetName = "ProjektcaseDBDataSet2";
            this.projektcaseDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kundeInfoNyeBindingSource
            // 
            this.kundeInfoNyeBindingSource.DataMember = "KundeInfoNye";
            this.kundeInfoNyeBindingSource.DataSource = this.projektcaseDBDataSet1;
            // 
            // projektcaseDBDataSet1
            // 
            this.projektcaseDBDataSet1.DataSetName = "ProjektcaseDBDataSet1";
            this.projektcaseDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kundeInfoBindingSource
            // 
            this.kundeInfoBindingSource.DataMember = "KundeInfo";
            this.kundeInfoBindingSource.DataSource = this.projektcaseDBDataSet;
            // 
            // projektcaseDBDataSet
            // 
            this.projektcaseDBDataSet.DataSetName = "ProjektcaseDBDataSet";
            this.projektcaseDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kundeInfoTableAdapter
            // 
            this.kundeInfoTableAdapter.ClearBeforeFill = true;
            // 
            // kundeInfoNyeTableAdapter
            // 
            this.kundeInfoNyeTableAdapter.ClearBeforeFill = true;
            // 
            // kundeInfoNyeNyeTableAdapter
            // 
            this.kundeInfoNyeNyeTableAdapter.ClearBeforeFill = true;
            // 
            // KundeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 417);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KundeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KundeInfo";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeInfoNyeNyeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektcaseDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeInfoNyeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektcaseDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektcaseDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Mnr;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox EF;
        private System.Windows.Forms.TextBox FN;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Adresse;
        private System.Windows.Forms.Label PostNr;
        private System.Windows.Forms.Label By;
        private System.Windows.Forms.Label Mobil;
        private System.Windows.Forms.Label Efternavn;
        private System.Windows.Forms.Label Fornavn;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox Pnr;
        private System.Windows.Forms.TextBox bby;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SletKnap;
        private System.Windows.Forms.Button GemKnap;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button TilbageKnap;
        private System.Windows.Forms.Button Vis;
        private ProjektcaseDBDataSet projektcaseDBDataSet;
        private System.Windows.Forms.BindingSource kundeInfoBindingSource;
        private ProjektcaseDBDataSetTableAdapters.KundeInfoTableAdapter kundeInfoTableAdapter;
        private System.Windows.Forms.Button opdatering;
        private ProjektcaseDBDataSet1 projektcaseDBDataSet1;
        private System.Windows.Forms.BindingSource kundeInfoNyeBindingSource;
        private ProjektcaseDBDataSet1TableAdapters.KundeInfoNyeTableAdapter kundeInfoNyeTableAdapter;
        private System.Windows.Forms.Label KundeID;
        private ProjektcaseDBDataSet2 projektcaseDBDataSet2;
        private System.Windows.Forms.BindingSource kundeInfoNyeNyeBindingSource;
        private ProjektcaseDBDataSet2TableAdapters.KundeInfoNyeNyeTableAdapter kundeInfoNyeNyeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efternavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn byDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kundeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label KID;
    }
}
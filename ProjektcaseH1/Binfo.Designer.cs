namespace ProjektcaseH1
{
    partial class Binfo
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
            this.KundeID = new System.Windows.Forms.Label();
            this.KundeIDboks = new System.Windows.Forms.TextBox();
            this.Oprettelsesdato = new System.Windows.Forms.Label();
            this.Modelboks = new System.Windows.Forms.TextBox();
            this.Brændstoftypeboks = new System.Windows.Forms.TextBox();
            this.RegNrboks = new System.Windows.Forms.TextBox();
            this.Årgangboks = new System.Windows.Forms.TextBox();
            this.Mærkeboks = new System.Windows.Forms.TextBox();
            this.Ejereboks = new System.Windows.Forms.TextBox();
            this.Brændstoftype = new System.Windows.Forms.Label();
            this.RegNr = new System.Windows.Forms.Label();
            this.Årgang = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.Mærke = new System.Windows.Forms.Label();
            this.Ejere = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OpdateringKnap = new System.Windows.Forms.Button();
            this.VisKnap = new System.Windows.Forms.Button();
            this.TilbageKnap = new System.Windows.Forms.Button();
            this.SletKnap = new System.Windows.Forms.Button();
            this.GemKnap = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ejereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mærkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.årgangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brændstoftypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oprettelsesdatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projektcaseDBDataSet4 = new ProjektcaseH1.ProjektcaseDBDataSet4();
            this.projektcaseDBDataSet3 = new ProjektcaseH1.ProjektcaseDBDataSet3();
            this.bilInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bilInfoTableAdapter = new ProjektcaseH1.ProjektcaseDBDataSet3TableAdapters.BilInfoTableAdapter();
            this.bilInfoTableAdapter1 = new ProjektcaseH1.ProjektcaseDBDataSet4TableAdapters.BilInfoTableAdapter();
            this.datoboks = new System.Windows.Forms.DateTimePicker();
            this.projektcaseDBDataSet5 = new ProjektcaseH1.ProjektcaseDBDataSet5();
            this.bilInfoNyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bilInfoNyTableAdapter = new ProjektcaseH1.ProjektcaseDBDataSet5TableAdapters.BilInfoNyTableAdapter();
            this.projektcaseDBDataSet6 = new ProjektcaseH1.ProjektcaseDBDataSet6();
            this.bilInfoNyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bilInfoNyTableAdapter1 = new ProjektcaseH1.ProjektcaseDBDataSet6TableAdapters.BilInfoNyTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektcaseDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektcaseDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektcaseDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilInfoNyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektcaseDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilInfoNyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.datoboks);
            this.groupBox1.Controls.Add(this.KundeID);
            this.groupBox1.Controls.Add(this.KundeIDboks);
            this.groupBox1.Controls.Add(this.Oprettelsesdato);
            this.groupBox1.Controls.Add(this.Modelboks);
            this.groupBox1.Controls.Add(this.Brændstoftypeboks);
            this.groupBox1.Controls.Add(this.RegNrboks);
            this.groupBox1.Controls.Add(this.Årgangboks);
            this.groupBox1.Controls.Add(this.Mærkeboks);
            this.groupBox1.Controls.Add(this.Ejereboks);
            this.groupBox1.Controls.Add(this.Brændstoftype);
            this.groupBox1.Controls.Add(this.RegNr);
            this.groupBox1.Controls.Add(this.Årgang);
            this.groupBox1.Controls.Add(this.Model);
            this.groupBox1.Controls.Add(this.Mærke);
            this.groupBox1.Controls.Add(this.Ejere);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 173);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bil info";
            // 
            // KundeID
            // 
            this.KundeID.AutoSize = true;
            this.KundeID.Location = new System.Drawing.Point(363, 121);
            this.KundeID.Name = "KundeID";
            this.KundeID.Size = new System.Drawing.Size(49, 13);
            this.KundeID.TabIndex = 7;
            this.KundeID.Text = "KundeID";
            // 
            // KundeIDboks
            // 
            this.KundeIDboks.Location = new System.Drawing.Point(450, 118);
            this.KundeIDboks.Name = "KundeIDboks";
            this.KundeIDboks.Size = new System.Drawing.Size(100, 20);
            this.KundeIDboks.TabIndex = 15;
            // 
            // Oprettelsesdato
            // 
            this.Oprettelsesdato.AutoSize = true;
            this.Oprettelsesdato.Location = new System.Drawing.Point(363, 95);
            this.Oprettelsesdato.Name = "Oprettelsesdato";
            this.Oprettelsesdato.Size = new System.Drawing.Size(81, 13);
            this.Oprettelsesdato.TabIndex = 6;
            this.Oprettelsesdato.Text = "Oprettelsesdato";
            // 
            // Modelboks
            // 
            this.Modelboks.Location = new System.Drawing.Point(100, 92);
            this.Modelboks.Name = "Modelboks";
            this.Modelboks.Size = new System.Drawing.Size(100, 20);
            this.Modelboks.TabIndex = 10;
            // 
            // Brændstoftypeboks
            // 
            this.Brændstoftypeboks.Location = new System.Drawing.Point(450, 59);
            this.Brændstoftypeboks.Name = "Brændstoftypeboks";
            this.Brændstoftypeboks.Size = new System.Drawing.Size(100, 20);
            this.Brændstoftypeboks.TabIndex = 13;
            // 
            // RegNrboks
            // 
            this.RegNrboks.Location = new System.Drawing.Point(450, 26);
            this.RegNrboks.Name = "RegNrboks";
            this.RegNrboks.Size = new System.Drawing.Size(100, 20);
            this.RegNrboks.TabIndex = 12;
            // 
            // Årgangboks
            // 
            this.Årgangboks.Location = new System.Drawing.Point(100, 118);
            this.Årgangboks.Name = "Årgangboks";
            this.Årgangboks.Size = new System.Drawing.Size(100, 20);
            this.Årgangboks.TabIndex = 11;
            // 
            // Mærkeboks
            // 
            this.Mærkeboks.Location = new System.Drawing.Point(100, 62);
            this.Mærkeboks.Name = "Mærkeboks";
            this.Mærkeboks.Size = new System.Drawing.Size(100, 20);
            this.Mærkeboks.TabIndex = 9;
            // 
            // Ejereboks
            // 
            this.Ejereboks.Location = new System.Drawing.Point(100, 26);
            this.Ejereboks.Name = "Ejereboks";
            this.Ejereboks.Size = new System.Drawing.Size(100, 20);
            this.Ejereboks.TabIndex = 8;
            // 
            // Brændstoftype
            // 
            this.Brændstoftype.AutoSize = true;
            this.Brændstoftype.Location = new System.Drawing.Point(363, 62);
            this.Brændstoftype.Name = "Brændstoftype";
            this.Brændstoftype.Size = new System.Drawing.Size(76, 13);
            this.Brændstoftype.TabIndex = 5;
            this.Brændstoftype.Text = "Brændstoftype";
            // 
            // RegNr
            // 
            this.RegNr.AutoSize = true;
            this.RegNr.Location = new System.Drawing.Point(363, 29);
            this.RegNr.Name = "RegNr";
            this.RegNr.Size = new System.Drawing.Size(38, 13);
            this.RegNr.TabIndex = 4;
            this.RegNr.Text = "RegNr";
            // 
            // Årgang
            // 
            this.Årgang.AutoSize = true;
            this.Årgang.Location = new System.Drawing.Point(25, 121);
            this.Årgang.Name = "Årgang";
            this.Årgang.Size = new System.Drawing.Size(41, 13);
            this.Årgang.TabIndex = 3;
            this.Årgang.Text = "Årgang";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(25, 91);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(36, 13);
            this.Model.TabIndex = 2;
            this.Model.Text = "Model";
            // 
            // Mærke
            // 
            this.Mærke.AutoSize = true;
            this.Mærke.Location = new System.Drawing.Point(25, 62);
            this.Mærke.Name = "Mærke";
            this.Mærke.Size = new System.Drawing.Size(41, 13);
            this.Mærke.TabIndex = 1;
            this.Mærke.Text = "Mærke";
            // 
            // Ejere
            // 
            this.Ejere.AutoSize = true;
            this.Ejere.Location = new System.Drawing.Point(25, 29);
            this.Ejere.Name = "Ejere";
            this.Ejere.Size = new System.Drawing.Size(31, 13);
            this.Ejere.TabIndex = 0;
            this.Ejere.Text = "Ejere";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OpdateringKnap);
            this.groupBox2.Controls.Add(this.VisKnap);
            this.groupBox2.Controls.Add(this.TilbageKnap);
            this.groupBox2.Controls.Add(this.SletKnap);
            this.groupBox2.Controls.Add(this.GemKnap);
            this.groupBox2.Location = new System.Drawing.Point(33, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 49);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // OpdateringKnap
            // 
            this.OpdateringKnap.Location = new System.Drawing.Point(142, 10);
            this.OpdateringKnap.Name = "OpdateringKnap";
            this.OpdateringKnap.Size = new System.Drawing.Size(129, 33);
            this.OpdateringKnap.TabIndex = 1;
            this.OpdateringKnap.Text = "Opdatering";
            this.OpdateringKnap.UseVisualStyleBackColor = true;
            this.OpdateringKnap.Click += new System.EventHandler(this.OpdateringKnap_Click);
            // 
            // VisKnap
            // 
            this.VisKnap.Location = new System.Drawing.Point(279, 10);
            this.VisKnap.Name = "VisKnap";
            this.VisKnap.Size = new System.Drawing.Size(129, 33);
            this.VisKnap.TabIndex = 2;
            this.VisKnap.Text = "Vis";
            this.VisKnap.UseVisualStyleBackColor = true;
            this.VisKnap.Click += new System.EventHandler(this.VisKnap_Click);
            // 
            // TilbageKnap
            // 
            this.TilbageKnap.Location = new System.Drawing.Point(572, 10);
            this.TilbageKnap.Name = "TilbageKnap";
            this.TilbageKnap.Size = new System.Drawing.Size(128, 33);
            this.TilbageKnap.TabIndex = 4;
            this.TilbageKnap.Text = "Tilbage";
            this.TilbageKnap.UseVisualStyleBackColor = true;
            this.TilbageKnap.Click += new System.EventHandler(this.TilbageKnap_Click);
            // 
            // SletKnap
            // 
            this.SletKnap.Location = new System.Drawing.Point(437, 10);
            this.SletKnap.Name = "SletKnap";
            this.SletKnap.Size = new System.Drawing.Size(129, 33);
            this.SletKnap.TabIndex = 3;
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
            this.ejereDataGridViewTextBoxColumn,
            this.mærkeDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.årgangDataGridViewTextBoxColumn,
            this.regNrDataGridViewTextBoxColumn,
            this.brændstoftypeDataGridViewTextBoxColumn,
            this.oprettelsesdatoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.bilInfoNyBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(33, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(706, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ejereDataGridViewTextBoxColumn
            // 
            this.ejereDataGridViewTextBoxColumn.DataPropertyName = "Ejere";
            this.ejereDataGridViewTextBoxColumn.HeaderText = "Ejere";
            this.ejereDataGridViewTextBoxColumn.Name = "ejereDataGridViewTextBoxColumn";
            // 
            // mærkeDataGridViewTextBoxColumn
            // 
            this.mærkeDataGridViewTextBoxColumn.DataPropertyName = "Mærke";
            this.mærkeDataGridViewTextBoxColumn.HeaderText = "Mærke";
            this.mærkeDataGridViewTextBoxColumn.Name = "mærkeDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // årgangDataGridViewTextBoxColumn
            // 
            this.årgangDataGridViewTextBoxColumn.DataPropertyName = "Årgang";
            this.årgangDataGridViewTextBoxColumn.HeaderText = "Årgang";
            this.årgangDataGridViewTextBoxColumn.Name = "årgangDataGridViewTextBoxColumn";
            // 
            // regNrDataGridViewTextBoxColumn
            // 
            this.regNrDataGridViewTextBoxColumn.DataPropertyName = "RegNr";
            this.regNrDataGridViewTextBoxColumn.HeaderText = "RegNr";
            this.regNrDataGridViewTextBoxColumn.Name = "regNrDataGridViewTextBoxColumn";
            // 
            // brændstoftypeDataGridViewTextBoxColumn
            // 
            this.brændstoftypeDataGridViewTextBoxColumn.DataPropertyName = "Brændstoftype";
            this.brændstoftypeDataGridViewTextBoxColumn.HeaderText = "Brændstoftype";
            this.brændstoftypeDataGridViewTextBoxColumn.Name = "brændstoftypeDataGridViewTextBoxColumn";
            // 
            // oprettelsesdatoDataGridViewTextBoxColumn
            // 
            this.oprettelsesdatoDataGridViewTextBoxColumn.DataPropertyName = "Oprettelsesdato";
            this.oprettelsesdatoDataGridViewTextBoxColumn.HeaderText = "Oprettelsesdato";
            this.oprettelsesdatoDataGridViewTextBoxColumn.Name = "oprettelsesdatoDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "KundeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "KundeID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // bilInfoBindingSource1
            // 
            this.bilInfoBindingSource1.DataMember = "BilInfo";
            this.bilInfoBindingSource1.DataSource = this.projektcaseDBDataSet4;
            // 
            // projektcaseDBDataSet4
            // 
            this.projektcaseDBDataSet4.DataSetName = "ProjektcaseDBDataSet4";
            this.projektcaseDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projektcaseDBDataSet3
            // 
            this.projektcaseDBDataSet3.DataSetName = "ProjektcaseDBDataSet3";
            this.projektcaseDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bilInfoBindingSource
            // 
            this.bilInfoBindingSource.DataMember = "BilInfo";
            this.bilInfoBindingSource.DataSource = this.projektcaseDBDataSet3;
            // 
            // bilInfoTableAdapter
            // 
            this.bilInfoTableAdapter.ClearBeforeFill = true;
            // 
            // bilInfoTableAdapter1
            // 
            this.bilInfoTableAdapter1.ClearBeforeFill = true;
            // 
            // datoboks
            // 
            this.datoboks.CustomFormat = "dd-MM-yyyy";
            this.datoboks.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datoboks.Location = new System.Drawing.Point(450, 91);
            this.datoboks.Name = "datoboks";
            this.datoboks.Size = new System.Drawing.Size(100, 20);
            this.datoboks.TabIndex = 14;
            this.datoboks.ValueChanged += new System.EventHandler(this.datoboks_ValueChanged);
            // 
            // projektcaseDBDataSet5
            // 
            this.projektcaseDBDataSet5.DataSetName = "ProjektcaseDBDataSet5";
            this.projektcaseDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bilInfoNyBindingSource
            // 
            this.bilInfoNyBindingSource.DataMember = "BilInfoNy";
            this.bilInfoNyBindingSource.DataSource = this.projektcaseDBDataSet5;
            // 
            // bilInfoNyTableAdapter
            // 
            this.bilInfoNyTableAdapter.ClearBeforeFill = true;
            // 
            // projektcaseDBDataSet6
            // 
            this.projektcaseDBDataSet6.DataSetName = "ProjektcaseDBDataSet6";
            this.projektcaseDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bilInfoNyBindingSource1
            // 
            this.bilInfoNyBindingSource1.DataMember = "BilInfoNy";
            this.bilInfoNyBindingSource1.DataSource = this.projektcaseDBDataSet6;
            // 
            // bilInfoNyTableAdapter1
            // 
            this.bilInfoNyTableAdapter1.ClearBeforeFill = true;
            // 
            // Binfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 430);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Binfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binfo";
            this.Load += new System.EventHandler(this.Binfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektcaseDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektcaseDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektcaseDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilInfoNyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektcaseDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilInfoNyBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Modelboks;
        private System.Windows.Forms.TextBox Brændstoftypeboks;
        private System.Windows.Forms.TextBox RegNrboks;
        private System.Windows.Forms.TextBox Årgangboks;
        private System.Windows.Forms.TextBox Mærkeboks;
        private System.Windows.Forms.TextBox Ejereboks;
        private System.Windows.Forms.Label Brændstoftype;
        private System.Windows.Forms.Label RegNr;
        private System.Windows.Forms.Label Årgang;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label Mærke;
        private System.Windows.Forms.Label Ejere;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button OpdateringKnap;
        private System.Windows.Forms.Button VisKnap;
        private System.Windows.Forms.Button TilbageKnap;
        private System.Windows.Forms.Button SletKnap;
        private System.Windows.Forms.Button GemKnap;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Oprettelsesdato;
        private System.Windows.Forms.Label KundeID;
        private System.Windows.Forms.TextBox KundeIDboks;
        private ProjektcaseDBDataSet3 projektcaseDBDataSet3;
        private System.Windows.Forms.BindingSource bilInfoBindingSource;
        private ProjektcaseDBDataSet3TableAdapters.BilInfoTableAdapter bilInfoTableAdapter;
        private ProjektcaseDBDataSet4 projektcaseDBDataSet4;
        private System.Windows.Forms.BindingSource bilInfoBindingSource1;
        private ProjektcaseDBDataSet4TableAdapters.BilInfoTableAdapter bilInfoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ejereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mærkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn årgangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brændstoftypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oprettelsesdatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DateTimePicker datoboks;
        private ProjektcaseDBDataSet5 projektcaseDBDataSet5;
        private System.Windows.Forms.BindingSource bilInfoNyBindingSource;
        private ProjektcaseDBDataSet5TableAdapters.BilInfoNyTableAdapter bilInfoNyTableAdapter;
        private ProjektcaseDBDataSet6 projektcaseDBDataSet6;
        private System.Windows.Forms.BindingSource bilInfoNyBindingSource1;
        private ProjektcaseDBDataSet6TableAdapters.BilInfoNyTableAdapter bilInfoNyTableAdapter1;
    }
}
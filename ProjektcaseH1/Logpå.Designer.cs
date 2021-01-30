namespace ProjektcaseH1
{
    partial class Logpå
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
            this.Brugernavn = new System.Windows.Forms.Label();
            this.Adgangskode = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.Annullere = new System.Windows.Forms.Button();
            this.Adgangskodeboks = new System.Windows.Forms.TextBox();
            this.Brugernavnboks = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Brugernavn
            // 
            this.Brugernavn.AutoSize = true;
            this.Brugernavn.Location = new System.Drawing.Point(30, 35);
            this.Brugernavn.Name = "Brugernavn";
            this.Brugernavn.Size = new System.Drawing.Size(62, 13);
            this.Brugernavn.TabIndex = 0;
            this.Brugernavn.Text = "Brugernavn";
            // 
            // Adgangskode
            // 
            this.Adgangskode.AutoSize = true;
            this.Adgangskode.Location = new System.Drawing.Point(30, 66);
            this.Adgangskode.Name = "Adgangskode";
            this.Adgangskode.Size = new System.Drawing.Size(73, 13);
            this.Adgangskode.TabIndex = 1;
            this.Adgangskode.Text = "Adgangskode";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(33, 98);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 2;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Annullere
            // 
            this.Annullere.Location = new System.Drawing.Point(163, 98);
            this.Annullere.Name = "Annullere";
            this.Annullere.Size = new System.Drawing.Size(75, 23);
            this.Annullere.TabIndex = 3;
            this.Annullere.Text = "Annullere";
            this.Annullere.UseVisualStyleBackColor = true;
            this.Annullere.Click += new System.EventHandler(this.Annullere_Click);
            // 
            // Adgangskodeboks
            // 
            this.Adgangskodeboks.Location = new System.Drawing.Point(138, 63);
            this.Adgangskodeboks.Name = "Adgangskodeboks";
            this.Adgangskodeboks.Size = new System.Drawing.Size(100, 20);
            this.Adgangskodeboks.TabIndex = 4;
            // 
            // Brugernavnboks
            // 
            this.Brugernavnboks.Location = new System.Drawing.Point(138, 32);
            this.Brugernavnboks.Name = "Brugernavnboks";
            this.Brugernavnboks.Size = new System.Drawing.Size(100, 20);
            this.Brugernavnboks.TabIndex = 5;
            // 
            // Logpå
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 141);
            this.Controls.Add(this.Brugernavnboks);
            this.Controls.Add(this.Adgangskodeboks);
            this.Controls.Add(this.Annullere);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Adgangskode);
            this.Controls.Add(this.Brugernavn);
            this.Name = "Logpå";
            this.Text = "Logpå";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Brugernavn;
        private System.Windows.Forms.Label Adgangskode;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Annullere;
        private System.Windows.Forms.TextBox Adgangskodeboks;
        private System.Windows.Forms.TextBox Brugernavnboks;
    }
}
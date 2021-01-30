namespace ProjektcaseH1
{
    partial class HovedMenu
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
            this.Kundeinfo = new System.Windows.Forms.Button();
            this.Bilinfo = new System.Windows.Forms.Button();
            this.AfslutKnap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Kundeinfo
            // 
            this.Kundeinfo.Location = new System.Drawing.Point(78, 44);
            this.Kundeinfo.Name = "Kundeinfo";
            this.Kundeinfo.Size = new System.Drawing.Size(75, 23);
            this.Kundeinfo.TabIndex = 0;
            this.Kundeinfo.Text = "Kunde info";
            this.Kundeinfo.UseVisualStyleBackColor = true;
            this.Kundeinfo.Click += new System.EventHandler(this.Kundeinfo_Click);
            // 
            // Bilinfo
            // 
            this.Bilinfo.Location = new System.Drawing.Point(199, 44);
            this.Bilinfo.Name = "Bilinfo";
            this.Bilinfo.Size = new System.Drawing.Size(75, 23);
            this.Bilinfo.TabIndex = 1;
            this.Bilinfo.Text = "Bil info";
            this.Bilinfo.UseVisualStyleBackColor = true;
            this.Bilinfo.Click += new System.EventHandler(this.Bilinfo_Click);
            // 
            // AfslutKnap
            // 
            this.AfslutKnap.Location = new System.Drawing.Point(141, 87);
            this.AfslutKnap.Name = "AfslutKnap";
            this.AfslutKnap.Size = new System.Drawing.Size(75, 23);
            this.AfslutKnap.TabIndex = 2;
            this.AfslutKnap.Text = "Afslut";
            this.AfslutKnap.UseVisualStyleBackColor = true;
            this.AfslutKnap.Click += new System.EventHandler(this.AfslutKnap_Click);
            // 
            // HovedMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 194);
            this.Controls.Add(this.AfslutKnap);
            this.Controls.Add(this.Bilinfo);
            this.Controls.Add(this.Kundeinfo);
            this.Name = "HovedMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HovedMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Kundeinfo;
        private System.Windows.Forms.Button Bilinfo;
        private System.Windows.Forms.Button AfslutKnap;
    }
}


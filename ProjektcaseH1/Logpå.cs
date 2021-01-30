using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProjektcaseH1
{
    public partial class Logpå : Form
    {
        public Logpå()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source = DESKTOP - M8A87VO\BUTTERFLY; Initial Catalog = ProjektcaseDB; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter ("Select Count(*) from Login where Brugernavn ='" + Brugernavnboks.Text + "' and Adgangskode = '" + Adgangskodeboks.Text + "' ",sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count ==1)
            {
                this.Hide();
                HovedMenu Hmenu = new HovedMenu();
                Hmenu.Show();
            }
            else
            {
                MessageBox.Show("Check din brugernavn og din adgangskode");
            }

            HovedMenu HovedM = new HovedMenu();
            HovedM.Tag = this;
            HovedM.Show(this);
            Hide();
        }

        private void Annullere_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

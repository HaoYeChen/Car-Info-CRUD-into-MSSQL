using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //database forbindelser

namespace ProjektcaseH1
{
    public partial class Binfo : Form
    {
        public Binfo()
        {
            InitializeComponent();
        }

        private void Binfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projektcaseDBDataSet6.BilInfoNy' table. You can move, or remove it, as needed.
            this.bilInfoNyTableAdapter1.Fill(this.projektcaseDBDataSet6.BilInfoNy);
            
            
            

        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M8A87VO\BUTTERFLY;Initial Catalog=ProjektcaseDB;Integrated Security=True");

        private void GemKnap_Click(object sender, EventArgs e)
        {
            try //den prøver koden
            {
                con.Open();
                String query = "INSERT INTO BilInfoNy (Ejere,Mærke,Model,Årgang,RegNr,Brændstoftype,Oprettelsesdato,KundeID) Values('" + Ejereboks.Text + "','" + Mærkeboks.Text + "','" + Modelboks.Text + "','" + Årgangboks.Text + "','" + RegNrboks.Text + "','" + Brændstoftypeboks.Text + "','" + datoboks.Text + "','" + Convert.ToInt32(KundeIDboks.Text) + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succes!");
            }
            catch (Exception) // den fanger fejlen
            {
                MessageBox.Show("Fejl! Du kan ikke indtast den sammen RegNr igen");
                
            }
            

        }

        private void VisKnap_Click(object sender, EventArgs e) //viser det som er gemt
        {
            con.Open();
            String query2 = "Select * from BilInfoNy";
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
            DataTable dt = new DataTable();
            sda2.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void OpdateringKnap_Click(object sender, EventArgs e) //opdateringer data
        {
            con.Open();
            string query3 = "UPDATE BilInfoNy SET Ejere ='" + Ejereboks.Text + "',Mærke='" + Mærkeboks.Text + "',Model='" + Modelboks.Text + "',Årgang='" + Årgangboks.Text + "',RegNr='" + RegNrboks.Text + "',Brændstoftype='" + Brændstoftypeboks.Text + "',Oprettelsesdato=convert(date,'" + datoboks.Text + "',105) WHERE KundeID= " + Convert.ToInt32(KundeIDboks.Text) ;
            SqlDataAdapter sda3 = new SqlDataAdapter(query3, con);
            sda3.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Opdatering succes!");
        }
        
        private void SletKnap_Click(object sender, EventArgs e) //sletter data
        {
            con.Open();
            String query4 = "DELETE FROM BilInfoNy WHERE Ejere ='" + Ejereboks.Text + "'and Mærke='" + Mærkeboks.Text + "'and Model='" + Modelboks.Text + "'and Årgang='" + Årgangboks.Text + "'and RegNr='" + RegNrboks.Text + "'and Brændstoftype='" + Brændstoftypeboks.Text + "'and Oprettelsesdato='" + datoboks.Text +"'and KundeID=" + Convert.ToInt32(KundeIDboks.Text);
            SqlDataAdapter sda4 = new SqlDataAdapter(query4, con);
            sda4.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Slettet!");
        }

        private void TilbageKnap_Click(object sender, EventArgs e) // Tilbage til HovedMenu
        {
            HovedMenu TilbageTilMain = new HovedMenu();
            TilbageTilMain.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // 2x klik = viser data
        {
            Ejereboks.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Mærkeboks.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Modelboks.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Årgangboks.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            RegNrboks.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Brændstoftypeboks.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            datoboks.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            KundeIDboks.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void datoboks_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

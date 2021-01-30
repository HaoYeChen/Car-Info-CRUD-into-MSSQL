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
    public partial class KundeInfo : Form
    {
        public KundeInfo()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projektcaseDBDataSet2.KundeInfoNyeNye' table. You can move, or remove it, as needed.
            this.kundeInfoNyeNyeTableAdapter.Fill(this.projektcaseDBDataSet2.KundeInfoNyeNye);
            
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TilbageKnap_Click(object sender, EventArgs e) //Sender dig tilbage til hovedmenu
        {
            HovedMenu TilbageTilMain = new HovedMenu();
            TilbageTilMain.Show();
            this.Close();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M8A87VO\BUTTERFLY;Initial Catalog=ProjektcaseDB;Integrated Security=True");


        private void GemKnap_Click(object sender, EventArgs e) //Gemer data
        {
            con.Open();
            String query = "INSERT INTO KundeInfoNyeNye (Fornavn,Efternavn,Mobil,[By],PostNr,Adresse,Email) Values('"+FN.Text+"','" + EF.Text+ "','" + Mnr.Text + "','" + bby.Text + "','" + Pnr.Text + "','" + address.Text + "','" + mail.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succes!");
        }

        private void Vis_Click(object sender, EventArgs e) //viser det som er gemt
        {
            con.Open();
            String query2 = "Select * from KundeInfoNyeNye";
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
            DataTable dt = new DataTable();
            sda2.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void opdatering_Click(object sender, EventArgs e) //opdateringer data
        {
            con.Open();
            string query3 = "UPDATE KundeInfoNyeNye SET Fornavn ='" + FN.Text + "',Efternavn='" + EF.Text + "',Mobil='" + Mnr.Text + "',[By]='" + bby.Text + "',Postnr='" + Pnr.Text + "',Adresse='" + address.Text + "',Email='" + mail.Text +"'WHERE KundeID= '"+KundeID.Text+ "'";
            SqlDataAdapter sda3 = new SqlDataAdapter(query3, con);
            sda3.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Opdatering succes!");
        }

        private void SletKnap_Click(object sender, EventArgs e) //sletter data
        {
            con.Open();
            String query4= "DELETE FROM KundeInfoNyeNye WHERE Fornavn='" + FN.Text + "'and Efternavn='" + EF.Text + "'and Mobil='" + Mnr.Text + "'and [By]='" + bby.Text + "'and Postnr='" + Pnr.Text + "'and Adresse='" + address.Text + "'and Email='" + mail.Text + "'and KundeID="+Convert.ToInt32 (KundeID.Text) ;
            SqlDataAdapter sda4 = new SqlDataAdapter(query4, con);
            sda4.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Slettet!");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e) // 2x klik = viser data
        {
            FN.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            EF.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Mnr.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            mail.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            bby.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Pnr.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            address.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            KundeID.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }


    }
}

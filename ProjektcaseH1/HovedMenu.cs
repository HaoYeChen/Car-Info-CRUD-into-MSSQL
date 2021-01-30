using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektcaseH1
{
    public partial class HovedMenu : Form
    {
        public HovedMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Kundeinfo_Click(object sender, EventArgs e) //Sender dig til kundeinfo
        {
            KundeInfo Kinfo = new KundeInfo();
            Kinfo.Tag = this;
            Kinfo.Show(this);
            Hide();
        }

        private void Bilinfo_Click(object sender, EventArgs e) //Sender dig til bilinfo
        {
            Binfo bInfo = new Binfo();
            bInfo.Tag = this;
            bInfo.Show(this);
            Hide();
        }

        private void AfslutKnap_Click(object sender, EventArgs e) // slukker
        {
            this.Close();
        }

       
    }
}

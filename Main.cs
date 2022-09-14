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
using System.Configuration;


namespace Digiball
{

    public partial class Main : Form
    {
        public static string ManagerName = "";
        public static string TeamId = "";
        public static string ManagerSurname = "";
        public static string ManagerAge = "";
        public static string TeamName = "";
        public static string StadiumName = "";
        public static string EstDate = "";
        public static string TotalStaff = "";
        public static string Budget = "";
        public static string Country = "";
        public static string Logo = "";

        public Main()
        {
            InitializeComponent();

        }

        private void Main_Load(object sender, EventArgs e)
        {

            teamnamelbl.Text = TeamName;
            estdatelbl.Text = EstDate;
            countrylbl.Text = Country;
            teamlogopic.Image = Image.FromFile(Logo.ToString());

<<<<<<< HEAD



            PlayerInMain pim=new PlayerInMain();
=======
            PlayerInMain pim=new PlayerInMain();
            


>>>>>>> fd53677075a9f715ca932c6bb62448e4bb2c0061

            foreach (KeyValuePair<int, string[]> player in Login.players)
            {
                for (int x = 1; x <= Login.players.Values.Count; x++)
                {
                    pim = new PlayerInMain();
                }

                
                pim.PlayerNameSurname = player.Value[1] + " " + player.Value[2];
                pim.PlayerAge = player.Value[3];
                pim.PlayerPic = player.Value[9];
                pim.TeamLogo = Logo;
                pim.Flag = player.Value[10];
                pim.CountryName = player.Value[0];
                pim.Position = player.Value[7];
                flowLayoutPanel1.Controls.Add(pim);

            }

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void staffbtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void tacticbtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void trainingbtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void fixturebtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void clubbtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void economybtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
        }

        private void stadiumbtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
        }

        private void managerbtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
        }
    }
}

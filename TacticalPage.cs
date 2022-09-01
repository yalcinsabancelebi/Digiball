using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Digiball
{
    public partial class TacticalPage : UserControl
    {
        public TacticalPage()
        {
            InitializeComponent();
        }

        private void TacticalPage_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 1; i <= 36; i++)
            {
                var deneme = (Panel)this.Controls.Find("panel" + i, true)[0];
                deneme.BackColor = Color.FromArgb(150, Color.LightGreen);
            }
        }
        public static StaffList staffList = new StaffList();

        public void deneme()
        {

        }

        private void TacticalPage_Load(object sender, EventArgs e)
        {

            foreach (KeyValuePair<int, string[]> player in Login.players)
            {
                for (int x = 1; x <= Login.players.Values.Count; x++)
                {
                    staffList = new StaffList();
                    staffList.NameSurname = player.Value[1] + " " + player.Value[2];
                    staffList.Position = player.Value[7];
                    staffList.Role = player.Value[8];
                    staffList.PlayerPic = player.Value[9];
                    staffList.Age = player.Value[3];
                    staffList.GkAbility = player.Value[16];
                    staffList.DfAbility = player.Value[17];
                    staffList.MfAbility = player.Value[18];
                    staffList.FwAbility = player.Value[19];
                    staffList.PlayerHeight = player.Value[4];
                    staffList.PlayerWeight = player.Value[5];
                }

                stafflistmain.Controls.Add(staffList);

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            stafflistmain.Controls.SetChildIndex(staffList, 3);
            stafflistmain.ResumeLayout();
        }
    }
}
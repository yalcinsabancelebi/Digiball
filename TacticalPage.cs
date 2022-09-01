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
<<<<<<< HEAD

        }
        public static StaffList staffList = new StaffList();

=======
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


        public static List<string> ilkonbir = new List<string>();

        private void playerInField12_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void playerInField13_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void playerInField14_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void playerInField15_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void playerInField16_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void playerInField17_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void playerInField18_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            StaffList myObject = (StaffList)e.Data.GetData(e.Data.GetFormats()[0]);

            if (ilkonbir.Contains(myObject.NameSurname))
            {
                if (playerInField1.label1.Text == myObject.NameSurname)
                {
                    playerInField1.label1.Text = "";
                    playerInField1.label2.Text = "";
                    playerInField1.pictureBox1.Image = null;
                }
                if (playerInField2.label1.Text == myObject.NameSurname)
                {
                    playerInField2.label1.Text = "";
                    playerInField2.label2.Text = "";
                    playerInField2.pictureBox1.Image = null;
                }
                if (playerInField3.label1.Text == myObject.NameSurname)
                {
                    playerInField3.label1.Text = "";
                    playerInField3.label2.Text = "";
                    playerInField3.pictureBox1.Image = null;
                }
                if (playerInField4.label1.Text == myObject.NameSurname)
                {
                    playerInField4.label1.Text = "";
                    playerInField4.label2.Text = "";
                    playerInField4.pictureBox1.Image = null;
                }
                if (playerInField5.label1.Text == myObject.NameSurname)
                {
                    playerInField5.label1.Text = "";
                    playerInField5.label2.Text = "";
                    playerInField5.pictureBox1.Image = null;
                }
                if (playerInField6.label1.Text == myObject.NameSurname)
                {
                    playerInField6.label1.Text = "";
                    playerInField6.label2.Text = "";
                    playerInField6.pictureBox1.Image = null;
                }
                if (playerInField7.label1.Text == myObject.NameSurname)
                {
                    playerInField7.label1.Text = "";
                    playerInField7.label2.Text = "";
                    playerInField7.pictureBox1.Image = null;
                }
                if (playerInField8.label1.Text == myObject.NameSurname)
                {
                    playerInField8.label1.Text = "";
                    playerInField8.label2.Text = "";
                    playerInField8.pictureBox1.Image = null;
                }
                if (playerInField9.label1.Text == myObject.NameSurname)
                {
                    playerInField9.label1.Text = "";
                    playerInField9.label2.Text = "";
                    playerInField9.pictureBox1.Image = null;
                }
                if (playerInField10.label1.Text == myObject.NameSurname)
                {
                    playerInField10.label1.Text = "";
                    playerInField10.label2.Text = "";
                    playerInField10.pictureBox1.Image = null;
                }
                if (playerInField11.label1.Text == myObject.NameSurname)
                {
                    playerInField11.label1.Text = "";
                    playerInField11.label2.Text = "";
                    playerInField11.pictureBox1.Image = null;
                }
                if (playerInField12.label1.Text == myObject.NameSurname)
                {
                    playerInField12.label1.Text = "";
                    playerInField12.label2.Text = "";
                    playerInField12.pictureBox1.Image = null;
                }
                if (playerInField13.label1.Text == myObject.NameSurname)
                {
                    playerInField13.label1.Text = "";
                    playerInField13.label2.Text = "";
                    playerInField13.pictureBox1.Image = null;
                }
                if (playerInField14.label1.Text == myObject.NameSurname)
                {
                    playerInField14.label1.Text = "";
                    playerInField14.label2.Text = "";
                    playerInField14.pictureBox1.Image = null;
                }
                if (playerInField15.label1.Text == myObject.NameSurname)
                {
                    playerInField15.label1.Text = "";
                    playerInField15.label2.Text = "";
                    playerInField15.pictureBox1.Image = null;
                }
                if (playerInField16.label1.Text == myObject.NameSurname)
                {
                    playerInField16.label1.Text = "";
                    playerInField16.label2.Text = "";
                    playerInField16.pictureBox1.Image = null;
                }
                if (playerInField17.label1.Text == myObject.NameSurname)
                {
                    playerInField17.label1.Text = "";
                    playerInField17.label2.Text = "";
                    playerInField17.pictureBox1.Image = null;
                }
                if (playerInField18.label1.Text == myObject.NameSurname)
                {
                    playerInField18.label1.Text = "";
                    playerInField18.label2.Text = "";
                    playerInField18.pictureBox1.Image = null;
                }

                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField18.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField18.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField18.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
            else
            {
                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField18.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField18.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField18.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
        }

        private void playerInField11_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            StaffList myObject = (StaffList)e.Data.GetData(e.Data.GetFormats()[0]);

            if (ilkonbir.Contains(myObject.NameSurname))
            {
                if (playerInField1.label1.Text == myObject.NameSurname)
                {
                    playerInField1.label1.Text = "";
                    playerInField1.label2.Text = "";
                    playerInField1.pictureBox1.Image = null;
                }
                if (playerInField2.label1.Text == myObject.NameSurname)
                {
                    playerInField2.label1.Text = "";
                    playerInField2.label2.Text = "";
                    playerInField2.pictureBox1.Image = null;
                }
                if (playerInField3.label1.Text == myObject.NameSurname)
                {
                    playerInField3.label1.Text = "";
                    playerInField3.label2.Text = "";
                    playerInField3.pictureBox1.Image = null;
                }
                if (playerInField4.label1.Text == myObject.NameSurname)
                {
                    playerInField4.label1.Text = "";
                    playerInField4.label2.Text = "";
                    playerInField4.pictureBox1.Image = null;
                }
                if (playerInField5.label1.Text == myObject.NameSurname)
                {
                    playerInField5.label1.Text = "";
                    playerInField5.label2.Text = "";
                    playerInField5.pictureBox1.Image = null;
                }
                if (playerInField6.label1.Text == myObject.NameSurname)
                {
                    playerInField6.label1.Text = "";
                    playerInField6.label2.Text = "";
                    playerInField6.pictureBox1.Image = null;
                }
                if (playerInField7.label1.Text == myObject.NameSurname)
                {
                    playerInField7.label1.Text = "";
                    playerInField7.label2.Text = "";
                    playerInField7.pictureBox1.Image = null;
                }
                if (playerInField8.label1.Text == myObject.NameSurname)
                {
                    playerInField8.label1.Text = "";
                    playerInField8.label2.Text = "";
                    playerInField8.pictureBox1.Image = null;
                }
                if (playerInField9.label1.Text == myObject.NameSurname)
                {
                    playerInField9.label1.Text = "";
                    playerInField9.label2.Text = "";
                    playerInField9.pictureBox1.Image = null;
                }
                if (playerInField10.label1.Text == myObject.NameSurname)
                {
                    playerInField10.label1.Text = "";
                    playerInField10.label2.Text = "";
                    playerInField10.pictureBox1.Image = null;
                }
                if (playerInField11.label1.Text == myObject.NameSurname)
                {
                    playerInField11.label1.Text = "";
                    playerInField11.label2.Text = "";
                    playerInField11.pictureBox1.Image = null;
                }

                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField11.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField11.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField11.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
            else
            {
                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField11.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField11.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField11.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
        }

        private void playerInField10_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            StaffList myObject = (StaffList)e.Data.GetData(e.Data.GetFormats()[0]);

            if (ilkonbir.Contains(myObject.NameSurname))
            {
                if (playerInField1.label1.Text == myObject.NameSurname)
                {
                    playerInField1.label1.Text = "";
                    playerInField1.label2.Text = "";
                    playerInField1.pictureBox1.Image = null;
                }
                if (playerInField2.label1.Text == myObject.NameSurname)
                {
                    playerInField2.label1.Text = "";
                    playerInField2.label2.Text = "";
                    playerInField2.pictureBox1.Image = null;
                }
                if (playerInField3.label1.Text == myObject.NameSurname)
                {
                    playerInField3.label1.Text = "";
                    playerInField3.label2.Text = "";
                    playerInField3.pictureBox1.Image = null;
                }
                if (playerInField4.label1.Text == myObject.NameSurname)
                {
                    playerInField4.label1.Text = "";
                    playerInField4.label2.Text = "";
                    playerInField4.pictureBox1.Image = null;
                }
                if (playerInField5.label1.Text == myObject.NameSurname)
                {
                    playerInField5.label1.Text = "";
                    playerInField5.label2.Text = "";
                    playerInField5.pictureBox1.Image = null;
                }
                if (playerInField6.label1.Text == myObject.NameSurname)
                {
                    playerInField6.label1.Text = "";
                    playerInField6.label2.Text = "";
                    playerInField6.pictureBox1.Image = null;
                }
                if (playerInField7.label1.Text == myObject.NameSurname)
                {
                    playerInField7.label1.Text = "";
                    playerInField7.label2.Text = "";
                    playerInField7.pictureBox1.Image = null;
                }
                if (playerInField8.label1.Text == myObject.NameSurname)
                {
                    playerInField8.label1.Text = "";
                    playerInField8.label2.Text = "";
                    playerInField8.pictureBox1.Image = null;
                }
                if (playerInField9.label1.Text == myObject.NameSurname)
                {
                    playerInField9.label1.Text = "";
                    playerInField9.label2.Text = "";
                    playerInField9.pictureBox1.Image = null;
                }
                if (playerInField10.label1.Text == myObject.NameSurname)
                {
                    playerInField10.label1.Text = "";
                    playerInField10.label2.Text = "";
                    playerInField10.pictureBox1.Image = null;
                }
                if (playerInField11.label1.Text == myObject.NameSurname)
                {
                    playerInField11.label1.Text = "";
                    playerInField11.label2.Text = "";
                    playerInField11.pictureBox1.Image = null;
                }

                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField10.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField10.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField10.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
            else
            {
                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField10.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField10.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField10.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
        }

        private void playerInField9_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            StaffList myObject = (StaffList)e.Data.GetData(e.Data.GetFormats()[0]);

            if (ilkonbir.Contains(myObject.NameSurname))
            {
                if (playerInField1.label1.Text == myObject.NameSurname)
                {
                    playerInField1.label1.Text = "";
                    playerInField1.label2.Text = "";
                    playerInField1.pictureBox1.Image = null;
                }
                if (playerInField2.label1.Text == myObject.NameSurname)
                {
                    playerInField2.label1.Text = "";
                    playerInField2.label2.Text = "";
                    playerInField2.pictureBox1.Image = null;
                }
                if (playerInField3.label1.Text == myObject.NameSurname)
                {
                    playerInField3.label1.Text = "";
                    playerInField3.label2.Text = "";
                    playerInField3.pictureBox1.Image = null;
                }
                if (playerInField4.label1.Text == myObject.NameSurname)
                {
                    playerInField4.label1.Text = "";
                    playerInField4.label2.Text = "";
                    playerInField4.pictureBox1.Image = null;
                }
                if (playerInField5.label1.Text == myObject.NameSurname)
                {
                    playerInField5.label1.Text = "";
                    playerInField5.label2.Text = "";
                    playerInField5.pictureBox1.Image = null;
                }
                if (playerInField6.label1.Text == myObject.NameSurname)
                {
                    playerInField6.label1.Text = "";
                    playerInField6.label2.Text = "";
                    playerInField6.pictureBox1.Image = null;
                }
                if (playerInField7.label1.Text == myObject.NameSurname)
                {
                    playerInField7.label1.Text = "";
                    playerInField7.label2.Text = "";
                    playerInField7.pictureBox1.Image = null;
                }
                if (playerInField8.label1.Text == myObject.NameSurname)
                {
                    playerInField8.label1.Text = "";
                    playerInField8.label2.Text = "";
                    playerInField8.pictureBox1.Image = null;
                }
                if (playerInField9.label1.Text == myObject.NameSurname)
                {
                    playerInField9.label1.Text = "";
                    playerInField9.label2.Text = "";
                    playerInField9.pictureBox1.Image = null;
                }
                if (playerInField10.label1.Text == myObject.NameSurname)
                {
                    playerInField10.label1.Text = "";
                    playerInField10.label2.Text = "";
                    playerInField10.pictureBox1.Image = null;
                }
                if (playerInField11.label1.Text == myObject.NameSurname)
                {
                    playerInField11.label1.Text = "";
                    playerInField11.label2.Text = "";
                    playerInField11.pictureBox1.Image = null;
                }

                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField9.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField9.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField9.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
            else
            {
                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField9.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField9.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField9.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
        }
        private void playerInField8_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            StaffList myObject = (StaffList)e.Data.GetData(e.Data.GetFormats()[0]);

            if (ilkonbir.Contains(myObject.NameSurname))
            {
                if (playerInField1.label1.Text == myObject.NameSurname)
                {
                    playerInField1.label1.Text = "";
                    playerInField1.label2.Text = "";
                    playerInField1.pictureBox1.Image = null;
                }
                if (playerInField2.label1.Text == myObject.NameSurname)
                {
                    playerInField2.label1.Text = "";
                    playerInField2.label2.Text = "";
                    playerInField2.pictureBox1.Image = null;
                }
                if (playerInField3.label1.Text == myObject.NameSurname)
                {
                    playerInField3.label1.Text = "";
                    playerInField3.label2.Text = "";
                    playerInField3.pictureBox1.Image = null;
                }
                if (playerInField4.label1.Text == myObject.NameSurname)
                {
                    playerInField4.label1.Text = "";
                    playerInField4.label2.Text = "";
                    playerInField4.pictureBox1.Image = null;
                }
                if (playerInField5.label1.Text == myObject.NameSurname)
                {
                    playerInField5.label1.Text = "";
                    playerInField5.label2.Text = "";
                    playerInField5.pictureBox1.Image = null;
                }
                if (playerInField6.label1.Text == myObject.NameSurname)
                {
                    playerInField6.label1.Text = "";
                    playerInField6.label2.Text = "";
                    playerInField6.pictureBox1.Image = null;
                }
                if (playerInField7.label1.Text == myObject.NameSurname)
                {
                    playerInField7.label1.Text = "";
                    playerInField7.label2.Text = "";
                    playerInField7.pictureBox1.Image = null;
                }
                if (playerInField8.label1.Text == myObject.NameSurname)
                {
                    playerInField8.label1.Text = "";
                    playerInField8.label2.Text = "";
                    playerInField8.pictureBox1.Image = null;
                }
                if (playerInField9.label1.Text == myObject.NameSurname)
                {
                    playerInField9.label1.Text = "";
                    playerInField9.label2.Text = "";
                    playerInField9.pictureBox1.Image = null;
                }
                if (playerInField10.label1.Text == myObject.NameSurname)
                {
                    playerInField10.label1.Text = "";
                    playerInField10.label2.Text = "";
                    playerInField10.pictureBox1.Image = null;
                }
                if (playerInField11.label1.Text == myObject.NameSurname)
                {
                    playerInField11.label1.Text = "";
                    playerInField11.label2.Text = "";
                    playerInField11.pictureBox1.Image = null;
                }

                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField8.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField8.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField8.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
            else
            {
                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField8.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField8.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField8.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
        }
        private void playerInField7_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            StaffList myObject = (StaffList)e.Data.GetData(e.Data.GetFormats()[0]);

            if (ilkonbir.Contains(myObject.NameSurname))
            {
                if (playerInField1.label1.Text == myObject.NameSurname)
                {
                    playerInField1.label1.Text = "";
                    playerInField1.label2.Text = "";
                    playerInField1.pictureBox1.Image = null;
                }
                if (playerInField2.label1.Text == myObject.NameSurname)
                {
                    playerInField2.label1.Text = "";
                    playerInField2.label2.Text = "";
                    playerInField2.pictureBox1.Image = null;
                }
                if (playerInField3.label1.Text == myObject.NameSurname)
                {
                    playerInField3.label1.Text = "";
                    playerInField3.label2.Text = "";
                    playerInField3.pictureBox1.Image = null;
                }
                if (playerInField4.label1.Text == myObject.NameSurname)
                {
                    playerInField4.label1.Text = "";
                    playerInField4.label2.Text = "";
                    playerInField4.pictureBox1.Image = null;
                }
                if (playerInField5.label1.Text == myObject.NameSurname)
                {
                    playerInField5.label1.Text = "";
                    playerInField5.label2.Text = "";
                    playerInField5.pictureBox1.Image = null;
                }
                if (playerInField6.label1.Text == myObject.NameSurname)
                {
                    playerInField6.label1.Text = "";
                    playerInField6.label2.Text = "";
                    playerInField6.pictureBox1.Image = null;
                }
                if (playerInField7.label1.Text == myObject.NameSurname)
                {
                    playerInField7.label1.Text = "";
                    playerInField7.label2.Text = "";
                    playerInField7.pictureBox1.Image = null;
                }
                if (playerInField8.label1.Text == myObject.NameSurname)
                {
                    playerInField8.label1.Text = "";
                    playerInField8.label2.Text = "";
                    playerInField8.pictureBox1.Image = null;
                }
                if (playerInField9.label1.Text == myObject.NameSurname)
                {
                    playerInField9.label1.Text = "";
                    playerInField9.label2.Text = "";
                    playerInField9.pictureBox1.Image = null;
                }
                if (playerInField10.label1.Text == myObject.NameSurname)
                {
                    playerInField10.label1.Text = "";
                    playerInField10.label2.Text = "";
                    playerInField10.pictureBox1.Image = null;
                }
                if (playerInField11.label1.Text == myObject.NameSurname)
                {
                    playerInField11.label1.Text = "";
                    playerInField11.label2.Text = "";
                    playerInField11.pictureBox1.Image = null;
                }

                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField7.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField7.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField7.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
            else
            {
                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField7.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField7.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField7.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
        }
        private void playerInField6_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            StaffList myObject = (StaffList)e.Data.GetData(e.Data.GetFormats()[0]);

            if (ilkonbir.Contains(myObject.NameSurname))
            {
                if (playerInField1.label1.Text == myObject.NameSurname)
                {
                    playerInField1.label1.Text = "";
                    playerInField1.label2.Text = "";
                    playerInField1.pictureBox1.Image = null;
                }
                if (playerInField2.label1.Text == myObject.NameSurname)
                {
                    playerInField2.label1.Text = "";
                    playerInField2.label2.Text = "";
                    playerInField2.pictureBox1.Image = null;
                }
                if (playerInField3.label1.Text == myObject.NameSurname)
                {
                    playerInField3.label1.Text = "";
                    playerInField3.label2.Text = "";
                    playerInField3.pictureBox1.Image = null;
                }
                if (playerInField4.label1.Text == myObject.NameSurname)
                {
                    playerInField4.label1.Text = "";
                    playerInField4.label2.Text = "";
                    playerInField4.pictureBox1.Image = null;
                }
                if (playerInField5.label1.Text == myObject.NameSurname)
                {
                    playerInField5.label1.Text = "";
                    playerInField5.label2.Text = "";
                    playerInField5.pictureBox1.Image = null;
                }
                if (playerInField6.label1.Text == myObject.NameSurname)
                {
                    playerInField6.label1.Text = "";
                    playerInField6.label2.Text = "";
                    playerInField6.pictureBox1.Image = null;
                }
                if (playerInField7.label1.Text == myObject.NameSurname)
                {
                    playerInField7.label1.Text = "";
                    playerInField7.label2.Text = "";
                    playerInField7.pictureBox1.Image = null;
                }
                if (playerInField8.label1.Text == myObject.NameSurname)
                {
                    playerInField8.label1.Text = "";
                    playerInField8.label2.Text = "";
                    playerInField8.pictureBox1.Image = null;
                }
                if (playerInField9.label1.Text == myObject.NameSurname)
                {
                    playerInField9.label1.Text = "";
                    playerInField9.label2.Text = "";
                    playerInField9.pictureBox1.Image = null;
                }
                if (playerInField10.label1.Text == myObject.NameSurname)
                {
                    playerInField10.label1.Text = "";
                    playerInField10.label2.Text = "";
                    playerInField10.pictureBox1.Image = null;
                }
                if (playerInField11.label1.Text == myObject.NameSurname)
                {
                    playerInField11.label1.Text = "";
                    playerInField11.label2.Text = "";
                    playerInField11.pictureBox1.Image = null;
                }

                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField6.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField6.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField6.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
            else
            {
                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField6.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField6.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField6.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
        }
        private void playerInField5_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            StaffList myObject = (StaffList)e.Data.GetData(e.Data.GetFormats()[0]);

            if (ilkonbir.Contains(myObject.NameSurname))
            {
                if (playerInField1.label1.Text == myObject.NameSurname)
                {
                    playerInField1.label1.Text = "";
                    playerInField1.label2.Text = "";
                    playerInField1.pictureBox1.Image = null;
                }
                if (playerInField2.label1.Text == myObject.NameSurname)
                {
                    playerInField2.label1.Text = "";
                    playerInField2.label2.Text = "";
                    playerInField2.pictureBox1.Image = null;
                }
                if (playerInField3.label1.Text == myObject.NameSurname)
                {
                    playerInField3.label1.Text = "";
                    playerInField3.label2.Text = "";
                    playerInField3.pictureBox1.Image = null;
                }
                if (playerInField4.label1.Text == myObject.NameSurname)
                {
                    playerInField4.label1.Text = "";
                    playerInField4.label2.Text = "";
                    playerInField4.pictureBox1.Image = null;
                }
                if (playerInField5.label1.Text == myObject.NameSurname)
                {
                    playerInField5.label1.Text = "";
                    playerInField5.label2.Text = "";
                    playerInField5.pictureBox1.Image = null;
                }
                if (playerInField6.label1.Text == myObject.NameSurname)
                {
                    playerInField6.label1.Text = "";
                    playerInField6.label2.Text = "";
                    playerInField6.pictureBox1.Image = null;
                }
                if (playerInField7.label1.Text == myObject.NameSurname)
                {
                    playerInField7.label1.Text = "";
                    playerInField7.label2.Text = "";
                    playerInField7.pictureBox1.Image = null;
                }
                if (playerInField8.label1.Text == myObject.NameSurname)
                {
                    playerInField8.label1.Text = "";
                    playerInField8.label2.Text = "";
                    playerInField8.pictureBox1.Image = null;
                }
                if (playerInField9.label1.Text == myObject.NameSurname)
                {
                    playerInField9.label1.Text = "";
                    playerInField9.label2.Text = "";
                    playerInField9.pictureBox1.Image = null;
                }
                if (playerInField10.label1.Text == myObject.NameSurname)
                {
                    playerInField10.label1.Text = "";
                    playerInField10.label2.Text = "";
                    playerInField10.pictureBox1.Image = null;
                }
                if (playerInField11.label1.Text == myObject.NameSurname)
                {
                    playerInField11.label1.Text = "";
                    playerInField11.label2.Text = "";
                    playerInField11.pictureBox1.Image = null;
                }

                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField5.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField5.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField5.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
            else
            {
                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField5.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField5.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField5.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
        }
        private void playerInField4_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            StaffList myObject = (StaffList)e.Data.GetData(e.Data.GetFormats()[0]);

            if (ilkonbir.Contains(myObject.NameSurname))
            {
                if (playerInField1.label1.Text == myObject.NameSurname)
                {
                    playerInField1.label1.Text = "";
                    playerInField1.label2.Text = "";
                    playerInField1.pictureBox1.Image = null;
                }
                if (playerInField2.label1.Text == myObject.NameSurname)
                {
                    playerInField2.label1.Text = "";
                    playerInField2.label2.Text = "";
                    playerInField2.pictureBox1.Image = null;
                }
                if (playerInField3.label1.Text == myObject.NameSurname)
                {
                    playerInField3.label1.Text = "";
                    playerInField3.label2.Text = "";
                    playerInField3.pictureBox1.Image = null;
                }
                if (playerInField4.label1.Text == myObject.NameSurname)
                {
                    playerInField4.label1.Text = "";
                    playerInField4.label2.Text = "";
                    playerInField4.pictureBox1.Image = null;
                }
                if (playerInField5.label1.Text == myObject.NameSurname)
                {
                    playerInField5.label1.Text = "";
                    playerInField5.label2.Text = "";
                    playerInField5.pictureBox1.Image = null;
                }
                if (playerInField6.label1.Text == myObject.NameSurname)
                {
                    playerInField6.label1.Text = "";
                    playerInField6.label2.Text = "";
                    playerInField6.pictureBox1.Image = null;
                }
                if (playerInField7.label1.Text == myObject.NameSurname)
                {
                    playerInField7.label1.Text = "";
                    playerInField7.label2.Text = "";
                    playerInField7.pictureBox1.Image = null;
                }
                if (playerInField8.label1.Text == myObject.NameSurname)
                {
                    playerInField8.label1.Text = "";
                    playerInField8.label2.Text = "";
                    playerInField8.pictureBox1.Image = null;
                }
                if (playerInField9.label1.Text == myObject.NameSurname)
                {
                    playerInField9.label1.Text = "";
                    playerInField9.label2.Text = "";
                    playerInField9.pictureBox1.Image = null;
                }
                if (playerInField10.label1.Text == myObject.NameSurname)
                {
                    playerInField10.label1.Text = "";
                    playerInField10.label2.Text = "";
                    playerInField10.pictureBox1.Image = null;
                }
                if (playerInField11.label1.Text == myObject.NameSurname)
                {
                    playerInField11.label1.Text = "";
                    playerInField11.label2.Text = "";
                    playerInField11.pictureBox1.Image = null;
                }

                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField4.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField4.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField4.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
            else
            {
                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField4.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField4.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField4.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
        }
        private void playerInField3_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            StaffList myObject = (StaffList)e.Data.GetData(e.Data.GetFormats()[0]);

            if (ilkonbir.Contains(myObject.NameSurname))
            {
                if (playerInField1.label1.Text == myObject.NameSurname)
                {
                    playerInField1.label1.Text = "";
                    playerInField1.label2.Text = "";
                    playerInField1.pictureBox1.Image = null;
                }
                if (playerInField2.label1.Text == myObject.NameSurname)
                {
                    playerInField2.label1.Text = "";
                    playerInField2.label2.Text = "";
                    playerInField2.pictureBox1.Image = null;
                }
                if (playerInField3.label1.Text == myObject.NameSurname)
                {
                    playerInField3.label1.Text = "";
                    playerInField3.label2.Text = "";
                    playerInField3.pictureBox1.Image = null;
                }
                if (playerInField4.label1.Text == myObject.NameSurname)
                {
                    playerInField4.label1.Text = "";
                    playerInField4.label2.Text = "";
                    playerInField4.pictureBox1.Image = null;
                }
                if (playerInField5.label1.Text == myObject.NameSurname)
                {
                    playerInField5.label1.Text = "";
                    playerInField5.label2.Text = "";
                    playerInField5.pictureBox1.Image = null;
                }
                if (playerInField6.label1.Text == myObject.NameSurname)
                {
                    playerInField6.label1.Text = "";
                    playerInField6.label2.Text = "";
                    playerInField6.pictureBox1.Image = null;
                }
                if (playerInField7.label1.Text == myObject.NameSurname)
                {
                    playerInField7.label1.Text = "";
                    playerInField7.label2.Text = "";
                    playerInField7.pictureBox1.Image = null;
                }
                if (playerInField8.label1.Text == myObject.NameSurname)
                {
                    playerInField8.label1.Text = "";
                    playerInField8.label2.Text = "";
                    playerInField8.pictureBox1.Image = null;
                }
                if (playerInField9.label1.Text == myObject.NameSurname)
                {
                    playerInField9.label1.Text = "";
                    playerInField9.label2.Text = "";
                    playerInField9.pictureBox1.Image = null;
                }
                if (playerInField10.label1.Text == myObject.NameSurname)
                {
                    playerInField10.label1.Text = "";
                    playerInField10.label2.Text = "";
                    playerInField10.pictureBox1.Image = null;
                }
                if (playerInField11.label1.Text == myObject.NameSurname)
                {
                    playerInField11.label1.Text = "";
                    playerInField11.label2.Text = "";
                    playerInField11.pictureBox1.Image = null;
                }

                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField3.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField3.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField3.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
            else
            {
                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField3.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField3.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField3.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
        }
        private void playerInField2_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            StaffList myObject = (StaffList)e.Data.GetData(e.Data.GetFormats()[0]);

            if (ilkonbir.Contains(myObject.NameSurname))
            {
                if (playerInField1.label1.Text == myObject.NameSurname)
                {
                    playerInField1.label1.Text = "";
                    playerInField1.label2.Text = "";
                    playerInField1.pictureBox1.Image = null;
                }
                if (playerInField2.label1.Text == myObject.NameSurname)
                {
                    playerInField2.label1.Text = "";
                    playerInField2.label2.Text = "";
                    playerInField2.pictureBox1.Image = null;
                }
                if (playerInField3.label1.Text == myObject.NameSurname)
                {
                    playerInField3.label1.Text = "";
                    playerInField3.label2.Text = "";
                    playerInField3.pictureBox1.Image = null;
                }
                if (playerInField4.label1.Text == myObject.NameSurname)
                {
                    playerInField4.label1.Text = "";
                    playerInField4.label2.Text = "";
                    playerInField4.pictureBox1.Image = null;
                }
                if (playerInField5.label1.Text == myObject.NameSurname)
                {
                    playerInField5.label1.Text = "";
                    playerInField5.label2.Text = "";
                    playerInField5.pictureBox1.Image = null;
                }
                if (playerInField6.label1.Text == myObject.NameSurname)
                {
                    playerInField6.label1.Text = "";
                    playerInField6.label2.Text = "";
                    playerInField6.pictureBox1.Image = null;
                }
                if (playerInField7.label1.Text == myObject.NameSurname)
                {
                    playerInField7.label1.Text = "";
                    playerInField7.label2.Text = "";
                    playerInField7.pictureBox1.Image = null;
                }
                if (playerInField8.label1.Text == myObject.NameSurname)
                {
                    playerInField8.label1.Text = "";
                    playerInField8.label2.Text = "";
                    playerInField8.pictureBox1.Image = null;
                }
                if (playerInField9.label1.Text == myObject.NameSurname)
                {
                    playerInField9.label1.Text = "";
                    playerInField9.label2.Text = "";
                    playerInField9.pictureBox1.Image = null;
                }
                if (playerInField10.label1.Text == myObject.NameSurname)
                {
                    playerInField10.label1.Text = "";
                    playerInField10.label2.Text = "";
                    playerInField10.pictureBox1.Image = null;
                }
                if (playerInField11.label1.Text == myObject.NameSurname)
                {
                    playerInField11.label1.Text = "";
                    playerInField11.label2.Text = "";
                    playerInField11.pictureBox1.Image = null;
                }

                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField2.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField2.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField2.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
            else
            {
                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField2.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField2.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField2.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
        }
        private void playerInField1_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            StaffList myObject = (StaffList)e.Data.GetData(e.Data.GetFormats()[0]);

            if (ilkonbir.Contains(myObject.NameSurname))
            {
                if (playerInField1.label1.Text == myObject.NameSurname)
                {
                    playerInField1.label1.Text = "";
                    playerInField1.label2.Text = "";
                    playerInField1.pictureBox1.Image = null;
                }
                if (playerInField2.label1.Text == myObject.NameSurname)
                {
                    playerInField2.label1.Text = "";
                    playerInField2.label2.Text = "";
                    playerInField2.pictureBox1.Image = null;
                }
                if (playerInField3.label1.Text == myObject.NameSurname)
                {
                    playerInField3.label1.Text = "";
                    playerInField3.label2.Text = "";
                    playerInField3.pictureBox1.Image = null;
                }
                if (playerInField4.label1.Text == myObject.NameSurname)
                {
                    playerInField4.label1.Text = "";
                    playerInField4.label2.Text = "";
                    playerInField4.pictureBox1.Image = null;
                }
                if (playerInField5.label1.Text == myObject.NameSurname)
                {
                    playerInField5.label1.Text = "";
                    playerInField5.label2.Text = "";
                    playerInField5.pictureBox1.Image = null;
                }
                if (playerInField6.label1.Text == myObject.NameSurname)
                {
                    playerInField6.label1.Text = "";
                    playerInField6.label2.Text = "";
                    playerInField6.pictureBox1.Image = null;
                }
                if (playerInField7.label1.Text == myObject.NameSurname)
                {
                    playerInField7.label1.Text = "";
                    playerInField7.label2.Text = "";
                    playerInField7.pictureBox1.Image = null;
                }
                if (playerInField8.label1.Text == myObject.NameSurname)
                {
                    playerInField8.label1.Text = "";
                    playerInField8.label2.Text = "";
                    playerInField8.pictureBox1.Image = null;
                }
                if (playerInField9.label1.Text == myObject.NameSurname)
                {
                    playerInField9.label1.Text = "";
                    playerInField9.label2.Text = "";
                    playerInField9.pictureBox1.Image = null;
                }
                if (playerInField10.label1.Text == myObject.NameSurname)
                {
                    playerInField10.label1.Text = "";
                    playerInField10.label2.Text = "";
                    playerInField10.pictureBox1.Image = null;
                }
                if (playerInField11.label1.Text == myObject.NameSurname)
                {
                    playerInField11.label1.Text = "";
                    playerInField11.label2.Text = "";
                    playerInField11.pictureBox1.Image = null;
                }

                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField1.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField1.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField1.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
            else
            {
                ilkonbir.Add(myObject.NameSurname);
                ilkonbir.Add(myObject.Role);
                ilkonbir.Add(myObject.PlayerPic);

                playerInField1.label1.Text = ilkonbir[ilkonbir.Count - 3].ToString();
                playerInField1.label2.Text = ilkonbir[ilkonbir.Count - 2].ToString();
                playerInField1.pictureBox1.ImageLocation = ilkonbir[ilkonbir.Count - 1].ToString();

            }
        }

        private void formationcbx_TextChanged(object sender, EventArgs e)
        {
            if (formationcbx.SelectedItem == "4-4-2")
            {
                playerInField2.Location = new Point(40, 560);
                playerInField3.Location = new Point(150, 560);
                playerInField4.Location = new Point(260, 560);
                playerInField5.Location = new Point(370, 560);
                playerInField6.Location = new Point(40, 360);
                playerInField7.Location = new Point(150, 360);
                playerInField8.Location = new Point(260, 360);
                playerInField9.Location = new Point(370, 360);
                playerInField10.Location = new Point(150, 90);
                playerInField11.Location = new Point(260, 90);
            }
            if (formationcbx.SelectedItem == "4-4-2 (diamond)")
            {
                playerInField2.Location = new Point(40, 560);
                playerInField3.Location = new Point(150, 560);
                playerInField4.Location = new Point(260, 560);
                playerInField5.Location = new Point(370, 560);
                playerInField6.Location = new Point(100, 350);
                playerInField7.Location = new Point(206, 260);
                playerInField8.Location = new Point(206, 430);
                playerInField9.Location = new Point(310, 350);
                playerInField10.Location = new Point(150, 90);
                playerInField11.Location = new Point(260, 90);
            }
            if (formationcbx.SelectedItem == "4-3-3")
            {
                playerInField2.Location = new Point(40, 560);
                playerInField3.Location = new Point(150, 560);
                playerInField4.Location = new Point(260, 560);
                playerInField5.Location = new Point(370, 560);
                playerInField6.Location = new Point(100, 350);
                playerInField7.Location = new Point(206, 350);
                playerInField8.Location = new Point(310, 350);
                playerInField9.Location = new Point(100, 90);
                playerInField10.Location = new Point(206, 90);
                playerInField11.Location = new Point(310, 90);
            }
            if (formationcbx.SelectedItem == "4-2-3-1")
            {
                playerInField2.Location = new Point(40, 560);
                playerInField3.Location = new Point(150, 560);
                playerInField4.Location = new Point(260, 560);
                playerInField5.Location = new Point(370, 560);
                playerInField6.Location = new Point(150, 380);
                playerInField7.Location = new Point(260, 380);
                playerInField8.Location = new Point(40, 210);
                playerInField9.Location = new Point(206, 210);
                playerInField10.Location = new Point(372, 210);
                playerInField11.Location = new Point(206, 90);
            }
            if (formationcbx.SelectedItem == "4-2-2-2")
            {
                playerInField2.Location = new Point(40, 560);
                playerInField3.Location = new Point(150, 560);
                playerInField4.Location = new Point(260, 560);
                playerInField5.Location = new Point(370, 560);
                playerInField6.Location = new Point(150, 380);
                playerInField7.Location = new Point(260, 380);
                playerInField8.Location = new Point(40, 225);
                playerInField9.Location = new Point(372, 225);
                playerInField10.Location = new Point(150, 90);
                playerInField11.Location = new Point(260, 90);
            }
            if (formationcbx.SelectedItem == "3-5-2")
            {
                playerInField2.Location = new Point(96, 560);
                playerInField3.Location = new Point(206, 560);
                playerInField4.Location = new Point(316, 560);
                playerInField5.Location = new Point(206, 445);
                playerInField6.Location = new Point(40, 330);
                playerInField7.Location = new Point(150, 330);
                playerInField8.Location = new Point(260, 330);
                playerInField9.Location = new Point(370, 330);
                playerInField10.Location = new Point(150, 100);
                playerInField11.Location = new Point(260, 100);
            }
            if (formationcbx.SelectedItem == "3-4-3")
            {
                playerInField2.Location = new Point(96, 560);
                playerInField3.Location = new Point(206, 560);
                playerInField4.Location = new Point(316, 560);
                playerInField5.Location = new Point(40, 330);
                playerInField6.Location = new Point(150, 400);
                playerInField7.Location = new Point(260, 400);
                playerInField8.Location = new Point(370, 330);
                playerInField9.Location = new Point(70, 160);
                playerInField10.Location = new Point(206, 100);
                playerInField11.Location = new Point(340, 160);

            }
            if (formationcbx.SelectedItem == "3-3-3-1")
            {
                playerInField2.Location = new Point(96, 560);
                playerInField3.Location = new Point(206, 560);
                playerInField4.Location = new Point(316, 560);
                playerInField5.Location = new Point(66, 380);
                playerInField6.Location = new Point(206, 380);
                playerInField7.Location = new Point(346, 380);
                playerInField8.Location = new Point(96, 218);
                playerInField9.Location = new Point(206, 218);
                playerInField10.Location = new Point(316, 218);
                playerInField11.Location = new Point(206, 90);
            }
        }

        

        //private void fieldpanel_Paint(object sender, PaintEventArgs e)
        //{

        //    int x = 17;
        //    int y = 40;

        //    var rectangledict = new Dictionary<string, Rectangle>();

        //    for (int z = 0; z <= 5; z++)
        //    {
        //        for (int i = 0; i <= 3; i++)
        //        {
        //            SolidBrush semitransbrush = new SolidBrush(Color.FromArgb(32, 255, 255, 255));
        //            e.Graphics.FillRectangle(semitransbrush, x, y, 110, 120);
        //            x = x + 115;
        //        }
        //        y = y + 125;
        //        x = 17;
        //    }
        //}
=======

                stafflistmain.Controls.Add(staffList);

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            stafflistmain.Controls.SetChildIndex(staffList, 3);
            stafflistmain.ResumeLayout();
        }
>>>>>>> fd53677075a9f715ca932c6bb62448e4bb2c0061
    }
}
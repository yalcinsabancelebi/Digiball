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
<<<<<<< HEAD

=======
    
>>>>>>> fd53677075a9f715ca932c6bb62448e4bb2c0061
    public partial class StaffList : UserControl
    {

        public string FormaNo
        {
            get { return formanolbl.Text; }
            set { formanolbl.Text = value; }
        }
<<<<<<< HEAD
        public string Position
        {
=======
        public string Position {
>>>>>>> fd53677075a9f715ca932c6bb62448e4bb2c0061
            get { return positionlbl.Text; }
            set { positionlbl.Text = value; }
        }
        public string Role
        {
            get { return rolelbl.Text; }
            set { rolelbl.Text = value; }
        }
        public string PlayerPic
        {
            get { return playerpic.ImageLocation; }
            set { playerpic.ImageLocation = value; }
        }
<<<<<<< HEAD
        public string NameSurname
        {
=======
        public string NameSurname {
>>>>>>> fd53677075a9f715ca932c6bb62448e4bb2c0061
            get { return namesurnamelbl.Text; }
            set { namesurnamelbl.Text = value; }
        }
        public string Age
        {
            get { return agelbl.Text; }
            set { agelbl.Text = value; }
        }
        //public string Star
        //{
        //    get { return star.Text; }
        //    set { agelbl.Text = value; }
        //}
        public string GkAbility
        {
            get { return gkability.Text; }
            set { gkability.Text = value; }
        }
        public string DfAbility
        {
            get { return dfability.Text; }
            set { dfability.Text = value; }
        }
        public string MfAbility
        {
            get { return mfability.Text; }
            set { mfability.Text = value; }
        }
        public string FwAbility
        {
            get { return fwability.Text; }
            set { fwability.Text = value; }
        }
        public string PlayerHeight
        {
            get { return heightlbl.Text; }
            set { heightlbl.Text = value + " cm"; }
        }
        public string PlayerWeight
        {
            get { return weightlbl.Text; }
            set { weightlbl.Text = value + " kg"; }
        }
        public int PlayerFoot { get; set; }



        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,     // x-coordinate of upper-left corner
                int nTopRect,      // y-coordinate of upper-left corner
                int nRightRect,    // x-coordinate of lower-right corner
                int nBottomRect,   // y-coordinate of lower-right corner
                int nWidthEllipse, // width of ellipse
                int nHeightEllipse // height of ellipse
            );
        public StaffList()
        {
            InitializeComponent();
<<<<<<< HEAD
            this.BorderStyle = BorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
=======
            //this.BackColor = Color.FromArgb(100, Color.MidnightBlue);
            this.BorderStyle = BorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

>>>>>>> fd53677075a9f715ca932c6bb62448e4bb2c0061
        }

        private void StaffList_Load(object sender, EventArgs e)
        {
            if (Position == "Goalkeeper")
            {
                staffpanel.BackColor = Color.FromArgb(64, 64, 64);
                this.BackColor = Color.Indigo;
            }
            else
            {
                if (Position == "Defender")
                {
                    staffpanel.BackColor = Color.FromArgb(0, 0, 64);
                    this.BackColor = Color.Indigo;
                }
                if (Position == "Midfielder")
                {
                    staffpanel.BackColor = Color.FromArgb(64, 0, 64);
                    this.BackColor = Color.Indigo;
                }
                if (Position == "Forward")
                {
                    staffpanel.BackColor = Color.FromArgb(64, 0, 0);
                    this.BackColor = Color.Indigo;
                }
            }
        }
<<<<<<< HEAD

        private void StaffList_MouseDown(object sender, MouseEventArgs e)
        {
            staffpanel.DoDragDrop((StaffList)this, DragDropEffects.Copy);
        }

        private void staffpanel_MouseDown(object sender, MouseEventArgs e)
        {
            staffpanel.DoDragDrop((StaffList)this, DragDropEffects.Copy);
        }
=======
>>>>>>> fd53677075a9f715ca932c6bb62448e4bb2c0061
    }
}

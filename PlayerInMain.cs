using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digiball
{
    public partial class PlayerInMain : UserControl
    {


        public PlayerInMain()
        {
            InitializeComponent();
            playerpic.Parent = teamlogopic;
            playerpic.BackColor = Color.Transparent;
            label3.Parent = this;
        }
        public string PlayerNameSurname
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public string PlayerAge
        {
            get { return label3.Text; }
            set { label3.Text = value + " Years Old"; }
        }
        public string PlayerPic
        {
            get { return playerpic.ImageLocation; }
            set { playerpic.ImageLocation = value; }
        }
        public string TeamLogo
        {
            get { return teamlogopic.ImageLocation; }
            set { teamlogopic.ImageLocation = value; }
        }
        public string Flag
        {
            get { return flag.ImageLocation; }
            set { flag.ImageLocation = value; }
        }
        public string CountryName
        {
            get { return countrylbl.Text; }
            set { countrylbl.Text = value; }
        }
        public string Position
        {
            get { return position.Text; }
            set { position.Text = value; }
        }

        private void PlayerInMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class PositionCircles:PlayerInMain
    {
        public void forwardPlayers(PaintEventArgs e)
        {
            int x = 245, y = 30, x1 = 9, y1 = 13;
            for (int i = 0; i < 3; i++)
            {
                e.Graphics.FillEllipse(new SolidBrush(System.Drawing.Color.White), x, y, x1, x1);
                e.Graphics.DrawEllipse(new Pen(new SolidBrush(Color.White), 1), new Rectangle(x - 2, y - 2, x1 + 4, x1 + 4));
                x = x + 15;
                y = y - 5;
                if (x == 275)
                {
                    y = 30;
                }
            }
        }

        public void MidfieldPlayers(PaintEventArgs e)
        {
            int x = 238, y = 50, x1 = 9, y1 = 13;
            for (int i = 0; i < 4; i++)
            {
                e.Graphics.FillEllipse(new SolidBrush(System.Drawing.Color.White), x, y, x1, x1);
                e.Graphics.DrawEllipse(new Pen(new SolidBrush(Color.White), 1), new Rectangle(x - 2, y - 2, x1 + 4, x1 + 4));
                x = x + 15;
            }
        }
        public void DefancePlayers(PaintEventArgs e)
        {
            int x = 238, y = 70, x1 = 9, y1 = 13;
            for (int i = 0; i < 4; i++)
            {
                e.Graphics.FillEllipse(new SolidBrush(System.Drawing.Color.White), x, y, x1, x1);
                e.Graphics.DrawEllipse(new Pen(new SolidBrush(Color.White), 1), new Rectangle(x - 2, y - 2, x1 + 4, x1 + 4));
                x = x + 15;
            }
        }
    }

}

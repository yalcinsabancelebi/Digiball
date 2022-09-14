namespace Digiball
{
    partial class StaffList
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffList));
            this.positionlbl = new System.Windows.Forms.Label();
            this.namesurnamelbl = new System.Windows.Forms.Label();
            this.agelbl = new System.Windows.Forms.Label();
            this.rolelbl = new System.Windows.Forms.Label();
            this.playerpic = new System.Windows.Forms.PictureBox();
            this.formanolbl = new System.Windows.Forms.Label();
            this.star4 = new System.Windows.Forms.PictureBox();
            this.star3 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            this.star1 = new System.Windows.Forms.PictureBox();
            this.star5 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fwability = new System.Windows.Forms.Label();
            this.mfability = new System.Windows.Forms.Label();
            this.dfability = new System.Windows.Forms.Label();
            this.gkability = new System.Windows.Forms.Label();
            this.staffpanel = new System.Windows.Forms.Panel();
            this.heightlbl = new System.Windows.Forms.Label();
            this.weightlbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.staffpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // positionlbl
            // 
            this.positionlbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.positionlbl.AutoSize = true;
            this.positionlbl.BackColor = System.Drawing.Color.Transparent;
            this.positionlbl.ForeColor = System.Drawing.Color.White;
            this.positionlbl.Location = new System.Drawing.Point(54, 15);
            this.positionlbl.Name = "positionlbl";
            this.positionlbl.Size = new System.Drawing.Size(39, 15);
            this.positionlbl.TabIndex = 1;
            this.positionlbl.Text = "Mevki";
            // 
            // namesurnamelbl
            // 
            this.namesurnamelbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.namesurnamelbl.AutoSize = true;
            this.namesurnamelbl.BackColor = System.Drawing.Color.Transparent;
            this.namesurnamelbl.ForeColor = System.Drawing.Color.White;
            this.namesurnamelbl.Location = new System.Drawing.Point(206, 15);
            this.namesurnamelbl.Name = "namesurnamelbl";
            this.namesurnamelbl.Size = new System.Drawing.Size(89, 15);
            this.namesurnamelbl.TabIndex = 2;
            this.namesurnamelbl.Text = "Name Surname";
            // 
            // agelbl
            // 
            this.agelbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.agelbl.AutoSize = true;
            this.agelbl.BackColor = System.Drawing.Color.Transparent;
            this.agelbl.ForeColor = System.Drawing.Color.White;
            this.agelbl.Location = new System.Drawing.Point(206, 30);
            this.agelbl.Name = "agelbl";
            this.agelbl.Size = new System.Drawing.Size(19, 15);
            this.agelbl.TabIndex = 5;
            this.agelbl.Text = "23";
            // 
            // rolelbl
            // 
            this.rolelbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rolelbl.AutoSize = true;
            this.rolelbl.BackColor = System.Drawing.Color.Transparent;
            this.rolelbl.ForeColor = System.Drawing.Color.White;
            this.rolelbl.Location = new System.Drawing.Point(54, 30);
            this.rolelbl.Name = "rolelbl";
            this.rolelbl.Size = new System.Drawing.Size(24, 15);
            this.rolelbl.TabIndex = 10;
            this.rolelbl.Text = "Rol";
            // 
            // playerpic
            // 
            this.playerpic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.playerpic.BackColor = System.Drawing.Color.Transparent;
            this.playerpic.Image = ((System.Drawing.Image)(resources.GetObject("playerpic.Image")));
            this.playerpic.Location = new System.Drawing.Point(154, 6);
            this.playerpic.Name = "playerpic";
            this.playerpic.Size = new System.Drawing.Size(48, 48);
            this.playerpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerpic.TabIndex = 11;
            this.playerpic.TabStop = false;
            // 
            // formanolbl
            // 
            this.formanolbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.formanolbl.AutoSize = true;
            this.formanolbl.BackColor = System.Drawing.Color.Transparent;
            this.formanolbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formanolbl.ForeColor = System.Drawing.Color.White;
            this.formanolbl.Location = new System.Drawing.Point(6, 20);
            this.formanolbl.Name = "formanolbl";
            this.formanolbl.Size = new System.Drawing.Size(34, 20);
            this.formanolbl.TabIndex = 12;
            this.formanolbl.Text = "#22";
            // 
            // star4
            // 
            this.star4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.star4.BackColor = System.Drawing.Color.Transparent;
            this.star4.Image = ((System.Drawing.Image)(resources.GetObject("star4.Image")));
            this.star4.Location = new System.Drawing.Point(396, 22);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(16, 16);
            this.star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star4.TabIndex = 13;
            this.star4.TabStop = false;
            // 
            // star3
            // 
            this.star3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.star3.BackColor = System.Drawing.Color.Transparent;
            this.star3.Image = ((System.Drawing.Image)(resources.GetObject("star3.Image")));
            this.star3.Location = new System.Drawing.Point(377, 22);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(16, 16);
            this.star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star3.TabIndex = 14;
            this.star3.TabStop = false;
            // 
            // star2
            // 
            this.star2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.star2.BackColor = System.Drawing.Color.Transparent;
            this.star2.Image = ((System.Drawing.Image)(resources.GetObject("star2.Image")));
            this.star2.Location = new System.Drawing.Point(358, 22);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(16, 16);
            this.star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star2.TabIndex = 15;
            this.star2.TabStop = false;
            // 
            // star1
            // 
            this.star1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.star1.BackColor = System.Drawing.Color.Transparent;
            this.star1.Image = ((System.Drawing.Image)(resources.GetObject("star1.Image")));
            this.star1.Location = new System.Drawing.Point(339, 22);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(16, 16);
            this.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star1.TabIndex = 16;
            this.star1.TabStop = false;
            // 
            // star5
            // 
            this.star5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.star5.BackColor = System.Drawing.Color.Transparent;
            this.star5.Image = ((System.Drawing.Image)(resources.GetObject("star5.Image")));
            this.star5.Location = new System.Drawing.Point(414, 22);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(16, 16);
            this.star5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star5.TabIndex = 19;
            this.star5.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.fwability, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.mfability, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dfability, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gkability, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(460, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 23, 0, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(164, 60);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // fwability
            // 
            this.fwability.AutoSize = true;
            this.fwability.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fwability.ForeColor = System.Drawing.Color.White;
            this.fwability.Location = new System.Drawing.Point(127, 23);
            this.fwability.Name = "fwability";
            this.fwability.Size = new System.Drawing.Size(21, 15);
            this.fwability.TabIndex = 3;
            this.fwability.Text = "00";
            // 
            // mfability
            // 
            this.mfability.AutoSize = true;
            this.mfability.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mfability.ForeColor = System.Drawing.Color.White;
            this.mfability.Location = new System.Drawing.Point(89, 23);
            this.mfability.Name = "mfability";
            this.mfability.Size = new System.Drawing.Size(21, 15);
            this.mfability.TabIndex = 2;
            this.mfability.Text = "00";
            // 
            // dfability
            // 
            this.dfability.AutoSize = true;
            this.dfability.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dfability.ForeColor = System.Drawing.Color.White;
            this.dfability.Location = new System.Drawing.Point(51, 23);
            this.dfability.Name = "dfability";
            this.dfability.Size = new System.Drawing.Size(21, 15);
            this.dfability.TabIndex = 1;
            this.dfability.Text = "00";
            // 
            // gkability
            // 
            this.gkability.AutoSize = true;
            this.gkability.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gkability.ForeColor = System.Drawing.Color.White;
            this.gkability.Location = new System.Drawing.Point(13, 23);
            this.gkability.Name = "gkability";
            this.gkability.Size = new System.Drawing.Size(21, 15);
            this.gkability.TabIndex = 0;
            this.gkability.Text = "00";
            // 
            // staffpanel
            // 
<<<<<<< HEAD
            this.staffpanel.AllowDrop = true;
=======
>>>>>>> fd53677075a9f715ca932c6bb62448e4bb2c0061
            this.staffpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.staffpanel.Controls.Add(this.formanolbl);
            this.staffpanel.Controls.Add(this.positionlbl);
            this.staffpanel.Controls.Add(this.star5);
            this.staffpanel.Controls.Add(this.rolelbl);
            this.staffpanel.Controls.Add(this.star1);
            this.staffpanel.Controls.Add(this.star2);
            this.staffpanel.Controls.Add(this.playerpic);
            this.staffpanel.Controls.Add(this.star3);
            this.staffpanel.Controls.Add(this.namesurnamelbl);
            this.staffpanel.Controls.Add(this.star4);
            this.staffpanel.Controls.Add(this.agelbl);
            this.staffpanel.Location = new System.Drawing.Point(0, 0);
            this.staffpanel.Name = "staffpanel";
            this.staffpanel.Size = new System.Drawing.Size(460, 60);
            this.staffpanel.TabIndex = 21;
<<<<<<< HEAD
            this.staffpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.staffpanel_MouseDown);
=======
>>>>>>> fd53677075a9f715ca932c6bb62448e4bb2c0061
            // 
            // heightlbl
            // 
            this.heightlbl.AutoSize = true;
            this.heightlbl.Location = new System.Drawing.Point(633, 15);
            this.heightlbl.Name = "heightlbl";
            this.heightlbl.Size = new System.Drawing.Size(45, 15);
            this.heightlbl.TabIndex = 22;
            this.heightlbl.Text = "181 cm";
            // 
            // weightlbl
            // 
            this.weightlbl.AutoSize = true;
            this.weightlbl.Location = new System.Drawing.Point(633, 30);
            this.weightlbl.Name = "weightlbl";
            this.weightlbl.Size = new System.Drawing.Size(35, 15);
            this.weightlbl.TabIndex = 23;
            this.weightlbl.Text = "74 kg";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(690, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // StaffList
            // 
<<<<<<< HEAD
            this.AllowDrop = true;
=======
>>>>>>> fd53677075a9f715ca932c6bb62448e4bb2c0061
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.weightlbl);
            this.Controls.Add(this.heightlbl);
            this.Controls.Add(this.staffpanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "StaffList";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(725, 60);
            this.Load += new System.EventHandler(this.StaffList_Load);
<<<<<<< HEAD
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StaffList_MouseDown);
=======
>>>>>>> fd53677075a9f715ca932c6bb62448e4bb2c0061
            ((System.ComponentModel.ISupportInitialize)(this.playerpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.staffpanel.ResumeLayout(false);
            this.staffpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label positionlbl;
        private Label namesurnamelbl;
        private Label agelbl;
        private Label rolelbl;
        private PictureBox playerpic;
        private Label formanolbl;
        private PictureBox star4;
        private PictureBox star3;
        private PictureBox star2;
        private PictureBox star1;
        private PictureBox star5;
        private TableLayoutPanel tableLayoutPanel1;
        private Label fwability;
        private Label mfability;
        private Label dfability;
        private Label gkability;
        private Panel staffpanel;
        private Label heightlbl;
        private Label weightlbl;
        private PictureBox pictureBox1;
    }
}

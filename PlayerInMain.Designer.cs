namespace Digiball
{
    partial class PlayerInMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.teamlogopic = new System.Windows.Forms.PictureBox();
            this.playerpic = new System.Windows.Forms.PictureBox();
            this.flag = new System.Windows.Forms.PictureBox();
            this.countrylbl = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teamlogopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flag)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(112, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(112, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // teamlogopic
            // 
            this.teamlogopic.BackColor = System.Drawing.Color.Transparent;
            this.teamlogopic.Image = global::Digiball.Properties.Resources.icons8_knight_shield_72;
            this.teamlogopic.Location = new System.Drawing.Point(5, 2);
            this.teamlogopic.Margin = new System.Windows.Forms.Padding(0);
            this.teamlogopic.Name = "teamlogopic";
            this.teamlogopic.Size = new System.Drawing.Size(96, 96);
            this.teamlogopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.teamlogopic.TabIndex = 3;
            this.teamlogopic.TabStop = false;
            // 
            // playerpic
            // 
            this.playerpic.BackColor = System.Drawing.Color.Transparent;
            this.playerpic.Image = global::Digiball.Properties.Resources.icons8_person_72;
            this.playerpic.Location = new System.Drawing.Point(21, 26);
            this.playerpic.Margin = new System.Windows.Forms.Padding(0);
            this.playerpic.Name = "playerpic";
            this.playerpic.Size = new System.Drawing.Size(72, 72);
            this.playerpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerpic.TabIndex = 4;
            this.playerpic.TabStop = false;
            // 
            // flag
            // 
            this.flag.BackColor = System.Drawing.Color.Transparent;
            this.flag.Location = new System.Drawing.Point(112, 13);
            this.flag.Name = "flag";
            this.flag.Size = new System.Drawing.Size(16, 17);
            this.flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flag.TabIndex = 6;
            this.flag.TabStop = false;
            // 
            // countrylbl
            // 
            this.countrylbl.AutoSize = true;
            this.countrylbl.BackColor = System.Drawing.Color.Transparent;
            this.countrylbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.countrylbl.Location = new System.Drawing.Point(129, 14);
            this.countrylbl.Name = "countrylbl";
            this.countrylbl.Size = new System.Drawing.Size(38, 15);
            this.countrylbl.TabIndex = 7;
            this.countrylbl.Text = "label2";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.BackColor = System.Drawing.Color.Transparent;
            this.position.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.position.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.position.Location = new System.Drawing.Point(112, 68);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(54, 17);
            this.position.TabIndex = 8;
            this.position.Text = "Position";
            // 
            // PlayerInMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.position);
            this.Controls.Add(this.countrylbl);
            this.Controls.Add(this.flag);
            this.Controls.Add(this.playerpic);
            this.Controls.Add(this.teamlogopic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Name = "PlayerInMain";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Size = new System.Drawing.Size(300, 100);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PlayerInMain_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.teamlogopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label3;
        private PictureBox teamlogopic;
        private PictureBox playerpic;
        private PictureBox flag;
        private Label countrylbl;
        private Label position;
    }
}

namespace ProjectAkhir
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lokasiDalamNegeriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lokasiLuarNegeriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDataToolStripMenuItem,
            this.keluarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(939, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createDataToolStripMenuItem
            // 
            this.createDataToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.createDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lokasiDalamNegeriToolStripMenuItem,
            this.lokasiLuarNegeriToolStripMenuItem});
            this.createDataToolStripMenuItem.Name = "createDataToolStripMenuItem";
            this.createDataToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.createDataToolStripMenuItem.Text = "Kelola Data";
            this.createDataToolStripMenuItem.Click += new System.EventHandler(this.createDataToolStripMenuItem_Click);
            // 
            // lokasiDalamNegeriToolStripMenuItem
            // 
            this.lokasiDalamNegeriToolStripMenuItem.BackColor = System.Drawing.Color.DarkSalmon;
            this.lokasiDalamNegeriToolStripMenuItem.Name = "lokasiDalamNegeriToolStripMenuItem";
            this.lokasiDalamNegeriToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.lokasiDalamNegeriToolStripMenuItem.Text = "Lokasi Dalam Negeri";
            this.lokasiDalamNegeriToolStripMenuItem.Click += new System.EventHandler(this.lokasiDalamNegeriToolStripMenuItem_Click);
            // 
            // lokasiLuarNegeriToolStripMenuItem
            // 
            this.lokasiLuarNegeriToolStripMenuItem.BackColor = System.Drawing.Color.LightSalmon;
            this.lokasiLuarNegeriToolStripMenuItem.Name = "lokasiLuarNegeriToolStripMenuItem";
            this.lokasiLuarNegeriToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.lokasiLuarNegeriToolStripMenuItem.Text = "Lokasi Luar Negeri";
            this.lokasiLuarNegeriToolStripMenuItem.Click += new System.EventHandler(this.lokasiLuarNegeriToolStripMenuItem_Click);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = global::ProjectAkhir.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(939, 514);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "home";
            this.Text = "HOME";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lokasiDalamNegeriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lokasiLuarNegeriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
    }
}
namespace PPE3_Leviathan
{
    partial class FrmMission1
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
            this.mesInformationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesVisiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parSecteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parRégionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesInformationsToolStripMenuItem,
            this.lesVisiteursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mesInformationsToolStripMenuItem
            // 
            this.mesInformationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterToolStripMenuItem});
            this.mesInformationsToolStripMenuItem.Name = "mesInformationsToolStripMenuItem";
            this.mesInformationsToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.mesInformationsToolStripMenuItem.Text = "Mes Informations";
            // 
            // consulterToolStripMenuItem
            // 
            this.consulterToolStripMenuItem.Name = "consulterToolStripMenuItem";
            this.consulterToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.consulterToolStripMenuItem.Text = "Consulter mes Informations";
            this.consulterToolStripMenuItem.Click += new System.EventHandler(this.ConsulterToolStripMenuItem_Click);
            // 
            // lesVisiteursToolStripMenuItem
            // 
            this.lesVisiteursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parSecteursToolStripMenuItem,
            this.parRégionsToolStripMenuItem,
            this.globalToolStripMenuItem});
            this.lesVisiteursToolStripMenuItem.Name = "lesVisiteursToolStripMenuItem";
            this.lesVisiteursToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.lesVisiteursToolStripMenuItem.Text = "Les Visiteurs";
            // 
            // parSecteursToolStripMenuItem
            // 
            this.parSecteursToolStripMenuItem.Name = "parSecteursToolStripMenuItem";
            this.parSecteursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.parSecteursToolStripMenuItem.Text = "Par Secteurs";
            // 
            // parRégionsToolStripMenuItem
            // 
            this.parRégionsToolStripMenuItem.Name = "parRégionsToolStripMenuItem";
            this.parRégionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.parRégionsToolStripMenuItem.Text = "Par Régions";
            // 
            // globalToolStripMenuItem
            // 
            this.globalToolStripMenuItem.Name = "globalToolStripMenuItem";
            this.globalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.globalToolStripMenuItem.Text = "Global";
            // 
            // FrmMission1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMission1";
            this.Text = "Visiteur";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mesInformationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesVisiteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parSecteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parRégionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem globalToolStripMenuItem;
    }
}
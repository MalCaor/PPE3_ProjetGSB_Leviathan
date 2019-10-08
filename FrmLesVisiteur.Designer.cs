namespace PPE3_Leviathan
{
    partial class FrmLesVisiteur
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
            this.components = new System.ComponentModel.Container();
            this.dgvVisiteurs = new System.Windows.Forms.DataGridView();
            this.bsVisiteurs = new System.Windows.Forms.BindingSource(this.components);
            this.cboChoixAffichage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisiteurs
            // 
            this.dgvVisiteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteurs.Location = new System.Drawing.Point(58, 117);
            this.dgvVisiteurs.Name = "dgvVisiteurs";
            this.dgvVisiteurs.Size = new System.Drawing.Size(667, 288);
            this.dgvVisiteurs.TabIndex = 0;
            // 
            // cboChoixAffichage
            // 
            this.cboChoixAffichage.FormattingEnabled = true;
            this.cboChoixAffichage.Location = new System.Drawing.Point(58, 46);
            this.cboChoixAffichage.Name = "cboChoixAffichage";
            this.cboChoixAffichage.Size = new System.Drawing.Size(121, 21);
            this.cboChoixAffichage.TabIndex = 1;
            // 
            // FrmLesVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboChoixAffichage);
            this.Controls.Add(this.dgvVisiteurs);
            this.Name = "FrmLesVisiteur";
            this.Text = "FrmLesVisiteur";
            this.Load += new System.EventHandler(this.FrmLesVisiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsVisiteurs;
        private System.Windows.Forms.DataGridView dgvVisiteurs;
        private System.Windows.Forms.ComboBox cboChoixAffichage;
    }
}
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
            this.lblTest1 = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
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
            // bsVisiteurs
            // 
            this.bsVisiteurs.CurrentChanged += new System.EventHandler(this.BsVisiteurs_CurrentChanged);
            // 
            // cboChoixAffichage
            // 
            this.cboChoixAffichage.FormattingEnabled = true;
            this.cboChoixAffichage.Location = new System.Drawing.Point(58, 46);
            this.cboChoixAffichage.Name = "cboChoixAffichage";
            this.cboChoixAffichage.Size = new System.Drawing.Size(121, 21);
            this.cboChoixAffichage.TabIndex = 1;
            // 
            // lblTest1
            // 
            this.lblTest1.AutoSize = true;
            this.lblTest1.Location = new System.Drawing.Point(332, 46);
            this.lblTest1.Name = "lblTest1";
            this.lblTest1.Size = new System.Drawing.Size(35, 13);
            this.lblTest1.TabIndex = 2;
            this.lblTest1.Text = "label1";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(649, 415);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 3;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // FrmLesVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblTest1);
            this.Controls.Add(this.cboChoixAffichage);
            this.Controls.Add(this.dgvVisiteurs);
            this.Name = "FrmLesVisiteur";
            this.Text = "FrmLesVisiteur";
            this.Load += new System.EventHandler(this.FrmLesVisiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsVisiteurs;
        private System.Windows.Forms.DataGridView dgvVisiteurs;
        private System.Windows.Forms.ComboBox cboChoixAffichage;
        private System.Windows.Forms.Label lblTest1;
        private System.Windows.Forms.Button btnRetour;
    }
}
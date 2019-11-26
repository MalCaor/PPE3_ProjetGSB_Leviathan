namespace PPE3_Leviathan
{
    partial class FrmGestionRegion
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
            this.cboGestionRegion = new System.Windows.Forms.ComboBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.rtbMotifFinContrat = new System.Windows.Forms.RichTextBox();
            this.dtpDateFinContrat = new System.Windows.Forms.DateTimePicker();
            this.btnMettreFinContrat = new System.Windows.Forms.Button();
            this.lblResponsableRegionsActuel = new System.Windows.Forms.Label();
            this.lblCurrentVisiteur = new System.Windows.Forms.Label();
            this.btnRendreInactif = new System.Windows.Forms.Button();
            this.btnRendreActif = new System.Windows.Forms.Button();
            this.cboRegionPourResponsabilite = new System.Windows.Forms.ComboBox();
            this.lblResponsableRegion = new System.Windows.Forms.Label();
            this.btnValiderResponsable = new System.Windows.Forms.Button();
            this.dgvVisiteurGestion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurGestion)).BeginInit();
            this.SuspendLayout();
            // 
            // cboGestionRegion
            // 
            this.cboGestionRegion.FormattingEnabled = true;
            this.cboGestionRegion.Location = new System.Drawing.Point(12, 12);
            this.cboGestionRegion.Name = "cboGestionRegion";
            this.cboGestionRegion.Size = new System.Drawing.Size(121, 21);
            this.cboGestionRegion.TabIndex = 1;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(170, 15);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(109, 13);
            this.lblResponsable.TabIndex = 6;
            this.lblResponsable.Text = "Responsable Secteur";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(804, 12);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(98, 34);
            this.btnRetour.TabIndex = 7;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // rtbMotifFinContrat
            // 
            this.rtbMotifFinContrat.Location = new System.Drawing.Point(574, 290);
            this.rtbMotifFinContrat.Name = "rtbMotifFinContrat";
            this.rtbMotifFinContrat.Size = new System.Drawing.Size(333, 82);
            this.rtbMotifFinContrat.TabIndex = 27;
            this.rtbMotifFinContrat.Text = "";
            // 
            // dtpDateFinContrat
            // 
            this.dtpDateFinContrat.Location = new System.Drawing.Point(574, 264);
            this.dtpDateFinContrat.Name = "dtpDateFinContrat";
            this.dtpDateFinContrat.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFinContrat.TabIndex = 26;
            // 
            // btnMettreFinContrat
            // 
            this.btnMettreFinContrat.Location = new System.Drawing.Point(780, 263);
            this.btnMettreFinContrat.Name = "btnMettreFinContrat";
            this.btnMettreFinContrat.Size = new System.Drawing.Size(127, 23);
            this.btnMettreFinContrat.TabIndex = 25;
            this.btnMettreFinContrat.Text = "Mettre Fin au Contrat";
            this.btnMettreFinContrat.UseVisualStyleBackColor = true;
            // 
            // lblResponsableRegionsActuel
            // 
            this.lblResponsableRegionsActuel.AutoSize = true;
            this.lblResponsableRegionsActuel.Location = new System.Drawing.Point(5, 356);
            this.lblResponsableRegionsActuel.Name = "lblResponsableRegionsActuel";
            this.lblResponsableRegionsActuel.Size = new System.Drawing.Size(157, 13);
            this.lblResponsableRegionsActuel.TabIndex = 24;
            this.lblResponsableRegionsActuel.Text = "Label des responsabelde region";
            // 
            // lblCurrentVisiteur
            // 
            this.lblCurrentVisiteur.AutoSize = true;
            this.lblCurrentVisiteur.Location = new System.Drawing.Point(5, 312);
            this.lblCurrentVisiteur.Name = "lblCurrentVisiteur";
            this.lblCurrentVisiteur.Size = new System.Drawing.Size(136, 13);
            this.lblCurrentVisiteur.TabIndex = 23;
            this.lblCurrentVisiteur.Text = "VisiteurNom VisiteurPrenom";
            // 
            // btnRendreInactif
            // 
            this.btnRendreInactif.Location = new System.Drawing.Point(263, 307);
            this.btnRendreInactif.Name = "btnRendreInactif";
            this.btnRendreInactif.Size = new System.Drawing.Size(110, 23);
            this.btnRendreInactif.TabIndex = 22;
            this.btnRendreInactif.Text = "Rendre Inactif";
            this.btnRendreInactif.UseVisualStyleBackColor = true;
            // 
            // btnRendreActif
            // 
            this.btnRendreActif.Location = new System.Drawing.Point(147, 307);
            this.btnRendreActif.Name = "btnRendreActif";
            this.btnRendreActif.Size = new System.Drawing.Size(110, 23);
            this.btnRendreActif.TabIndex = 21;
            this.btnRendreActif.Text = "Rendre Actif";
            this.btnRendreActif.UseVisualStyleBackColor = true;
            // 
            // cboRegionPourResponsabilite
            // 
            this.cboRegionPourResponsabilite.FormattingEnabled = true;
            this.cboRegionPourResponsabilite.Location = new System.Drawing.Point(313, 263);
            this.cboRegionPourResponsabilite.Name = "cboRegionPourResponsabilite";
            this.cboRegionPourResponsabilite.Size = new System.Drawing.Size(121, 21);
            this.cboRegionPourResponsabilite.TabIndex = 20;
            // 
            // lblResponsableRegion
            // 
            this.lblResponsableRegion.AutoSize = true;
            this.lblResponsableRegion.Location = new System.Drawing.Point(5, 266);
            this.lblResponsableRegion.Name = "lblResponsableRegion";
            this.lblResponsableRegion.Size = new System.Drawing.Size(302, 13);
            this.lblResponsableRegion.TabIndex = 19;
            this.lblResponsableRegion.Text = "Nommer VisiteurNom VisiteurPrenom responsable de la région :";
            // 
            // btnValiderResponsable
            // 
            this.btnValiderResponsable.Location = new System.Drawing.Point(440, 263);
            this.btnValiderResponsable.Name = "btnValiderResponsable";
            this.btnValiderResponsable.Size = new System.Drawing.Size(110, 23);
            this.btnValiderResponsable.TabIndex = 18;
            this.btnValiderResponsable.Text = "Valider changement";
            this.btnValiderResponsable.UseVisualStyleBackColor = true;
            // 
            // dgvVisiteurGestion
            // 
            this.dgvVisiteurGestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteurGestion.Location = new System.Drawing.Point(8, 52);
            this.dgvVisiteurGestion.Name = "dgvVisiteurGestion";
            this.dgvVisiteurGestion.Size = new System.Drawing.Size(898, 197);
            this.dgvVisiteurGestion.TabIndex = 28;
            // 
            // FrmGestionRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.dgvVisiteurGestion);
            this.Controls.Add(this.rtbMotifFinContrat);
            this.Controls.Add(this.dtpDateFinContrat);
            this.Controls.Add(this.btnMettreFinContrat);
            this.Controls.Add(this.lblResponsableRegionsActuel);
            this.Controls.Add(this.lblCurrentVisiteur);
            this.Controls.Add(this.btnRendreInactif);
            this.Controls.Add(this.btnRendreActif);
            this.Controls.Add(this.cboRegionPourResponsabilite);
            this.Controls.Add(this.lblResponsableRegion);
            this.Controls.Add(this.btnValiderResponsable);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.cboGestionRegion);
            this.Name = "FrmGestionRegion";
            this.Text = "FrmGestionRegion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurGestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboGestionRegion;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.RichTextBox rtbMotifFinContrat;
        private System.Windows.Forms.DateTimePicker dtpDateFinContrat;
        private System.Windows.Forms.Button btnMettreFinContrat;
        private System.Windows.Forms.Label lblResponsableRegionsActuel;
        private System.Windows.Forms.Label lblCurrentVisiteur;
        private System.Windows.Forms.Button btnRendreInactif;
        private System.Windows.Forms.Button btnRendreActif;
        private System.Windows.Forms.ComboBox cboRegionPourResponsabilite;
        private System.Windows.Forms.Label lblResponsableRegion;
        private System.Windows.Forms.Button btnValiderResponsable;
        private System.Windows.Forms.DataGridView dgvVisiteurGestion;
    }
}
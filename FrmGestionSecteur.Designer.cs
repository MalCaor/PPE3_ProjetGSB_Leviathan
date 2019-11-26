namespace PPE3_Leviathan
{
    partial class FrmGestionSecteur
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
            this.bsGestionSecteur = new System.Windows.Forms.BindingSource(this.components);
            this.cboGestionSecteur = new System.Windows.Forms.ComboBox();
            this.dgvVisiteurGestion = new System.Windows.Forms.DataGridView();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.btnValiderResponsable = new System.Windows.Forms.Button();
            this.lblResponsableRegion = new System.Windows.Forms.Label();
            this.cboRegionPourResponsabilite = new System.Windows.Forms.ComboBox();
            this.bsRegion = new System.Windows.Forms.BindingSource(this.components);
            this.btnRendreActif = new System.Windows.Forms.Button();
            this.btnRendreInactif = new System.Windows.Forms.Button();
            this.lblCurrentVisiteur = new System.Windows.Forms.Label();
            this.lblResponsableRegionsActuel = new System.Windows.Forms.Label();
            this.btnMettreFinContrat = new System.Windows.Forms.Button();
            this.dtpDateFinContrat = new System.Windows.Forms.DateTimePicker();
            this.rtbMotifFinContrat = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsGestionSecteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurGestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // bsGestionSecteur
            // 
            this.bsGestionSecteur.CurrentChanged += new System.EventHandler(this.BsGestionSecteur_CurrentChanged);
            // 
            // cboGestionSecteur
            // 
            this.cboGestionSecteur.FormattingEnabled = true;
            this.cboGestionSecteur.Location = new System.Drawing.Point(32, 33);
            this.cboGestionSecteur.Name = "cboGestionSecteur";
            this.cboGestionSecteur.Size = new System.Drawing.Size(121, 21);
            this.cboGestionSecteur.TabIndex = 0;
            // 
            // dgvVisiteurGestion
            // 
            this.dgvVisiteurGestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteurGestion.Location = new System.Drawing.Point(32, 83);
            this.dgvVisiteurGestion.Name = "dgvVisiteurGestion";
            this.dgvVisiteurGestion.Size = new System.Drawing.Size(898, 197);
            this.dgvVisiteurGestion.TabIndex = 1;
            this.dgvVisiteurGestion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // bsVisiteur
            // 
            this.bsVisiteur.CurrentChanged += new System.EventHandler(this.BsVisiteur_CurrentChanged);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(810, 25);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(98, 34);
            this.btnRetour.TabIndex = 4;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(204, 36);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(109, 13);
            this.lblResponsable.TabIndex = 5;
            this.lblResponsable.Text = "Responsable Secteur";
            // 
            // btnValiderResponsable
            // 
            this.btnValiderResponsable.Location = new System.Drawing.Point(470, 303);
            this.btnValiderResponsable.Name = "btnValiderResponsable";
            this.btnValiderResponsable.Size = new System.Drawing.Size(110, 23);
            this.btnValiderResponsable.TabIndex = 8;
            this.btnValiderResponsable.Text = "Valider changement";
            this.btnValiderResponsable.UseVisualStyleBackColor = true;
            this.btnValiderResponsable.Click += new System.EventHandler(this.BtnValiderResponsable_Click);
            // 
            // lblResponsableRegion
            // 
            this.lblResponsableRegion.AutoSize = true;
            this.lblResponsableRegion.Location = new System.Drawing.Point(35, 306);
            this.lblResponsableRegion.Name = "lblResponsableRegion";
            this.lblResponsableRegion.Size = new System.Drawing.Size(302, 13);
            this.lblResponsableRegion.TabIndex = 9;
            this.lblResponsableRegion.Text = "Nommer VisiteurNom VisiteurPrenom responsable de la région :";
            // 
            // cboRegionPourResponsabilite
            // 
            this.cboRegionPourResponsabilite.FormattingEnabled = true;
            this.cboRegionPourResponsabilite.Location = new System.Drawing.Point(343, 303);
            this.cboRegionPourResponsabilite.Name = "cboRegionPourResponsabilite";
            this.cboRegionPourResponsabilite.Size = new System.Drawing.Size(121, 21);
            this.cboRegionPourResponsabilite.TabIndex = 10;
            // 
            // btnRendreActif
            // 
            this.btnRendreActif.Location = new System.Drawing.Point(177, 347);
            this.btnRendreActif.Name = "btnRendreActif";
            this.btnRendreActif.Size = new System.Drawing.Size(110, 23);
            this.btnRendreActif.TabIndex = 11;
            this.btnRendreActif.Text = "Rendre Actif";
            this.btnRendreActif.UseVisualStyleBackColor = true;
            this.btnRendreActif.Click += new System.EventHandler(this.BtnRendreActif_Click);
            // 
            // btnRendreInactif
            // 
            this.btnRendreInactif.Location = new System.Drawing.Point(293, 347);
            this.btnRendreInactif.Name = "btnRendreInactif";
            this.btnRendreInactif.Size = new System.Drawing.Size(110, 23);
            this.btnRendreInactif.TabIndex = 12;
            this.btnRendreInactif.Text = "Rendre Inactif";
            this.btnRendreInactif.UseVisualStyleBackColor = true;
            this.btnRendreInactif.Click += new System.EventHandler(this.BtnRendreInactif_Click);
            // 
            // lblCurrentVisiteur
            // 
            this.lblCurrentVisiteur.AutoSize = true;
            this.lblCurrentVisiteur.Location = new System.Drawing.Point(35, 352);
            this.lblCurrentVisiteur.Name = "lblCurrentVisiteur";
            this.lblCurrentVisiteur.Size = new System.Drawing.Size(136, 13);
            this.lblCurrentVisiteur.TabIndex = 13;
            this.lblCurrentVisiteur.Text = "VisiteurNom VisiteurPrenom";
            // 
            // lblResponsableRegionsActuel
            // 
            this.lblResponsableRegionsActuel.AutoSize = true;
            this.lblResponsableRegionsActuel.Location = new System.Drawing.Point(35, 396);
            this.lblResponsableRegionsActuel.Name = "lblResponsableRegionsActuel";
            this.lblResponsableRegionsActuel.Size = new System.Drawing.Size(157, 13);
            this.lblResponsableRegionsActuel.TabIndex = 14;
            this.lblResponsableRegionsActuel.Text = "Label des responsabelde region";
            // 
            // btnMettreFinContrat
            // 
            this.btnMettreFinContrat.Location = new System.Drawing.Point(810, 303);
            this.btnMettreFinContrat.Name = "btnMettreFinContrat";
            this.btnMettreFinContrat.Size = new System.Drawing.Size(127, 23);
            this.btnMettreFinContrat.TabIndex = 15;
            this.btnMettreFinContrat.Text = "Mettre Fin au Contrat";
            this.btnMettreFinContrat.UseVisualStyleBackColor = true;
            this.btnMettreFinContrat.Click += new System.EventHandler(this.BtnMettreFinContrat_Click);
            // 
            // dtpDateFinContrat
            // 
            this.dtpDateFinContrat.Location = new System.Drawing.Point(604, 304);
            this.dtpDateFinContrat.Name = "dtpDateFinContrat";
            this.dtpDateFinContrat.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFinContrat.TabIndex = 16;
            // 
            // rtbMotifFinContrat
            // 
            this.rtbMotifFinContrat.Location = new System.Drawing.Point(604, 330);
            this.rtbMotifFinContrat.Name = "rtbMotifFinContrat";
            this.rtbMotifFinContrat.Size = new System.Drawing.Size(333, 82);
            this.rtbMotifFinContrat.TabIndex = 17;
            this.rtbMotifFinContrat.Text = "";
            // 
            // FrmGestionSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 547);
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
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.dgvVisiteurGestion);
            this.Controls.Add(this.cboGestionSecteur);
            this.Name = "FrmGestionSecteur";
            this.Text = "FrmGestionSecteur";
            this.Load += new System.EventHandler(this.FrmGestionSecteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsGestionSecteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurGestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsGestionSecteur;
        private System.Windows.Forms.ComboBox cboGestionSecteur;
        private System.Windows.Forms.DataGridView dgvVisiteurGestion;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Button btnValiderResponsable;
        private System.Windows.Forms.Label lblResponsableRegion;
        private System.Windows.Forms.ComboBox cboRegionPourResponsabilite;
        private System.Windows.Forms.BindingSource bsRegion;
        private System.Windows.Forms.Button btnRendreActif;
        private System.Windows.Forms.Button btnRendreInactif;
        private System.Windows.Forms.Label lblCurrentVisiteur;
        private System.Windows.Forms.Label lblResponsableRegionsActuel;
        private System.Windows.Forms.Button btnMettreFinContrat;
        private System.Windows.Forms.DateTimePicker dtpDateFinContrat;
        private System.Windows.Forms.RichTextBox rtbMotifFinContrat;
    }
}
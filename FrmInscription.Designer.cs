namespace PPE3_Leviathan
{
    partial class FrmInscription
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboVisiteur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomVisiteur = new System.Windows.Forms.TextBox();
            this.txtPrenomVisiteur = new System.Windows.Forms.TextBox();
            this.cboLaboratoire = new System.Windows.Forms.ComboBox();
            this.btnAjouterVisiteur = new System.Windows.Forms.Button();
            this.txtRueVisiteur = new System.Windows.Forms.TextBox();
            this.txtCPVisiteur = new System.Windows.Forms.TextBox();
            this.txtVilleVisiteur = new System.Windows.Forms.TextBox();
            this.dtpDateEmbauche = new System.Windows.Forms.DateTimePicker();
            this.txtIdentifiantVisiteur = new System.Windows.Forms.TextBox();
            this.txtMDPVisiteur = new System.Windows.Forms.TextBox();
            this.txtMDPConfirmer = new System.Windows.Forms.TextBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnCreer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bsAjoutVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.bsLaboratoire = new System.Windows.Forms.BindingSource(this.components);
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.bsRegion = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsAjoutVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLaboratoire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSCRIPTION";
            // 
            // cboVisiteur
            // 
            this.cboVisiteur.FormattingEnabled = true;
            this.cboVisiteur.Location = new System.Drawing.Point(48, 60);
            this.cboVisiteur.Name = "cboVisiteur";
            this.cboVisiteur.Size = new System.Drawing.Size(121, 21);
            this.cboVisiteur.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ajouter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "comme colladorateur dans la Région : ";
            // 
            // txtNomVisiteur
            // 
            this.txtNomVisiteur.Location = new System.Drawing.Point(42, 230);
            this.txtNomVisiteur.Name = "txtNomVisiteur";
            this.txtNomVisiteur.Size = new System.Drawing.Size(100, 20);
            this.txtNomVisiteur.TabIndex = 5;
            // 
            // txtPrenomVisiteur
            // 
            this.txtPrenomVisiteur.Location = new System.Drawing.Point(207, 230);
            this.txtPrenomVisiteur.Name = "txtPrenomVisiteur";
            this.txtPrenomVisiteur.Size = new System.Drawing.Size(100, 20);
            this.txtPrenomVisiteur.TabIndex = 6;
            // 
            // cboLaboratoire
            // 
            this.cboLaboratoire.FormattingEnabled = true;
            this.cboLaboratoire.Location = new System.Drawing.Point(75, 193);
            this.cboLaboratoire.Name = "cboLaboratoire";
            this.cboLaboratoire.Size = new System.Drawing.Size(121, 21);
            this.cboLaboratoire.TabIndex = 7;
            // 
            // btnAjouterVisiteur
            // 
            this.btnAjouterVisiteur.Location = new System.Drawing.Point(48, 98);
            this.btnAjouterVisiteur.Name = "btnAjouterVisiteur";
            this.btnAjouterVisiteur.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterVisiteur.TabIndex = 8;
            this.btnAjouterVisiteur.Text = "Ajouter";
            this.btnAjouterVisiteur.UseVisualStyleBackColor = true;
            this.btnAjouterVisiteur.Click += new System.EventHandler(this.BtnAjouterVisiteur_Click);
            // 
            // txtRueVisiteur
            // 
            this.txtRueVisiteur.Location = new System.Drawing.Point(42, 273);
            this.txtRueVisiteur.Name = "txtRueVisiteur";
            this.txtRueVisiteur.Size = new System.Drawing.Size(100, 20);
            this.txtRueVisiteur.TabIndex = 9;
            // 
            // txtCPVisiteur
            // 
            this.txtCPVisiteur.Location = new System.Drawing.Point(228, 273);
            this.txtCPVisiteur.Name = "txtCPVisiteur";
            this.txtCPVisiteur.Size = new System.Drawing.Size(100, 20);
            this.txtCPVisiteur.TabIndex = 10;
            // 
            // txtVilleVisiteur
            // 
            this.txtVilleVisiteur.Location = new System.Drawing.Point(376, 273);
            this.txtVilleVisiteur.Name = "txtVilleVisiteur";
            this.txtVilleVisiteur.Size = new System.Drawing.Size(100, 20);
            this.txtVilleVisiteur.TabIndex = 11;
            // 
            // dtpDateEmbauche
            // 
            this.dtpDateEmbauche.Location = new System.Drawing.Point(106, 308);
            this.dtpDateEmbauche.Name = "dtpDateEmbauche";
            this.dtpDateEmbauche.Size = new System.Drawing.Size(200, 20);
            this.dtpDateEmbauche.TabIndex = 12;
            // 
            // txtIdentifiantVisiteur
            // 
            this.txtIdentifiantVisiteur.Location = new System.Drawing.Point(68, 341);
            this.txtIdentifiantVisiteur.Name = "txtIdentifiantVisiteur";
            this.txtIdentifiantVisiteur.Size = new System.Drawing.Size(100, 20);
            this.txtIdentifiantVisiteur.TabIndex = 13;
            // 
            // txtMDPVisiteur
            // 
            this.txtMDPVisiteur.Location = new System.Drawing.Point(282, 341);
            this.txtMDPVisiteur.Name = "txtMDPVisiteur";
            this.txtMDPVisiteur.Size = new System.Drawing.Size(100, 20);
            this.txtMDPVisiteur.TabIndex = 14;
            // 
            // txtMDPConfirmer
            // 
            this.txtMDPConfirmer.Location = new System.Drawing.Point(464, 341);
            this.txtMDPConfirmer.Name = "txtMDPConfirmer";
            this.txtMDPConfirmer.Size = new System.Drawing.Size(100, 20);
            this.txtMDPConfirmer.TabIndex = 15;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(523, 12);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 16;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(523, 196);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(75, 23);
            this.btnCreer.TabIndex = 17;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.BtnCreer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Laboratoire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "nom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Prenom";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Rue";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Code Postal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Ville";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Date d\'embauche";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Identifiant";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(204, 344);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Mot de Passe";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(407, 344);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Confirmer";
            // 
            // cboRegion
            // 
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Location = new System.Drawing.Point(369, 60);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(121, 21);
            this.cboRegion.TabIndex = 28;
            // 
            // FrmInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 380);
            this.Controls.Add(this.cboRegion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.txtMDPConfirmer);
            this.Controls.Add(this.txtMDPVisiteur);
            this.Controls.Add(this.txtIdentifiantVisiteur);
            this.Controls.Add(this.dtpDateEmbauche);
            this.Controls.Add(this.txtVilleVisiteur);
            this.Controls.Add(this.txtCPVisiteur);
            this.Controls.Add(this.txtRueVisiteur);
            this.Controls.Add(this.btnAjouterVisiteur);
            this.Controls.Add(this.cboLaboratoire);
            this.Controls.Add(this.txtPrenomVisiteur);
            this.Controls.Add(this.txtNomVisiteur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboVisiteur);
            this.Controls.Add(this.label1);
            this.Name = "FrmInscription";
            this.Text = "FrmInscription";
            this.Load += new System.EventHandler(this.FrmInscription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsAjoutVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLaboratoire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboVisiteur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomVisiteur;
        private System.Windows.Forms.TextBox txtPrenomVisiteur;
        private System.Windows.Forms.ComboBox cboLaboratoire;
        private System.Windows.Forms.Button btnAjouterVisiteur;
        private System.Windows.Forms.TextBox txtRueVisiteur;
        private System.Windows.Forms.TextBox txtCPVisiteur;
        private System.Windows.Forms.TextBox txtVilleVisiteur;
        private System.Windows.Forms.DateTimePicker dtpDateEmbauche;
        private System.Windows.Forms.TextBox txtIdentifiantVisiteur;
        private System.Windows.Forms.TextBox txtMDPVisiteur;
        private System.Windows.Forms.TextBox txtMDPConfirmer;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource bsAjoutVisiteur;
        private System.Windows.Forms.BindingSource bsLaboratoire;
        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.BindingSource bsRegion;
    }
}
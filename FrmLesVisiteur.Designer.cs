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
            this.bsVisiteurs = new System.Windows.Forms.BindingSource(this.components);
            this.cboChoixAffichage = new System.Windows.Forms.ComboBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.rtbListeSelection = new System.Windows.Forms.RichTextBox();
            this.btnGestionLabo = new System.Windows.Forms.Button();
            this.btnGestionSecteur = new System.Windows.Forms.Button();
            this.btnGestionRegion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).BeginInit();
            this.SuspendLayout();
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
            this.cboChoixAffichage.Size = new System.Drawing.Size(165, 21);
            this.cboChoixAffichage.TabIndex = 1;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(551, 418);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(98, 34);
            this.btnRetour.TabIndex = 3;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // rtbListeSelection
            // 
            this.rtbListeSelection.Location = new System.Drawing.Point(58, 92);
            this.rtbListeSelection.Name = "rtbListeSelection";
            this.rtbListeSelection.Size = new System.Drawing.Size(591, 309);
            this.rtbListeSelection.TabIndex = 4;
            this.rtbListeSelection.Text = "";
            // 
            // btnGestionLabo
            // 
            this.btnGestionLabo.Location = new System.Drawing.Point(257, 44);
            this.btnGestionLabo.Name = "btnGestionLabo";
            this.btnGestionLabo.Size = new System.Drawing.Size(104, 23);
            this.btnGestionLabo.TabIndex = 5;
            this.btnGestionLabo.Text = "Gestion du Labo";
            this.btnGestionLabo.UseVisualStyleBackColor = true;
            this.btnGestionLabo.Visible = false;
            // 
            // btnGestionSecteur
            // 
            this.btnGestionSecteur.Location = new System.Drawing.Point(367, 44);
            this.btnGestionSecteur.Name = "btnGestionSecteur";
            this.btnGestionSecteur.Size = new System.Drawing.Size(108, 23);
            this.btnGestionSecteur.TabIndex = 6;
            this.btnGestionSecteur.Text = "Gestion du Secteur";
            this.btnGestionSecteur.UseVisualStyleBackColor = true;
            this.btnGestionSecteur.Visible = false;
            this.btnGestionSecteur.Click += new System.EventHandler(this.BtnGestionSecteur_Click);
            // 
            // btnGestionRegion
            // 
            this.btnGestionRegion.Location = new System.Drawing.Point(481, 44);
            this.btnGestionRegion.Name = "btnGestionRegion";
            this.btnGestionRegion.Size = new System.Drawing.Size(121, 23);
            this.btnGestionRegion.TabIndex = 7;
            this.btnGestionRegion.Text = "Gestion de la Région";
            this.btnGestionRegion.UseVisualStyleBackColor = true;
            this.btnGestionRegion.Visible = false;
            this.btnGestionRegion.Click += new System.EventHandler(this.BtnGestionRegion_Click);
            // 
            // FrmLesVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 464);
            this.Controls.Add(this.btnGestionRegion);
            this.Controls.Add(this.btnGestionSecteur);
            this.Controls.Add(this.btnGestionLabo);
            this.Controls.Add(this.rtbListeSelection);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.cboChoixAffichage);
            this.Name = "FrmLesVisiteur";
            this.Text = "FrmLesVisiteur";
            this.Load += new System.EventHandler(this.FrmLesVisiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsVisiteurs;
        private System.Windows.Forms.ComboBox cboChoixAffichage;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.RichTextBox rtbListeSelection;
        private System.Windows.Forms.Button btnGestionLabo;
        private System.Windows.Forms.Button btnGestionSecteur;
        private System.Windows.Forms.Button btnGestionRegion;
    }
}
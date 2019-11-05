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
            this.cboChoixAffichage.Size = new System.Drawing.Size(121, 21);
            this.cboChoixAffichage.TabIndex = 1;
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
            // rtbListeSelection
            // 
            this.rtbListeSelection.Location = new System.Drawing.Point(58, 92);
            this.rtbListeSelection.Name = "rtbListeSelection";
            this.rtbListeSelection.Size = new System.Drawing.Size(666, 302);
            this.rtbListeSelection.TabIndex = 4;
            this.rtbListeSelection.Text = "";
            // 
            // FrmLesVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}
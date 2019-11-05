namespace PPE3_Leviathan
{
    partial class fModifFF
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
            this.bsFF = new System.Windows.Forms.BindingSource(this.components);
            this.lTitre = new System.Windows.Forms.Label();
            this.lVisiteur = new System.Windows.Forms.Label();
            this.lMatr = new System.Windows.Forms.Label();
            this.lNom = new System.Windows.Forms.Label();
            this.lMois = new System.Windows.Forms.Label();
            this.lFraisFor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lAutoMat = new System.Windows.Forms.Label();
            this.lAutoNom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsFF)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitre
            // 
            this.lTitre.AutoSize = true;
            this.lTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitre.Location = new System.Drawing.Point(13, 13);
            this.lTitre.Name = "lTitre";
            this.lTitre.Size = new System.Drawing.Size(190, 31);
            this.lTitre.TabIndex = 0;
            this.lTitre.Text = "Etat de Frais : ";
            // 
            // lVisiteur
            // 
            this.lVisiteur.AutoSize = true;
            this.lVisiteur.Location = new System.Drawing.Point(19, 67);
            this.lVisiteur.Name = "lVisiteur";
            this.lVisiteur.Size = new System.Drawing.Size(47, 13);
            this.lVisiteur.TabIndex = 1;
            this.lVisiteur.Text = "Visiteur :";
            // 
            // lMatr
            // 
            this.lMatr.AutoSize = true;
            this.lMatr.Location = new System.Drawing.Point(72, 67);
            this.lMatr.Name = "lMatr";
            this.lMatr.Size = new System.Drawing.Size(56, 13);
            this.lMatr.TabIndex = 2;
            this.lMatr.Text = "Matricule :";
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(72, 80);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(35, 13);
            this.lNom.TabIndex = 3;
            this.lNom.Text = "Nom :";
            // 
            // lMois
            // 
            this.lMois.AutoSize = true;
            this.lMois.Location = new System.Drawing.Point(19, 101);
            this.lMois.Name = "lMois";
            this.lMois.Size = new System.Drawing.Size(35, 13);
            this.lMois.TabIndex = 4;
            this.lMois.Text = "Mois :";
            // 
            // lFraisFor
            // 
            this.lFraisFor.AutoSize = true;
            this.lFraisFor.Location = new System.Drawing.Point(19, 123);
            this.lFraisFor.Name = "lFraisFor";
            this.lFraisFor.Size = new System.Drawing.Size(84, 13);
            this.lFraisFor.TabIndex = 5;
            this.lFraisFor.Text = "Frais Forfaitaire :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 7;
            // 
            // lAutoMat
            // 
            this.lAutoMat.AutoSize = true;
            this.lAutoMat.Location = new System.Drawing.Point(134, 67);
            this.lAutoMat.Name = "lAutoMat";
            this.lAutoMat.Size = new System.Drawing.Size(25, 13);
            this.lAutoMat.TabIndex = 8;
            this.lAutoMat.Text = "Mat";
            // 
            // lAutoNom
            // 
            this.lAutoNom.AutoSize = true;
            this.lAutoNom.Location = new System.Drawing.Point(113, 80);
            this.lAutoNom.Name = "lAutoNom";
            this.lAutoNom.Size = new System.Drawing.Size(29, 13);
            this.lAutoNom.TabIndex = 9;
            this.lAutoNom.Text = "Nom";
            // 
            // fModifFF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lAutoNom);
            this.Controls.Add(this.lAutoMat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lFraisFor);
            this.Controls.Add(this.lMois);
            this.Controls.Add(this.lNom);
            this.Controls.Add(this.lMatr);
            this.Controls.Add(this.lVisiteur);
            this.Controls.Add(this.lTitre);
            this.Name = "fModifFF";
            this.Text = "fModifFF";
            this.Load += new System.EventHandler(this.FModifFF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsFF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsFF;
        private System.Windows.Forms.Label lTitre;
        private System.Windows.Forms.Label lVisiteur;
        private System.Windows.Forms.Label lMatr;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label lMois;
        private System.Windows.Forms.Label lFraisFor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lAutoMat;
        private System.Windows.Forms.Label lAutoNom;
    }
}
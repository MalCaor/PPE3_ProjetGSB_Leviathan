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
            this.lMois = new System.Windows.Forms.Label();
            this.lQuantite = new System.Windows.Forms.Label();
            this.tbMois = new System.Windows.Forms.TextBox();
            this.tbQuantite = new System.Windows.Forms.TextBox();
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
            // lMois
            // 
            this.lMois.AutoSize = true;
            this.lMois.Location = new System.Drawing.Point(13, 85);
            this.lMois.Name = "lMois";
            this.lMois.Size = new System.Drawing.Size(35, 13);
            this.lMois.TabIndex = 1;
            this.lMois.Text = "Mois :";
            // 
            // lQuantite
            // 
            this.lQuantite.AutoSize = true;
            this.lQuantite.Location = new System.Drawing.Point(12, 109);
            this.lQuantite.Name = "lQuantite";
            this.lQuantite.Size = new System.Drawing.Size(53, 13);
            this.lQuantite.TabIndex = 2;
            this.lQuantite.Text = "Quantite :";
            // 
            // tbMois
            // 
            this.tbMois.Location = new System.Drawing.Point(58, 82);
            this.tbMois.Name = "tbMois";
            this.tbMois.Size = new System.Drawing.Size(100, 20);
            this.tbMois.TabIndex = 3;
            // 
            // tbQuantite
            // 
            this.tbQuantite.Location = new System.Drawing.Point(70, 106);
            this.tbQuantite.Name = "tbQuantite";
            this.tbQuantite.Size = new System.Drawing.Size(100, 20);
            this.tbQuantite.TabIndex = 4;
            // 
            // fModifFF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbQuantite);
            this.Controls.Add(this.tbMois);
            this.Controls.Add(this.lQuantite);
            this.Controls.Add(this.lMois);
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
        private System.Windows.Forms.Label lMois;
        private System.Windows.Forms.Label lQuantite;
        private System.Windows.Forms.TextBox tbMois;
        private System.Windows.Forms.TextBox tbQuantite;
    }
}
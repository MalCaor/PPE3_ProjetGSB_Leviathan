namespace PPE3_Leviathan
{
    partial class fAjoutLigneFF
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbQuant = new System.Windows.Forms.TextBox();
            this.cbFF = new System.Windows.Forms.ComboBox();
            this.tbMois = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bsFF = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsFF)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quantite :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "FraisForfait :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mois :";
            // 
            // tbQuant
            // 
            this.tbQuant.Location = new System.Drawing.Point(430, 98);
            this.tbQuant.Name = "tbQuant";
            this.tbQuant.Size = new System.Drawing.Size(100, 20);
            this.tbQuant.TabIndex = 10;
            // 
            // cbFF
            // 
            this.cbFF.FormattingEnabled = true;
            this.cbFF.Location = new System.Drawing.Point(244, 98);
            this.cbFF.Name = "cbFF";
            this.cbFF.Size = new System.Drawing.Size(121, 21);
            this.cbFF.TabIndex = 9;
            // 
            // tbMois
            // 
            this.tbMois.Location = new System.Drawing.Point(68, 98);
            this.tbMois.Name = "tbMois";
            this.tbMois.Size = new System.Drawing.Size(100, 20);
            this.tbMois.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ajout Ligne Frais Forfait";
            // 
            // fAjoutLigneFF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbQuant);
            this.Controls.Add(this.cbFF);
            this.Controls.Add(this.tbMois);
            this.Controls.Add(this.label1);
            this.Name = "fAjoutLigneFF";
            this.Text = "fAjoutLigneFF";
            ((System.ComponentModel.ISupportInitialize)(this.bsFF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbQuant;
        private System.Windows.Forms.ComboBox cbFF;
        private System.Windows.Forms.TextBox tbMois;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsFF;
    }
}
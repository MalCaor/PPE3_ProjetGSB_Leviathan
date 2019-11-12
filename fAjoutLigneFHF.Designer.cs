namespace PPE3_Leviathan
{
    partial class fAjoutLigneFHF
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
            this.tbMois = new System.Windows.Forms.TextBox();
            this.cbFF = new System.Windows.Forms.ComboBox();
            this.tbQuant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bsFF = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsFF)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajout Ligne Frais Forfait";
            // 
            // tbMois
            // 
            this.tbMois.Location = new System.Drawing.Point(69, 102);
            this.tbMois.Name = "tbMois";
            this.tbMois.Size = new System.Drawing.Size(100, 20);
            this.tbMois.TabIndex = 1;
            // 
            // cbFF
            // 
            this.cbFF.FormattingEnabled = true;
            this.cbFF.Location = new System.Drawing.Point(245, 102);
            this.cbFF.Name = "cbFF";
            this.cbFF.Size = new System.Drawing.Size(121, 21);
            this.cbFF.TabIndex = 2;
            // 
            // tbQuant
            // 
            this.tbQuant.Location = new System.Drawing.Point(431, 102);
            this.tbQuant.Name = "tbQuant";
            this.tbQuant.Size = new System.Drawing.Size(100, 20);
            this.tbQuant.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mois :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "FraisForfait :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantite :";
            // 
            // fAjoutLigneFHF
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
            this.Name = "fAjoutLigneFHF";
            this.Text = "fAjoutLigneFHF";
            ((System.ComponentModel.ISupportInitialize)(this.bsFF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMois;
        private System.Windows.Forms.ComboBox cbFF;
        private System.Windows.Forms.TextBox tbQuant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bsFF;
    }
}
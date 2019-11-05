namespace PPE3_Leviathan
{
    partial class FrmModifRapport
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
            this.btnMedecin = new System.Windows.Forms.RadioButton();
            this.btnRemplacent = new System.Windows.Forms.RadioButton();
            this.cboMedecin = new System.Windows.Forms.ComboBox();
            this.txtRemplacent = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblModification = new System.Windows.Forms.Label();
            this.lblBilan = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtModification = new System.Windows.Forms.TextBox();
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMedecin
            // 
            this.btnMedecin.AutoSize = true;
            this.btnMedecin.Location = new System.Drawing.Point(35, 25);
            this.btnMedecin.Name = "btnMedecin";
            this.btnMedecin.Size = new System.Drawing.Size(82, 17);
            this.btnMedecin.TabIndex = 0;
            this.btnMedecin.TabStop = true;
            this.btnMedecin.Text = "BtnMedecin";
            this.btnMedecin.UseVisualStyleBackColor = true;
            // 
            // btnRemplacent
            // 
            this.btnRemplacent.AutoSize = true;
            this.btnRemplacent.Location = new System.Drawing.Point(35, 60);
            this.btnRemplacent.Name = "btnRemplacent";
            this.btnRemplacent.Size = new System.Drawing.Size(98, 17);
            this.btnRemplacent.TabIndex = 1;
            this.btnRemplacent.TabStop = true;
            this.btnRemplacent.Text = "BtnRemplacent";
            this.btnRemplacent.UseVisualStyleBackColor = true;
            // 
            // cboMedecin
            // 
            this.cboMedecin.FormattingEnabled = true;
            this.cboMedecin.Location = new System.Drawing.Point(160, 24);
            this.cboMedecin.Name = "cboMedecin";
            this.cboMedecin.Size = new System.Drawing.Size(121, 21);
            this.cboMedecin.TabIndex = 2;
            // 
            // txtRemplacent
            // 
            this.txtRemplacent.Location = new System.Drawing.Point(160, 59);
            this.txtRemplacent.Name = "txtRemplacent";
            this.txtRemplacent.Size = new System.Drawing.Size(121, 20);
            this.txtRemplacent.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(35, 95);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date :";
            // 
            // lblModification
            // 
            this.lblModification.AutoSize = true;
            this.lblModification.Location = new System.Drawing.Point(35, 130);
            this.lblModification.Name = "lblModification";
            this.lblModification.Size = new System.Drawing.Size(70, 13);
            this.lblModification.TabIndex = 5;
            this.lblModification.Text = "Modification :";
            // 
            // lblBilan
            // 
            this.lblBilan.AutoSize = true;
            this.lblBilan.Location = new System.Drawing.Point(35, 165);
            this.lblBilan.Name = "lblBilan";
            this.lblBilan.Size = new System.Drawing.Size(36, 13);
            this.lblBilan.TabIndex = 6;
            this.lblBilan.Text = "Bilan :";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(160, 92);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(121, 20);
            this.txtDate.TabIndex = 7;
            // 
            // txtModification
            // 
            this.txtModification.Location = new System.Drawing.Point(160, 127);
            this.txtModification.Name = "txtModification";
            this.txtModification.Size = new System.Drawing.Size(121, 20);
            this.txtModification.TabIndex = 8;
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(75, 162);
            this.txtBilan.Multiline = true;
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(206, 69);
            this.txtBilan.TabIndex = 9;
            // 
            // FrmModifRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.txtModification);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblBilan);
            this.Controls.Add(this.lblModification);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtRemplacent);
            this.Controls.Add(this.cboMedecin);
            this.Controls.Add(this.btnRemplacent);
            this.Controls.Add(this.btnMedecin);
            this.Name = "FrmModifRapport";
            this.Text = "FrmModifRapport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btnMedecin;
        private System.Windows.Forms.RadioButton btnRemplacent;
        private System.Windows.Forms.ComboBox cboMedecin;
        private System.Windows.Forms.TextBox txtRemplacent;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblModification;
        private System.Windows.Forms.Label lblBilan;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtModification;
        private System.Windows.Forms.TextBox txtBilan;
    }
}
namespace PPE3_Leviathan
{
    partial class fAjoutFicheFrais
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
            this.ltitre = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.calandar = new System.Windows.Forms.MonthCalendar();
            this.btOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltitre
            // 
            this.ltitre.AutoSize = true;
            this.ltitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltitre.Location = new System.Drawing.Point(13, 13);
            this.ltitre.Name = "ltitre";
            this.ltitre.Size = new System.Drawing.Size(174, 25);
            this.ltitre.TabIndex = 1;
            this.ltitre.Text = "Ajout Fiche Frais";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(18, 90);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(36, 13);
            this.lDate.TabIndex = 2;
            this.lDate.Text = "Date :";
            // 
            // calandar
            // 
            this.calandar.Location = new System.Drawing.Point(21, 107);
            this.calandar.MaxSelectionCount = 1;
            this.calandar.Name = "calandar";
            this.calandar.TabIndex = 3;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(427, 154);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(109, 40);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.BtOK_Click);
            // 
            // fAjoutFicheFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.calandar);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.ltitre);
            this.Name = "fAjoutFicheFrais";
            this.Text = "fAjoutFraisForfait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ltitre;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.MonthCalendar calandar;
        private System.Windows.Forms.Button btOK;
    }
}
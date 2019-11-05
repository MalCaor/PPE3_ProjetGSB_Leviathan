namespace PPE3_Leviathan
{
    partial class testCo
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
            this.dgvV = new System.Windows.Forms.DataGridView();
            this.bsV = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvV
            // 
            this.dgvV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvV.Location = new System.Drawing.Point(12, 12);
            this.dgvV.Name = "dgvV";
            this.dgvV.Size = new System.Drawing.Size(395, 217);
            this.dgvV.TabIndex = 0;
            this.dgvV.SelectionChanged += new System.EventHandler(this.DgvV_SelectionChanged);
            // 
            // testCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 241);
            this.Controls.Add(this.dgvV);
            this.Name = "testCo";
            this.Text = "testCo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvV;
        private System.Windows.Forms.BindingSource bsV;
    }
}
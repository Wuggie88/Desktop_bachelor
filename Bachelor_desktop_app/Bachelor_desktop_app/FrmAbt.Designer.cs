namespace Bachelor_desktop_app
{
    partial class FrmAbt
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
            this.abtLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // abtLbl
            // 
            this.abtLbl.AutoSize = true;
            this.abtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abtLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.abtLbl.Location = new System.Drawing.Point(265, 189);
            this.abtLbl.Name = "abtLbl";
            this.abtLbl.Size = new System.Drawing.Size(68, 25);
            this.abtLbl.TabIndex = 0;
            this.abtLbl.Text = "About";
            // 
            // FrmAbt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(977, 590);
            this.Controls.Add(this.abtLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAbt";
            this.Text = "FrmAbt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label abtLbl;
    }
}
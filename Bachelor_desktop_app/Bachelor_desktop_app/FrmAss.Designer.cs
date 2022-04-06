namespace Bachelor_desktop_app
{
    partial class FrmAss
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
            this.AssLbl = new System.Windows.Forms.Label();
            this.MatBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AssLbl
            // 
            this.AssLbl.AutoSize = true;
            this.AssLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.AssLbl.Location = new System.Drawing.Point(604, 9);
            this.AssLbl.Name = "AssLbl";
            this.AssLbl.Size = new System.Drawing.Size(106, 29);
            this.AssLbl.TabIndex = 0;
            this.AssLbl.Text = "Opgaver";
            // 
            // MatBtn
            // 
            this.MatBtn.Location = new System.Drawing.Point(330, 238);
            this.MatBtn.Name = "MatBtn";
            this.MatBtn.Size = new System.Drawing.Size(86, 23);
            this.MatBtn.TabIndex = 1;
            this.MatBtn.Text = "Matematik";
            this.MatBtn.UseVisualStyleBackColor = true;
            this.MatBtn.Click += new System.EventHandler(this.MatBtn_Click);
            // 
            // FrmAss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1303, 726);
            this.Controls.Add(this.MatBtn);
            this.Controls.Add(this.AssLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAss";
            this.Text = "AssForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AssLbl;
        private System.Windows.Forms.Button MatBtn;
    }
}
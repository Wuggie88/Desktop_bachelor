namespace Bachelor_desktop_app
{
    partial class FrmDash
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
            this.DashLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DashLbl
            // 
            this.DashLbl.AutoSize = true;
            this.DashLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.DashLbl.Location = new System.Drawing.Point(13, 9);
            this.DashLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DashLbl.Name = "DashLbl";
            this.DashLbl.Size = new System.Drawing.Size(155, 31);
            this.DashLbl.TabIndex = 0;
            this.DashLbl.Text = "Dashboard!";
            // 
            // FrmDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1303, 726);
            this.Controls.Add(this.DashLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDash";
            this.Text = "FrmDash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DashLbl;
    }
}
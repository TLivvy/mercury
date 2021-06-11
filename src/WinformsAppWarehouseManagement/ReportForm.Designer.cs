
namespace WinFormsAppWarehouseManagement
{
    partial class ReportForm
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
            this.Report = new System.Windows.Forms.Label();
            this.BackToMainR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Report
            // 
            this.Report.AutoSize = true;
            this.Report.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Report.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Report.Location = new System.Drawing.Point(325, 65);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(142, 54);
            this.Report.TabIndex = 0;
            this.Report.Text = "Report";
            // 
            // BackToMainR
            // 
            this.BackToMainR.Location = new System.Drawing.Point(266, 383);
            this.BackToMainR.Name = "BackToMainR";
            this.BackToMainR.Size = new System.Drawing.Size(328, 61);
            this.BackToMainR.TabIndex = 1;
            this.BackToMainR.Text = "Back To Main";
            this.BackToMainR.UseVisualStyleBackColor = true;
            this.BackToMainR.Click += new System.EventHandler(this.BackToMainR_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.BackToMainR);
            this.Controls.Add(this.Report);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Report;
        private System.Windows.Forms.Button BackToMainR;
    }
}
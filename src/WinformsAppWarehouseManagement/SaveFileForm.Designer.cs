
namespace WinFormsAppWarehouseManagement
{
    partial class SaveFileForm
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
            this.BackToMainSF = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackToMainSF
            // 
            this.BackToMainSF.Location = new System.Drawing.Point(267, 358);
            this.BackToMainSF.Name = "BackToMainSF";
            this.BackToMainSF.Size = new System.Drawing.Size(297, 65);
            this.BackToMainSF.TabIndex = 0;
            this.BackToMainSF.Text = "Back To Main";
            this.BackToMainSF.UseVisualStyleBackColor = true;
            this.BackToMainSF.Click += new System.EventHandler(this.BackToMainSF_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.AutoSize = true;
            this.SaveFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveFile.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SaveFile.Location = new System.Drawing.Point(313, 63);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(176, 54);
            this.SaveFile.TabIndex = 1;
            this.SaveFile.Text = "Save File";
            // 
            // SaveFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 512);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.BackToMainSF);
            this.Name = "SaveFileForm";
            this.Text = "SaveFileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToMainSF;
        private System.Windows.Forms.Label SaveFile;
    }
}
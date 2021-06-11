
namespace WinFormsAppWarehouseManagement
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileEntyBt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainTitle = new System.Windows.Forms.Label();
            this.ShipReceiveBt = new System.Windows.Forms.Button();
            this.ReportBt = new System.Windows.Forms.Button();
            this.SaveFileBt = new System.Windows.Forms.Button();
            this.HelpBt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileEntyBt
            // 
            this.FileEntyBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FileEntyBt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FileEntyBt.Location = new System.Drawing.Point(44, 63);
            this.FileEntyBt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.FileEntyBt.Name = "FileEntyBt";
            this.FileEntyBt.Size = new System.Drawing.Size(443, 29);
            this.FileEntyBt.TabIndex = 6;
            this.FileEntyBt.Text = "Inventory";
            this.FileEntyBt.UseVisualStyleBackColor = false;
            this.FileEntyBt.Click += new System.EventHandler(this.FileEntyBt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.MainTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 40);
            this.panel1.TabIndex = 7;
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainTitle.ForeColor = System.Drawing.Color.White;
            this.MainTitle.Location = new System.Drawing.Point(135, 8);
            this.MainTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(250, 21);
            this.MainTitle.TabIndex = 0;
            this.MainTitle.Text = "Warehouse Management Software";
            // 
            // ShipReceiveBt
            // 
            this.ShipReceiveBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ShipReceiveBt.Location = new System.Drawing.Point(44, 102);
            this.ShipReceiveBt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ShipReceiveBt.Name = "ShipReceiveBt";
            this.ShipReceiveBt.Size = new System.Drawing.Size(443, 29);
            this.ShipReceiveBt.TabIndex = 8;
            this.ShipReceiveBt.Text = "Work Order/Purchase Order";
            this.ShipReceiveBt.UseVisualStyleBackColor = false;
            this.ShipReceiveBt.Click += new System.EventHandler(this.ShipReceiveBt_Click);
            // 
            // ReportBt
            // 
            this.ReportBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ReportBt.Location = new System.Drawing.Point(44, 142);
            this.ReportBt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ReportBt.Name = "ReportBt";
            this.ReportBt.Size = new System.Drawing.Size(443, 29);
            this.ReportBt.TabIndex = 9;
            this.ReportBt.Text = "Report(WIP)";
            this.ReportBt.UseVisualStyleBackColor = false;
            this.ReportBt.Click += new System.EventHandler(this.ReportBt_Click);
            // 
            // SaveFileBt
            // 
            this.SaveFileBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SaveFileBt.Location = new System.Drawing.Point(45, 179);
            this.SaveFileBt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.SaveFileBt.Name = "SaveFileBt";
            this.SaveFileBt.Size = new System.Drawing.Size(443, 29);
            this.SaveFileBt.TabIndex = 10;
            this.SaveFileBt.Text = "Export(WIP)";
            this.SaveFileBt.UseVisualStyleBackColor = false;
            this.SaveFileBt.Click += new System.EventHandler(this.SaveFileBt_Click);
            // 
            // HelpBt
            // 
            this.HelpBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.HelpBt.Location = new System.Drawing.Point(44, 220);
            this.HelpBt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.HelpBt.Name = "HelpBt";
            this.HelpBt.Size = new System.Drawing.Size(443, 29);
            this.HelpBt.TabIndex = 11;
            this.HelpBt.Text = "Help : How to use this software";
            this.HelpBt.UseVisualStyleBackColor = false;
            this.HelpBt.Click += new System.EventHandler(this.HelpBt_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(546, 276);
            this.Controls.Add(this.HelpBt);
            this.Controls.Add(this.SaveFileBt);
            this.Controls.Add(this.ReportBt);
            this.Controls.Add(this.ShipReceiveBt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FileEntyBt);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button FileEntyBt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.Button ShipReceiveBt;
        private System.Windows.Forms.Button ReportBt;
        private System.Windows.Forms.Button SaveFileBt;
        private System.Windows.Forms.Button HelpBt;
    }
}


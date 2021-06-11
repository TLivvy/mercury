
namespace WinFormsAppWarehouseManagement.FileEntryContents
{
    partial class FileInformationForm
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
            this.addPanel = new System.Windows.Forms.Panel();
            this.AddContentsText = new System.Windows.Forms.Label();
            this.addContentsPanel = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addPanel.SuspendLayout();
            this.addContentsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPanel
            // 
            this.addPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addPanel.Controls.Add(this.AddContentsText);
            this.addPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPanel.Location = new System.Drawing.Point(0, 0);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(986, 117);
            this.addPanel.TabIndex = 0;
            // 
            // AddContentsText
            // 
            this.AddContentsText.AutoSize = true;
            this.AddContentsText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddContentsText.ForeColor = System.Drawing.Color.Black;
            this.AddContentsText.Location = new System.Drawing.Point(322, 37);
            this.AddContentsText.Name = "AddContentsText";
            this.AddContentsText.Size = new System.Drawing.Size(268, 54);
            this.AddContentsText.TabIndex = 0;
            this.AddContentsText.Text = "Add Contents";
            this.AddContentsText.Click += new System.EventHandler(this.AddContentsText_Click);
            // 
            // addContentsPanel
            // 
            this.addContentsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addContentsPanel.BackColor = System.Drawing.Color.White;
            this.addContentsPanel.Controls.Add(this.btSave);
            this.addContentsPanel.Controls.Add(this.quantityTextBox);
            this.addContentsPanel.Controls.Add(this.label4);
            this.addContentsPanel.Controls.Add(this.locationTextBox);
            this.addContentsPanel.Controls.Add(this.label3);
            this.addContentsPanel.Controls.Add(this.itemNameTextBox);
            this.addContentsPanel.Controls.Add(this.label2);
            this.addContentsPanel.Controls.Add(this.idTextBox);
            this.addContentsPanel.Controls.Add(this.label1);
            this.addContentsPanel.Location = new System.Drawing.Point(48, 152);
            this.addContentsPanel.Name = "addContentsPanel";
            this.addContentsPanel.Size = new System.Drawing.Size(878, 750);
            this.addContentsPanel.TabIndex = 1;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btSave.Location = new System.Drawing.Point(313, 636);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(229, 53);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(80, 374);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(706, 47);
            this.quantityTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 41);
            this.label4.TabIndex = 6;
            this.label4.Text = "Location";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(80, 521);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(706, 47);
            this.locationTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(80, 231);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(706, 47);
            this.itemNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(80, 105);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(706, 47);
            this.idTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // FileInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 931);
            this.Controls.Add(this.addContentsPanel);
            this.Controls.Add(this.addPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FileInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Contents";
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.addContentsPanel.ResumeLayout(false);
            this.addContentsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Label AddContentsText;
        private System.Windows.Forms.Panel addContentsPanel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label1;
    }
}
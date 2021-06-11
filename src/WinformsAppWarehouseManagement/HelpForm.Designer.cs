
using System.Windows.Forms;

namespace WinFormsAppWarehouseManagement
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.BackToMainH = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BackToMainH
            // 
            this.BackToMainH.Location = new System.Drawing.Point(188, 273);
            this.BackToMainH.Margin = new System.Windows.Forms.Padding(1);
            this.BackToMainH.Name = "BackToMainH";
            this.BackToMainH.Size = new System.Drawing.Size(147, 29);
            this.BackToMainH.TabIndex = 0;
            this.BackToMainH.Text = "Back To Main";
            this.BackToMainH.UseVisualStyleBackColor = true;
            this.BackToMainH.Click += new System.EventHandler(this.BackToMainH_Click);
            // 
            // Help
            // 
            this.Help.AutoSize = true;
            this.Help.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Help.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Help.Location = new System.Drawing.Point(63, 31);
            this.Help.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(287, 28);
            this.Help.TabIndex = 1;
            this.Help.Text = "Help menu to use the different function :";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(10, 116);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(901, 126);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Text = "For function :" +
                             "\n " +
                             " 1. **File entry**: with a file containing relevant information (items , reference, quantity, locations...) you will be able to create a database with the current inventory in your warehouse. " +
                             "\n " +
                             " 2. **Shipping / receiving command**: to enter any new entry or shipping in the warehouse. " +
                             "\n" +
                             " 3. **Report**: to create custom report for specific item(s) and/or for a specific time period " +
                             "\n" +
                             "4. **Save file** : this command will update a file on the  current warehouse storage inventory";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 443);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BackToMainH);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToMainH;
        private System.Windows.Forms.Label Help;
        private System.Windows.Forms.TextBox textBox1;
    }
}
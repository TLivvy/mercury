
namespace WinFormsAppWarehouseManagement
{
    partial class ShippingReceivingForm
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
            this.ShippingReceiving = new System.Windows.Forms.Label();
            this.BackToMain = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.createP = new System.Windows.Forms.Button();
            this.viewP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.viewAllP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.createW = new System.Windows.Forms.Button();
            this.viewW = new System.Windows.Forms.Button();
            this.viewAllW = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShippingReceiving
            // 
            this.ShippingReceiving.AutoSize = true;
            this.ShippingReceiving.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ShippingReceiving.Location = new System.Drawing.Point(132, 20);
            this.ShippingReceiving.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ShippingReceiving.Name = "ShippingReceiving";
            this.ShippingReceiving.Size = new System.Drawing.Size(176, 15);
            this.ShippingReceiving.TabIndex = 0;
            this.ShippingReceiving.Text = "Shipping / Receiving Command";
            // 
            // BackToMain
            // 
            this.BackToMain.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackToMain.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BackToMain.Location = new System.Drawing.Point(179, 283);
            this.BackToMain.Margin = new System.Windows.Forms.Padding(1);
            this.BackToMain.Name = "BackToMain";
            this.BackToMain.Size = new System.Drawing.Size(75, 24);
            this.BackToMain.TabIndex = 1;
            this.BackToMain.Text = "Back To Main";
            this.BackToMain.UseVisualStyleBackColor = true;
            this.BackToMain.Click += new System.EventHandler(this.BackToMain_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "PO Number";
            this.textBox1.Size = new System.Drawing.Size(133, 23);
            this.textBox1.TabIndex = 2;
            // 
            // createP
            // 
            this.createP.Location = new System.Drawing.Point(132, 92);
            this.createP.Name = "createP";
            this.createP.Size = new System.Drawing.Size(75, 23);
            this.createP.TabIndex = 3;
            this.createP.Text = "Create PO";
            this.createP.UseVisualStyleBackColor = true;
            this.createP.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewP
            // 
            this.viewP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewP.Location = new System.Drawing.Point(233, 92);
            this.viewP.Name = "viewP";
            this.viewP.Size = new System.Drawing.Size(75, 23);
            this.viewP.TabIndex = 5;
            this.viewP.Text = "View PO";
            this.viewP.UseVisualStyleBackColor = true;
            this.viewP.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Purchace Order Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // viewAllP
            // 
            this.viewAllP.Location = new System.Drawing.Point(179, 121);
            this.viewAllP.Name = "viewAllP";
            this.viewAllP.Size = new System.Drawing.Size(75, 23);
            this.viewAllP.TabIndex = 7;
            this.viewAllP.Text = "View All";
            this.viewAllP.UseVisualStyleBackColor = true;
            this.viewAllP.Click += new System.EventHandler(this.viewAllP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Work Order Number:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "WO Number";
            this.textBox2.Size = new System.Drawing.Size(133, 23);
            this.textBox2.TabIndex = 9;
            // 
            // createW
            // 
            this.createW.Location = new System.Drawing.Point(132, 206);
            this.createW.Name = "createW";
            this.createW.Size = new System.Drawing.Size(75, 23);
            this.createW.TabIndex = 10;
            this.createW.Text = "Create WO";
            this.createW.UseVisualStyleBackColor = true;
            this.createW.Click += new System.EventHandler(this.createW_Click);
            // 
            // viewW
            // 
            this.viewW.Location = new System.Drawing.Point(233, 206);
            this.viewW.Name = "viewW";
            this.viewW.Size = new System.Drawing.Size(75, 23);
            this.viewW.TabIndex = 11;
            this.viewW.Text = "View WO";
            this.viewW.UseVisualStyleBackColor = true;
            this.viewW.Click += new System.EventHandler(this.viewW_Click);
            // 
            // viewAllW
            // 
            this.viewAllW.Location = new System.Drawing.Point(179, 235);
            this.viewAllW.Name = "viewAllW";
            this.viewAllW.Size = new System.Drawing.Size(75, 23);
            this.viewAllW.TabIndex = 12;
            this.viewAllW.Text = "View All";
            this.viewAllW.UseVisualStyleBackColor = true;
            this.viewAllW.Click += new System.EventHandler(this.viewAllW_Click);
            // 
            // ShippingReceivingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 317);
            this.Controls.Add(this.viewAllW);
            this.Controls.Add(this.viewW);
            this.Controls.Add(this.createW);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewAllP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewP);
            this.Controls.Add(this.createP);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BackToMain);
            this.Controls.Add(this.ShippingReceiving);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ShippingReceivingForm";
            this.Text = "ShippingReceivingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShippingReceiving;
        private System.Windows.Forms.Button BackToMain;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button createP;
        private System.Windows.Forms.Button viewP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewAllP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button createW;
        private System.Windows.Forms.Button viewW;
        private System.Windows.Forms.Button viewAllW;
    }
}
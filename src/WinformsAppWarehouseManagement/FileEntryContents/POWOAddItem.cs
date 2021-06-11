using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppWarehouseManagement.FileEntryContents
{
    public partial class POWOAddItem : Form
    {
        string poNum;
        string desc;
        int num;
        bool isPo;
        public POWOAddItem(string poNum, string desc, int num, bool isPo)
        {
            this.poNum = poNum;
            this.desc = desc;
            this.num = num;
            this.isPo = isPo;
            InitializeComponent();
        }
        //not needed but breaks program if removed
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //not needed but breaks program if removed
        private void label3_Click(object sender, EventArgs e)
        {

        }
        //not needed but breaks program if removed
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        // handles continue button, checks for empty textbox, adds to database opens new window
        private void button1_Click(object sender, EventArgs e)
        {
            if (isPo)
            {
                if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals(""))
                {
                    MessageBox.Show("Please fill in all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DbFileEntry.AddPOItem(poNum, desc, textBox1.Text, textBox2.Text, textBox3.Text, true);
                    this.Hide();
                    PurchaseOrder po = new PurchaseOrder(poNum, 0, desc);
                    po.Show();
                }
            }
            else
            {
                if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals(""))
                {
                    MessageBox.Show("Please fill in all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DbFileEntry.AddPOItem(poNum, desc, textBox1.Text, textBox2.Text, textBox3.Text, false);
                    this.Hide();
                    WorkOrder po = new WorkOrder(poNum, 0, desc);
                    po.Show();
                }
            }
        }
    }
}

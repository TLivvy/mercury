using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppWarehouseManagement
{
    public partial class ShippingReceivingForm : Form
    {
        public ShippingReceivingForm()
        {
            InitializeComponent();
        }
        // handles button to return user to main 
        private void BackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mp = new MainPage();
            mp.ShowDialog();
            this.Close();
        }

        //handles create po button and opens new window passing po number
        private void button1_Click(object sender, EventArgs e)
        {
            FileEntryContents.DbFileEntry db = new FileEntryContents.DbFileEntry();

            if (!textBox1.Text.Equals("")) {
                string poNum = textBox1.Text;
                if (!db.Check(poNum, true)) {
                    this.Hide();
                    CollectDesc cd = new CollectDesc(poNum, 1);
                    cd.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This PO Already Exists","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else {
                MessageBox.Show("Please enter a PO Number", "No PO Number Entered ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            
        }

        //handles view po button, and opens new window to view po
        private void button2_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                string poNum = textBox1.Text;
                FileEntryContents.DbFileEntry entry = new FileEntryContents.DbFileEntry();
                if (entry.Check(poNum, true)) {
                    this.Hide();
                    FileEntryContents.PurchaseOrder purO = new FileEntryContents.PurchaseOrder(poNum, 0, entry.GetDesc(poNum, true));
                    purO.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("PO Does Not Exist", "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a PO Number", "No PO Number Entered ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }
        //not used but breaks program if deleted
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // handles view all button for po, opens window with all pos
        private void viewAllP_Click(object sender, EventArgs e)
        {
            this.Hide();
            FileEntryContents.ViewAllPO purO = new FileEntryContents.ViewAllPO();
            purO.Show();
        }

        // handles create workorder button, checks if one exists and then opens window passing wo number
        private void createW_Click(object sender, EventArgs e)
        {
            FileEntryContents.DbFileEntry db = new FileEntryContents.DbFileEntry();

            if (!textBox2.Text.Equals(""))
            {
                string poNum = textBox2.Text;
                if (!db.Check(poNum, false))
                {
                    this.Hide();
                    CollectDesc cd = new CollectDesc(poNum, 0);
                    cd.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This WO Already Exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a WO Number", "No PO Number Entered ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }
         //handles view workorder button, opens new window showing workorder
        private void viewW_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Equals(""))
            {
                string poNum = textBox2.Text;
                FileEntryContents.DbFileEntry entry = new FileEntryContents.DbFileEntry();
                if (entry.Check(poNum, false))
                {
                    this.Hide();
                    FileEntryContents.WorkOrder purO = new FileEntryContents.WorkOrder(poNum, 0, entry.GetDesc(poNum, false));
                    purO.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("WO Does Not Exist", "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a WO Number", "No PO Number Entered ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }
        // handles view all button  for work orders, opens new window showing all work orders
        private void viewAllW_Click(object sender, EventArgs e)
        {
            this.Hide();
            FileEntryContents.ViewAllWO purO = new FileEntryContents.ViewAllWO();
            purO.Show();
        }
    }
}

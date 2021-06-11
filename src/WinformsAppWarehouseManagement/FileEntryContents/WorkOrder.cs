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
    public partial class WorkOrder : Form
    {
        string poNum;
        string description;
        int create;
        
        /*
         * Constructor
         * #poNum is the WorkOrder number input by user
         * #create is an integer that holds which button was clicked for workorder
         * #description is a description of the work order input by user
         */
        public WorkOrder(string poNum, int create, string description)
        {
            InitializeComponent();
            poNumLab.Text = $"WO# {poNum}";
            descLab.Text = $"{description}";
            this.poNum = poNum;
            this.create = create;
            this.description = description;
            if (create != 1)
            {
                View();
            }
        }
        //View displays WorkOrder table
        private void View()
        {
            DbFileEntry.DisplayPO($"SELECT item_number, item_name, qty from wo where wonum = {poNum}", dataGridView1);
        }

        /*
         * Handles adding to inventory button click in table
         * also handles button click for deleting row in table
         */
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DbFileEntry db = new DbFileEntry();
            if (e.ColumnIndex == 0)
            {
                this.Hide();
                db.AddToInventory(poNum, dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), 0);
                WorkOrder po = new WorkOrder(poNum, 0, description);
                po.Show();
                this.Close();
            }
            if (e.ColumnIndex == 1)
            {
                this.Hide();
                string num = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                DbFileEntry.DeletePOFile(poNum, num, false);
                WorkOrder po = new WorkOrder(poNum, 0, description);
                po.Show();
                this.Close();
            }
        }

        //Handles add item button allowing new item to be added to table in new window
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            POWOAddItem a = new POWOAddItem(poNum, description, 1, false);
            a.Show();
            this.Close();
        }

        //Handles view all WO button, opens new window with all WOs
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FileEntryContents.ViewAllWO purO = new FileEntryContents.ViewAllWO();
            purO.Show();
        }

       // handles back to main button
       // opens window with main page
        private void button2_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Close();
        }

        //
        private void button4_Click(object sender, EventArgs e)
        {
            FileContentsForm fcf = new FileContentsForm();
            fcf.Show();
        }
    }
}

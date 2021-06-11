using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace WinFormsAppWarehouseManagement.FileEntryContents
{
    public partial class FileInformationForm : Form
    {
        private readonly FileContentsForm _parent;

        public string id, item_name, quantity, location;

        public FileInformationForm()
        {
            InitializeComponent();
           
        }
        public FileInformationForm ( FileContentsForm parent )
        {
            InitializeComponent();
            _parent = parent;
        }

        private void AddContentsText_Click(object sender, EventArgs e)
        {

        }


        public void UpdateInfo()
        {
           // AddContentsText.Text = "Update File";
            btSave.Text = "Update";

            idTextBox.Text = id;
            itemNameTextBox.Text = item_name;
            quantityTextBox.Text = quantity;
            locationTextBox.Text = location;

        }
        public void Clear()
        {
            idTextBox.Text = itemNameTextBox.Text = quantityTextBox.Text = locationTextBox.Text = string.Empty;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
           if(idTextBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("Id is Empty");
                return;
            }
            if (itemNameTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Item name is Empty");
                return;
            }
            /*
             if (quantityTextBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("Quantity is Empty");
                return;
            }
            */
            if (locationTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Location is Empty");
                return;
            }
            if(btSave.Text == "Save")
            {
               // int id = int.Parse(idTextBox.Text);
                //int quantity = int.Parse(quantityTextBox.Text);
                FileEntry fileEntry = new FileEntry(idTextBox.Text.Trim(), itemNameTextBox.Text.Trim(), quantityTextBox.Text.Trim(), locationTextBox.Text.Trim());
                FileEntryContents.DbFileEntry.AddFile(fileEntry);
                Clear();
            }
            if(btSave.Text == "Update")
            {
                FileEntry fileEntry = new FileEntry(idTextBox.Text.Trim(), itemNameTextBox.Text.Trim(), quantityTextBox.Text.Trim(), locationTextBox.Text.Trim());
                DbFileEntry.UpdateFile(fileEntry, id);


                btSave.Text = "Save";
                this.Hide();

            }
            _parent.Display();
        }
    }
}

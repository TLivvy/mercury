 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CsvHelper;
using System.IO;
using System.Globalization;

namespace WinFormsAppWarehouseManagement.FileEntryContents
{
    public partial class FileContentsForm : Form
    {
        FileInformationForm form;
        //List<FileEntry> records;
        public FileContentsForm()
        {
            InitializeComponent();
            form = new FileInformationForm(this);
          
        }
        
        public void Display()
        {
            // DbFileEntry.DisplayAndSerach("SECLECT id,item_name,quantity, location From file_information", DataGridView);
            DbFileEntry.DisplayAndSerach("Select id,item_name,quantity, location From file_information", DataGridView);
        }
        private void btNew_Click(object sender, EventArgs e)
        {
            //FileEntryContents.FileInformationForm fIF = new FileEntryContents.FileInformationForm(this);
            //fIF.ShowDialog();
            
            form.Clear();
            form.ShowDialog();
        }

        private void FileContents_Load(object sender, EventArgs e)
        {
            // Display();
        }

        private void FileContents_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbFileEntry.DisplayAndSerach("Select id,item_name,quantity, location From file_information WHERE item_name LIKE '%" +   txtSearch.Text + "%'", DataGridView);
        }

        private void dataGridView(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                form.Clear();
                form.id = DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.item_name = DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.quantity = DataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.location = DataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                /*
                form.id = DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                form.item_name = DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.quantity = DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.location = DataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                */
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if(e.ColumnIndex == 1)
            {
                if(MessageBox.Show("Do you want to delete file?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbFileEntry.DeleteFile(DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        

        public void fromLoad_Click_of_SaveFromFile(String value)
        {
            SaveFromFile sf = new SaveFromFile();
            //string value = sf.passingText;
            //DataGridView.DataSource = DbFileEntry.LoadCSV(value);
          //  DataGridView.DataSource = LoadCSV(value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Close();
        }
        /*
public List<FileEntry> LoadCSV(string csvFile)
{
   List<FileEntry> records;
   var reader = new StreamReader(csvFile);
   var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

   records = csv.GetRecords<FileEntry>().ToList();

   return records;
}
*/
        /*
         public List<FileEntry> LoadCSV(string csvFile)
         {

           string query = from 1 in File.ReadAllLines(csvFile)
                         let data = 1.Split(',')
                         select new FileEntry
                         {
                             id = int.Parse(data[0]),
                             item_name = data[1],
                             quantity = int.Parse(data[2]),
                             location = data[3]


                         };

         return query.ToList();
         }
        */
    }
}

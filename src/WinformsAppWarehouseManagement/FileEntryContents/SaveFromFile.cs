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
   
    public partial class SaveFromFile : Form
    { 
        //for string from textBox1
        public string passingText;
        public SaveFromFile()
        {
            InitializeComponent();
        }

        public void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            textBox1.Text = dlg.FileName;
        }
        
        public void btnLoad_Click(object sender, EventArgs e)
        {
            passingText = textBox1.Text;
            Console.WriteLine(passingText);
            FileContentsForm fc = new FileContentsForm();
            
            fc.fromLoad_Click_of_SaveFromFile(passingText);
            fc.ShowDialog();

        }
        

    }
}

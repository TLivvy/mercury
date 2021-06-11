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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
        private void FileEntyBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            FileEntryForm fef = new FileEntryForm();
            fef.ShowDialog();
        }

        private void ShipReceiveBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShippingReceivingForm srf = new ShippingReceivingForm();
            srf.ShowDialog();
        }

        private void ReportBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportForm rf = new ReportForm();
            rf.ShowDialog();
        }

        private void SaveFileBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            SaveFileForm sf = new SaveFileForm();
            sf.ShowDialog();
        }

        private void HelpBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            HelpForm h = new HelpForm();
            h.ShowDialog();
        }
    }
}

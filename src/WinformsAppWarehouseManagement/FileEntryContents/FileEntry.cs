using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppWarehouseManagement.FileEntryContents
{
    class FileEntry
    {
        private string v1;
        private string v2;
        private string v3;
        private string v4;

        public string id { get; set; }

        public string item_name { get;set; }

        public string quantity { get; set; }

        public string location { get; set; }

        public FileEntry(string id, string item_name, string quantity, string location)
        {
            this.id = id;
            this.item_name = item_name;
            this.quantity = quantity;
            this.location = location;
        }
        /*
        public FileEntry(string v1, string v2, string v3, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }
        */
        
    }
}

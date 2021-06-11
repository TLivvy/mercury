using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppWarehouseManagement.FileEntryContents
{
    class POEntry
    {
        string poNum;
        string description;
        string itemNum;
        string qty;


        public POEntry(string poNum, string description, string itemNum, string qty)
        {
            this.poNum = poNum;
            this.Description = description;
            this.ItemNum = itemNum;
            this.Qty = qty;
        }

        public string PoNum { get => poNum; set => poNum = value; }
        public string Description { get => description; set => description = value; }
        public string ItemNum { get => itemNum; set => itemNum = value; }
        public string Qty { get => qty; set => qty = value; }
    }
}

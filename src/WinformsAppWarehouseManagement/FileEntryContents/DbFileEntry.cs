using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppWarehouseManagement.FileEntryContents
{
    class DbFileEntry
    {
        //Opens a connection to the MySQL Database
        public static MySqlConnection GetConnection()
        {
            string conn = "datasource=127.0.0.1;port=3306;username=root;pwd=Zoomzoom25;database=warehouse";
            //string cs = "Server=localhost;uid=root;pwd=St18an03!;database=WarehouseFile";
            MySqlConnection sqlConn = new MySqlConnection(conn);
            try
            {
                sqlConn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sqlConn;
        }
        public static void DisplayAndSerach(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
        public static void AddFile(FileEntry fileEntry)
        {
            
            string sql = "INSERT INTO file_information VALUES (@id, @item_name,@quantity,@location)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = fileEntry.id;
            cmd.Parameters.Add("@item_name", MySqlDbType.VarChar).Value = fileEntry.item_name;
            cmd.Parameters.Add("@quantity", MySqlDbType.Int64).Value = fileEntry.quantity;
            cmd.Parameters.Add("@location", MySqlDbType.VarChar).Value = fileEntry.location;
            
            try
            {
               
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("File is not inserted! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            
        }
        
        public static void UpdateFile(FileEntry fileEntry, string id)
        {
            string sql = " UPDATE file_information SET id=@id, item_name=@item_name,quantity=@quantity,location=@location WHERE id=@id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = fileEntry.id;
            cmd.Parameters.Add("@item_name", MySqlDbType.VarChar).Value = fileEntry.item_name;
            cmd.Parameters.Add("@quantity", MySqlDbType.Int64).Value = fileEntry.quantity;
            cmd.Parameters.Add("@location", MySqlDbType.VarChar).Value = fileEntry.location;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("File is not updated! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeleteFile(string id)
        {
            string sql = "DELETE FROM file_information Where id = @id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("File is not deleted! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        
       public static int LoadCSV(FileEntry fileEntry, string csvFile)
        {
            try
            {
                string sql = "LOAD DATA LOCAL INFILE '" + csvFile + "'INTO TABLE file_information FIELDS TERMINATED BY ','" +
                    "LINES TERMINATED BY '\n'(@id, @item_name,@quantity,@location) SET id=@id, item_name=@item_name,quantity=@quantity,location=@location ";
                   // +" IGNORE 1 LINES (id, item_name, quantity, location)";

                MySqlConnection con = GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
            
                // int a = MySqlHelper.ExecuteNonQuery(con, sql);

                cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = fileEntry.id;
               cmd.Parameters.Add("@item_name", MySqlDbType.VarChar).Value = fileEntry.item_name;
               cmd.Parameters.Add("@quantity", MySqlDbType.Int64).Value = fileEntry.quantity;
               cmd.Parameters.Add("@location", MySqlDbType.VarChar).Value = fileEntry.location;


                int a = cmd.ExecuteNonQuery();
                return a;

            }
            catch
            {
                return -1;
            }
            
        }
        /// <summary>
        /// Adds item to the purchase order/work order
        /// </summary>
        /// <param name="poNum"></param> Purchase Order/Work Order number
        /// <param name="desc"></param>  description of the PO
        /// <param name="itemNum"></param> Item number
        /// <param name="name"></param> Name of the item
        /// <param name="qty"></param> quantity of item 
        /// <param name="isPo"></param> true if is PO, false if is WO
        public static void AddPOItem(string poNum, string desc, string itemNum, string name, string qty, bool isPo)
        {
            string sql = "";
            if (isPo)
            {
                sql = "INSERT INTO po VALUES (@ponum, @description, @itemnum, @itemname, @quantity)";
            }
            else
            {
                sql = "INSERT INTO wo VALUES (@ponum, @description, @itemnum, @itemname , @quantity)";
            }
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ponum", MySqlDbType.VarChar).Value = poNum;
            cmd.Parameters.Add("@quantity", MySqlDbType.Int64).Value = qty;
            cmd.Parameters.Add("@description", MySqlDbType.VarChar).Value = desc;
            cmd.Parameters.Add("@itemnum", MySqlDbType.VarChar).Value = itemNum;
            cmd.Parameters.Add("@itemname", MySqlDbType.VarChar).Value = name;

            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("File is not inserted! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }
        /// <summary>
        /// Deletes specific entry from WO/PO
        /// </summary>
        /// <param name="po"></param> PO/WO number
        /// <param name="itemNum"></param> Item number
        /// <param name="isPo"></param>  true if is PO, false if is WO
        public static void DeletePOFile(string po, string itemNum, bool isPo)
        {
            string sql = "";
            if (isPo)
            {
                sql = "DELETE FROM po WHERE (PO = @poNum AND item_number = @itemNum)";
            }
            else
            {
                sql = "DELETE FROM wo WHERE (wonum = @poNum AND item_number = @itemNum)";
            }
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@poNum", MySqlDbType.VarChar).Value = po;
            cmd.Parameters.Add("@itemNum", MySqlDbType.Int64).Value = itemNum;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("item was not removed from PO! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        /// <summary>
        /// Deletes the entire WO/PO
        /// </summary>
        /// <param name="po"></param> wo/po number
        /// <param name="isPo"></param>  true if is PO, false if is WO
        public static void DeletePO(string po, bool isPo)
        {
            string sql = "";
            if (isPo)
            {
                sql = "DELETE FROM po WHERE PO = @poNum";
            }
            else
            {
                sql = "DELETE FROM wo WHERE wonum = @poNum";
            }
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@poNum", MySqlDbType.VarChar).Value = po;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("PO Removed Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("PO was not removed! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        /// <summary>
        /// Checks to see if WO/PO already exists
        /// </summary>
        /// <param name="po"></param>   po/wo number
        /// <param name="isPo"></param>  true if is PO, false if is WO
        /// <returns></returns>
        public bool Check(string po, bool isPo)
        {
            string sql = "";
            if (isPo)
            {
                sql = "Select PO from po where PO = @ponum";
            }
            else
            {
                sql = "Select wonum from wo where wonum = @ponum";
            }
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("@poNum", MySqlDbType.VarChar).Value = po;
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            con.Close();
            return (tbl.Rows.Count>0);
        }

        /// <summary>
        /// Shows all POs in a table
        /// </summary>
        /// <param name="query"></param> the query to be used in the database
        /// <param name="dgv"></param> 
        public static void DisplayPO(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }

        /// <summary>
        /// Adds the item to main inventory and removes it from the po/wo
        /// </summary>
        /// <param name="po"></param> wo/po number
        /// <param name="itemNum"></param> item number
        /// <param name="name"></param> item name
        /// <param name="isPo"></param>  1 if is PO else is WO
        public void AddToInventory(string po, string itemNum, string name, int isPo)
        {
            string sql = "";
            if(isPo == 1) {
                sql = "SELECT * FROM po WHERE PO = @poNum and item_number = @itemNum";
            }
            else
            {
                sql = "SELECT * FROM wo WHERE wonum = @poNum and item_number = @itemNum";
            }
            
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@poNum", MySqlDbType.VarChar).Value = po;
            cmd.Parameters.Add("@itemNum", MySqlDbType.Int64).Value = itemNum;
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            string strQty = tbl.Rows[0][4].ToString();
            int pQty = Convert.ToInt32(strQty);


            sql = "SELECT * FROM file_information WHERE id = @id";
            cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = itemNum;
            adp = new MySqlDataAdapter(cmd);
            tbl = new DataTable();
            adp.Fill(tbl);
            if (tbl.Rows.Count > 0)
            {
                strQty = tbl.Rows[0][2].ToString();
                int qty = 0;
                if (isPo == 1)
                {
                    qty = Convert.ToInt32(strQty) + pQty;
                }
                else
                {
                    qty = Convert.ToInt32(strQty) - pQty;
                    if(qty < 0)
                    {
                        MessageBox.Show($"This Resulted in negative inventory for item#{itemNum}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                sql = " UPDATE file_information SET quantity=@quantity WHERE id=@id";
                cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = itemNum;
                cmd.Parameters.Add("@quantity", MySqlDbType.Int64).Value = qty;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Was not added to inventory! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if(isPo == 0) {
                    pQty = pQty - pQty - pQty;
                }
                sql = "INSERT INTO file_information VALUES (@id, @item_name,@quantity,@location)";
                
                cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = itemNum;
                cmd.Parameters.Add("@item_name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@quantity", MySqlDbType.Int64).Value = pQty;
                cmd.Parameters.Add("@location", MySqlDbType.VarChar).Value ="";

                try
                {

                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("File was not added/removed! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            con.Close();
            if (isPo == 1) {
                DeletePOFile(po, itemNum, true );
            }
            else
            {
                DeletePOFile(po, itemNum, false);
            }


        }

        /// <summary>
        /// Gets the description of a po/wo
        /// </summary>
        /// <param name="poNum"></param> po/wo number
        /// <param name="isPo"></param> true if is PO, false if is WO
        /// <returns> returns the description of the po/wo </returns>
        public string GetDesc(string poNum, bool isPo)
        {
            string sql = "";
            if (isPo)
            {
                sql = "SELECT DISTINCT description FROM po WHERE PO = @poNum";
            }
            else
            {
                sql = "SELECT DISTINCT description FROM wo WHERE wonum = @poNum";  
            }
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@poNum", MySqlDbType.VarChar).Value = poNum;
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            string desc = tbl.Rows[0][0].ToString();
            return desc;
        }

        /// <summary>
        /// Creates a table containing all POs or WOs
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="query"></param> MySQL query to be used on the database
        public static void ViewAllPO(DataGridView dgv, string query)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }


        
    }

}

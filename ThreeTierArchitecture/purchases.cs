using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace ThreeTierArchitecture
{
    class purchases
    {
        OleDbConnection cn = new OleDbConnection(@" Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\user\Desktop\Soso\ThreeTierArchitecture\Store.accdb");
  
        DataTable Dt = new DataTable();
        OleDbCommand cmd;
        


        public void parseDataToDataBase(double quantity, double price, string itemName,string Size)
        {

            double x = quantity + 13;
            cmd = new OleDbCommand("Insert Into items Values('" + Convert.ToInt32(x) + "','" + itemName +"','" + quantity + "','" + Size + "','" + price +"')", cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();




        }
    }
}

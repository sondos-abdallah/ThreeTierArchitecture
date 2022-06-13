using ThreeTierArchitecture.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeTierArchitecture.DAL
{
    public static class PurchaseDAL
    {
        private static OleDbConnection cn = new OleDbConnection(@" Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\user\Desktop\Soso\ThreeTierArchitecture\Store.accdb");
        public static void Add(Purchase purchase)
        {
            string commandText = String.Format("INSERT INTO items(id,name,qty,size,price)" +"values('{0}','{1}','{2}','{3}','{4}')", purchase.Id, purchase.Wear, purchase.Qty, purchase.Size, purchase.Price);
         

            OleDbCommand cmd = new OleDbCommand(commandText, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
           
        }
       
        public static void Delete(Purchase purchase)
        {

            string commandText = String.Format("Delete from items where id = {0}", purchase.Id);
            OleDbCommand cmd = new OleDbCommand(commandText, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }
        public static DataTable GetAll()
        {

            OleDbCommand cmd = new OleDbCommand("Select * from items", cn);
            OleDbDataAdapter Da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            Da.Fill(dt);
            return dt;
        }
    }
}

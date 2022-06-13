using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ThreeTierArchitecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;


            OleDbConnection con = new OleDbConnection(@" Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\user\Desktop\Soso\ThreeTierArchitecture\Store.accdb ");

            DataTable Dt = new DataTable();
            OleDbCommand cmd;
            OleDbDataReader dr;

            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM [user] where [username]='" + userName + "' AND [password]='" + password + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form4 f4 = new Form4();


                f4.Show();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }

            con.Close();
        }
    }
}

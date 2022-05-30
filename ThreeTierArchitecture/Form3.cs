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
    
    public partial class Form3 : Form
    {
        OleDbConnection cn = new OleDbConnection(@" Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\user\Desktop\Soso\ThreeTierArchitecture\Store.accdb");
        OleDbDataAdapter Da;
        DataTable Dt = new DataTable();
        OleDbCommand cmd;
        public Form3()
        {
            InitializeComponent();
            FillDatagridView();
        }
        void FillDatagridView()
        {
            Dt.Clear();
            Da = new OleDbDataAdapter("Select * From items", cn);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;

        }
        private void Add_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox2.Text);
            cmd = new OleDbCommand("Insert Into items Values('" + textBox1.Text + "','" + Convert.ToDouble(textBox2.Text) + "','" + textBox3.Text + "','" + Convert.ToDouble(textBox4.Text) + "','" + x + "')", cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            FillDatagridView();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            MessageBox.Show("Added Successfully ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("Delete From items WHERE name =?", cn);
            cmd.Parameters.Add("Param1", OleDbType.VarChar).Value = textBox1.Text;
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            FillDatagridView();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            MessageBox.Show("Deleted Successfully ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

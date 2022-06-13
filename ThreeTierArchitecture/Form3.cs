using ThreeTierArchitecture.DAL;
using ThreeTierArchitecture.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeTierArchitecture
{
    
    public partial class Form3 : Form
    {
        Purchase purchase = new Purchase();
        public Form3()
        {
            InitializeComponent();
           
        }
        
        private void Add_Click(object sender, EventArgs e)
        {
          
            Purchase purchase = new Purchase();
            purchase.Id = Convert.ToInt32(textBox5.Text);
            purchase.Wear = textBox1.Text;
            purchase.Qty = Convert.ToInt32(textBox2.Text);
            purchase.Size = textBox3.Text;
            purchase.Price = Convert.ToInt32(textBox2.Text);

            PurchaseDAL.Add(purchase);
            RefreshProductGrid1();
            clearform();

            MessageBox.Show("Added Successfully ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void RefreshProductGrid1()
        {
            dataGridView1.DataSource = PurchaseDAL.GetAll();
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
            PurchaseDAL.Delete(purchase);
            RefreshProductGrid1();
            clearform();
           
            MessageBox.Show("Deleted Successfully ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clearform()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = PurchaseDAL.GetAll();
            clearform();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            purchase = new Purchase();

            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];

            purchase.Id = int.Parse(row.Cells[0].Value.ToString());
            purchase.Wear = row.Cells[1].Value.ToString();
            purchase.Qty = int.Parse(row.Cells[2].Value.ToString());
            purchase.Size = row.Cells[3].Value.ToString();
            purchase.Price = double.Parse(row.Cells[4].Value.ToString());

            textBox5.Text = purchase.Id.ToString();
            textBox1.Text = purchase.Wear;
            textBox2.Text = purchase.Qty.ToString();
            textBox3.Text = purchase.Size;
            textBox4.Text = purchase.Price.ToString();
        }
    }
}

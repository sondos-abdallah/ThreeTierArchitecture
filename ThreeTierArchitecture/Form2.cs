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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                purchases tshirt = new purchases();
                tshirt.parseDataToDataBase(Convert.ToDouble(numericUpDown1.Value), Convert.ToDouble(textBox1.Text), "T-shirt", comboBox1.Text);
                MessageBox.Show("Added Successfully ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Choose Qty ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox4.Visible = false;
            pictureBox6.Visible = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox10.Visible = true;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox11.Visible = true;
            pictureBox10.Visible = false;
            pictureBox12.Visible = false;

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox12.Visible = true;
            pictureBox11.Visible = false;
            pictureBox10.Visible = false;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("S");
            comboBox1.Items.Add("M");
            comboBox1.Items.Add("L");
            comboBox1.Items.Add("XL");
            comboBox2.Items.Add("S");
            comboBox2.Items.Add("M");
            comboBox2.Items.Add("L");
            comboBox2.Items.Add("XL");
            comboBox3.Items.Add("S");
            comboBox3.Items.Add("M");
            comboBox3.Items.Add("L");
            comboBox3.Items.Add("XL");
            comboBox4.Items.Add("S");
            comboBox4.Items.Add("M");
            comboBox4.Items.Add("L");
            comboBox4.Items.Add("XL");
            textBox1.Text = "5.00";
            textBox2.Text = "20.00";
            textBox3.Text = "35.00";
            textBox4.Text = "15.00";
            textBox11.Text = "0.0";
            textBox12.Text = "0.0";
            textBox13.Text = "0.0";
            textBox14.Text = "0.0";

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double d;
            d = Convert.ToDouble(numericUpDown1.Value);
            double x;
            x = d * 5.00;
            textBox11.Text = x.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double d;
            d = Convert.ToDouble(numericUpDown3.Value);
            double x;
            x = d * 35.00;
            textBox13.Text = x.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double d;
            d = Convert.ToDouble(numericUpDown2.Value);
            double x;
            x = d * 20.00;
            textBox12.Text = x.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double d;
            d = Convert.ToDouble(numericUpDown4.Value);
            double x;
            x = d * 15.00;
            textBox14.Text = x.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown2.Value > 0)
            {
                
                purchases hoodie = new purchases();
                hoodie.parseDataToDataBase(Convert.ToDouble(numericUpDown2.Value), Convert.ToDouble(textBox2.Text), "Hoodie", comboBox2.Text);
                MessageBox.Show("Added Successfully ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Choose Qty ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (numericUpDown4.Value > 0)
            {

                purchases sweater = new purchases();
                sweater.parseDataToDataBase(Convert.ToDouble(numericUpDown4.Value), Convert.ToDouble(textBox4.Text), "Sweater", comboBox3.Text);
                MessageBox.Show("Added Successfully ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Choose Qty ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (numericUpDown3.Value > 0)
            {

                purchases jacket = new purchases();
                jacket.parseDataToDataBase(Convert.ToDouble(numericUpDown3.Value), Convert.ToDouble(textBox3.Text), "Jacket", comboBox4.Text);
                MessageBox.Show("Added Successfully ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Choose Qty ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Close();
        }
    }
}

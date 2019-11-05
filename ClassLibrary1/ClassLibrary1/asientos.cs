using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class asientos : UserControl
    {
        public asientos()
        {
            InitializeComponent();
        }

       

        private void button5_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "libre")
            {
                button5.BackColor = Color.Lime;
            }
            else
            {
                button5.BackColor = Color.Red;
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "libre")
            {
                button7.BackColor = Color.Lime;
            }
            else
            {
                button7.BackColor = Color.Red;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "libre")
            {
                button3.BackColor = Color.Lime;
            }
            else
            {
                button3.BackColor = Color.Red;
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "libre")
            {
                button6.BackColor = Color.Lime;
            }
            else
            {
                button6.BackColor = Color.Red;
            }
            
            
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "libre")
            {
                button2.BackColor = Color.Lime;
            }
            else
            {
                button2.BackColor = Color.Red;
            }
            
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "libre")
            {
                button4.BackColor = Color.Lime;
            }
            else
            {
                button4.BackColor = Color.Red;
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button1.Text = "Mesa 1";
            button1.BackColor = Color.White;
            button1.Enabled = true;

            button5.Text = "Mesa 5";
            button5.BackColor = Color.White;
            button5.Enabled = true;

            button7.Text = "Mesa 7";
            button7.BackColor = Color.White;
            button7.Enabled = true;

            button3.Text = "Mesa 3";
            button3.BackColor = Color.White;
            button3.Enabled = true;

            button6.Text = "Mesa 6";
            button6.BackColor = Color.White;
            button6.Enabled = true;

            button2.Text = "Mesa 2";
            button2.BackColor = Color.White;
            button2.Enabled = true;

            button9.Text = "Mesa 8";
            button9.BackColor = Color.White;
            button9.Enabled = true;

            button4.Text = "Mesa 4";
            button4.BackColor = Color.White;
            button4.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "libre")
            {
                button9.BackColor = Color.Lime;
            }
            else
            {
                button9.BackColor = Color.Red;
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "libre")
            {
                button1.BackColor = Color.Lime;
            }
            else
            {
                button1.BackColor = Color.Red;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
              label4.Text = textBox1.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            MessageBox.Show("tu reservacion ha sido realizada con exito");
           
             
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
   label5.Text = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
 label6.Text = textBox3.Text;
        }

       

        

       
    }
}

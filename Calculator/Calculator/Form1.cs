using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double oddsDec, oddsUs, pow, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // textBox1.Text = string.Format("{0:0.00}", double.Parse(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

      

      

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked & textBox2.Text != "" )
            {
                oddsDec = Convert.ToDouble(textBox1.Text);
                //oddsUs = Convert.ToDouble(textBox1.Text);
                pow = Convert.ToDouble(textBox2.Text);
                result = (((pow / 100) * oddsDec) - 1) * 100;

                textBox3.Text = result.ToString();
            }else if (radioButton2.Checked & textBox2.Text != "")
            {
                oddsUs = Convert.ToDouble(textBox1.Text);
                pow = Convert.ToDouble(textBox2.Text);
                result = (((pow / 100) * (-100/oddsUs)) - 1) * 100;
            }
            else if(!radioButton1.Checked& !radioButton1.Checked)
            {
                MessageBox.Show("Please choose odds");
            }
            else
            { if (textBox1.Text == "")
                { MessageBox.Show("Please enter odds"); }
            else if(textBox2.Text == "")
                {
                    MessageBox.Show("Please enter Probability of winning");
                }
            }
        }
    }
}

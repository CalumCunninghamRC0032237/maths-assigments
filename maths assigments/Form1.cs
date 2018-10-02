using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maths_assigments
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            int i1 = 3 * 4;
            int i2 = 12 / 4;
            int i3 = 15 / 4;
            int i4 = 15 % 4;
            int i5 = 2 + 3 * 4;
            int i6 = 2 + (2 + 3) * (2 - 4);
            richTextBox1.AppendText(i1 + "\n" + i2 + "\n" + i3 + "\n" + i4 + "\n" + i5 + "\n" + i6 + "\n)");
         
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try

            {
                double d1 = Convert.ToDouble(textBox1.Text);
                double cuberoot = Math.Pow(d1, 1.0 / 3.0);
                label1.Text = cuberoot.ToString();

            }

            catch

            {
                label1.Text = "not a number";
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try

            {
                double d2 = Convert.ToDouble(textBox2.Text);
                double sqaureroot = Math.Pow(d2, 1.0 / 3.0);
                label2.Text = sqaureroot.ToString(); 
                 
            }

            catch

            {
                label2.Text = "not a number";
            }

        }
    }
}

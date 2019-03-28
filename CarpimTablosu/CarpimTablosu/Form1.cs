using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpimTablosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 1; i<=10; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                   if (i == 1)                    
                       listBox1.Items.Add(i + " X " + j + " = " + (i * j));

                   if(i ==2)
                       listBox2.Items.Add(i + " X " + j + " = " + (i * j));

                   if (i == 3)
                       listBox3.Items.Add(i + " X " + j + " = " + (i * j));

                   if (i == 4)
                       listBox4.Items.Add(i + " X " + j + " = " + (i * j));

                   if (i == 5)
                       listBox5.Items.Add(i + " X " + j + " = " + (i * j));

                   if (i == 6)
                       listBox6.Items.Add(i + " X " + j + " = " + (i * j));

                   if (i == 7)
                       listBox7.Items.Add(i + " X " + j + " = " + (i * j));

                   if (i == 8)
                       listBox8.Items.Add(i + " X " + j + " = " + (i * j));

                   if (i == 9)
                       listBox9.Items.Add(i + " X " + j + " = " + (i * j));

                   if (i == 10)
                       listBox10.Items.Add(i + " X " + j + " = " + (i * j));
                }
            }
        }
    }
}

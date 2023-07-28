using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitapsüresi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int word, pages, conclusion;
            word = Convert.ToInt32(textBox1.Text);
            pages = Convert.ToInt32(textBox2.Text);
            conclusion = pages * 175 / word;
            int hours = conclusion / 60;
            int minutes = conclusion % 60;
            label3.Text = "Reading time : " + hours + " Hour " + minutes + " minute";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

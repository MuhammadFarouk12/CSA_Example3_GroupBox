using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSA_Example3_GroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textViewer.Text = textBox1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textViewer.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textViewer.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textViewer.ForeColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textViewer.ForeColor = Color.Yellow;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textViewer.ForeColor = Color.Pink;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textViewer.TextAlign = ContentAlignment.MiddleLeft;
        }
       
        private void button10_Click(object sender, EventArgs e)
        {
            textViewer.TextAlign = ContentAlignment.MiddleRight;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textViewer.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}

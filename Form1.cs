using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        int N1,N2;
        string tot, Help;
        int z;

        private void button1_Click(object sender, EventArgs e)
        {
            text1.Text = text1.Text + button1.Text;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            text1.Text = text1.Text + button10.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            text1.Text = text1.Text + button5.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            text1.Text = text1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            text1.Text = text1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            text1.Text = text1.Text + button4.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            text1.Text = text1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            text1.Text = text1.Text + button7.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            text1.Text = text1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            text1.Text = text1.Text + button9.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Help = "*";
            N1 = int.Parse(text1.Text);

            text1.Clear();
        }

        private void PLUS_Click(object sender, EventArgs e)
        {
            Help = "+";
            N1 = int.Parse(text1.Text);

            text1.Clear();

        }

        private void MINUS_Click(object sender, EventArgs e)
        {
            Help = "-";
            N1 = int.Parse(text1.Text);

            text1.Clear();

        }

        private void DIVI_Click(object sender, EventArgs e)
        {
            Help = "/";
            N1 = int.Parse(text1.Text);

            text1.Clear();

        }

        private void EQUAL_Click(object sender, EventArgs e)
        {
            N2 = int.Parse(text1.Text);
            if (Help == ("+"))
            {
                z = N1 + N2;
            }
            if (Help== ("-"))
            {
                z = N1 - N2;
            }
            if (Help == ("*"))
            {
                z = N1 * N2;
            }
            if (Help == ("/"))
            {
                z = N1 / N2;
            }
            text1.Text = z + "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            text1.Clear();
            z = (0);
            N1 = (0);
            N2 = (0);
        }

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.DeepPink;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

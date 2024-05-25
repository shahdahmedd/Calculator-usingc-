using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task1
{
    public partial class Form1 : Form
    {
        
        char l;
        int Help = 0;

        int Operation;

        int Count = 0;
        int Countb = 0;

        float a;
        float b;
        float c;

        string New;

        string text = "";
        string list1 = "";
        string list2 = "";

        private void button1_Click(object sender, EventArgs e) => text1.Text += "1";

        private void button10_Click(object sender, EventArgs e)
        {
            text1.Text += "0";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            text1.Text += "5";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            text1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            text1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            text1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            text1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            text1.Text += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            text1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            text1.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            text1.Text += "*";
        }

        private void PLUS_Click(object sender, EventArgs e)
        {
            text1.Text += "+";

        }

        private void MINUS_Click(object sender, EventArgs e)
        {
            text1.Text += "-";

        }

        private void DIVI_Click(object sender, EventArgs e)
        {
            text1.Text += "/";

        }

        private void EQUAL_Click(object sender, EventArgs e)
        {
            text1.Text = text1.Text;
            for (int a = 0; a < text1.Text.Length; a++)
            {
                this.l = text1.Text[a];

                if (l == '+' || l == '-' || l == '/' || l == '*')
                {
                    if (Help == 0)
                    {


                        if (l == '+')
                        {
                            New += list1 + "+";

                            list1 = "";

                            Help = 0;
                        }


                        if (l == '-')
                        {
                            New += list1 + "-";

                            list1 = "";

                            Help = 0;
                        }


                        if (l == '*')
                        {
                            Operation = 3;

                            Help = 1;
                        }


                        if (l == '/')
                        {
                            Operation = 4;

                            Help = 1;
                        }


                    }
                    else
                    {
                        this.a = float.Parse(list1);

                        b = float.Parse(list2);

                        if (Operation == 3)
                        {

                            c = this.a * b;

                        }

                        if (Operation == 4)
                        {
                            c = this.a / b;
                        }

                        list1 = c.ToString();

                        list2 = "";

                        if (l == '+')
                        {
                            New += list1 + "+";

                            list1 = "";

                            Help = 0;
                        }
                        if (l == '-')
                        {
                            New += list1 + "-";

                            list1 = "";

                            Help = 0;
                        }
                        if (l == '*')
                        {

                            Operation = 3;


                        }
                        if (l == '/')
                        {

                            Operation = 4;

                        }
                    }
                }
                else
                {
                    if (Help == 0)
                    {
                        list1 += l;
                    }
                    else { list2 += l; }
                }
            }
            text1.Text = New + list1;
            if (list2 == "")
            {
                a = float.Parse(list1);
                New += a;
            }
            else
            {
                a = float.Parse(list1);

                b = float.Parse(list2);

                if (Operation == 3)
                {
                    c = a * b;

                    New += c;
                }
                if (Operation == 4)
                {

                    c = a / b;


                    New += c;
                }
                if (Operation == 1)
                {
                    New += a + "+" + b;
                }
                if (Operation == 2)
                {
                    New += a + "-" + b;
                }
            }

            text1.Text = New;
           list1 = "";
           list2 = "";
            Help = 0;
            for (int a = 0; a < text1.Text.Length + 1; a++)
            {
                if (a < text1.Text.Length)
                {
                    this.l = text1.Text[a];
                }
                else { this.l = '='; }
                if (l == '+' || l == '-' || l == '=')
                {

                    if (Help == 1)
                    {
                        this.a = float.Parse(list1);

                        b = float.Parse(list2);

                        if (Operation == 1)
                        {
                            c = this.a + b;
                        }
                        if (Operation == 2)
                        {
                            if (this.a >= b)
                            {
                                c = this.a - b;
                            }
                            else
                            {
                                c = b - this.a;
                            }
                        }

                        list1 = c.ToString();
                        Help = 0;
                        list2 = "";
                    }
                    if (l == '+')
                    { Operation = 1; }
                    if (l == '-')
                    { Operation = 2; }
                    Help = 1;
                }
                else
                {
                    if (Help == 0)
                    {
                        list1 += l;
                    }
                    else { list2 += l; }
                }
            }

            text1.Text = c.ToString();
            a = 0;
            b = 0;
            c = 0;
            Operation = 0;
            list1 = "";
            list2 = "";
            Help = 0;
            New = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            text1.Text = "0";
            Operation = 0;
            list1 = "";
            list2 = "";
            a = 0;
            b = 0;
            c = 0;
            Help = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            text1.Text += ".";
        }

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.DeepPink;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

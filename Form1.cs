using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clculator_Windows
{
    public partial class Form1 : Form
    {
        decimal k = 0; int i = 0;
        decimal[] a = new decimal[3]; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "2";
                a[i] = 2;
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "2";
                a[i] = a[i] * 10 + 2;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "6";
                a[i] = 6;
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "6";
                a[i] = a[i] * 10 + 6;
            }
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Buton0_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "0")
            {
                this.textBox1.Text = this.textBox1.Text + "0";
                a[i] = a[i] * 10;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "1";
                a[i] = 1;
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "1";
                a[i] = a[i] * 10 + 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "3";
                a[i] = 3;
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "3";
                a[i] = a[i] * 10 + 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "4";
                a[i] = 4;
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "4";
                a[i] = a[i] * 10 + 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "5";
                a[i] = 5;
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "5";
                a[i] = a[i] * 10 + 5;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "7";
                k = a[i];
            }         
            else
            {
                this.textBox1.Text = this.textBox1.Text + "7";
                a[i] = a[i] * 10 + 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "8";
                a[i] = 8;
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "8";
                a[i] = a[i] * 10 + 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "9";
                a[i] = 9;
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "9";
                a[i] = a[i] * 10 + 9;
            }
        }

        private void ButonPlus_Click(object sender, EventArgs e)
        {
            char w;
            if(this.textBox1.Text.Length > 2)
                w = this.textBox1.Text[this.textBox1.Text.Length - 2];
            else 
                w = this.textBox1.Text[this.textBox1.Text.Length - 1];


            if (i == 2)
            {
                for (int j = 0; j <= i; j++)
                    k += a[j];
                this.textBox1.Text = k.ToString() + " + ";
            }
            else if (w != '+' || w != '-' || w != '*' || w != '/' || w != '%' || w != '^' || w != '√') 
            {
                this.textBox1.Text = this.textBox1.Text + " + ";
                i++;
            }
            
        }

        private void ButonMinus_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + " - ";
        }

        private void ButonOri_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + " * ";
        }

        private void ButonSlash_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + " / ";
        }

        private void ButonProcent_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + " % ";
        }

        private void Buton1SupraX_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "0")
                this.textBox1.Text = "1 / " + this.textBox1.Text;
        }

        private void ButonEgal_Click(object sender, EventArgs e)
        {
            for (int j = 0; j <= i; j++)
                k += a[j];
            this.textBox1.Text = k.ToString();
            //MessageBox.Show(k.ToString(), "OWO", MessageBoxButtons.OK);
            i = 0;
        }

        private void ButonC_Click(object sender, EventArgs e)
        {
            k = 0;
            this.textBox1.Text = "0";
        }

        private void ButonDEL_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length < 2)
            {
                this.textBox1.Text = "0";
                k = 0;
            }
            else if (this.textBox1.Text[this.textBox1.Text.Length - 2] != '+' ||
                this.textBox1.Text[this.textBox1.Text.Length - 2] != '-' ||
                this.textBox1.Text[this.textBox1.Text.Length - 2] != '*' ||
                this.textBox1.Text[this.textBox1.Text.Length - 2] != '/' ||
                this.textBox1.Text[this.textBox1.Text.Length - 2] != '%' ||
                this.textBox1.Text[this.textBox1.Text.Length - 2] != '^' ||
                this.textBox1.Text[this.textBox1.Text.Length - 2] != '√'
                ) 
            {
                int w = this.textBox1.Text.Length;
                string owo = "";
                for (int j = 0; j < w - 1; j++)
                    owo += this.textBox1.Text[j];
                this.textBox1.Text = owo;
                k /= 10;
            }
            else
            {
                int w = this.textBox1.Text.Length;
                string owo = "";
                for (int i = 0; i < w - 4; i++)
                    owo += this.textBox1.Text[i];
                this.textBox1.Text = owo;
                k /= 10;
            }
        }

        private void ButonRadical_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "√";

        }

        private void ButonPutere_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "^";
        }
    }
}

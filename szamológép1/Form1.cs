﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szamológép1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = a + b;
            label3.Text = "+";
            label4.Text = "Eredmény= " + c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = a - b;
            label3.Text = "-";
            label4.Text = "Eredmény= " + c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = a * b;
            label3.Text = "*";
            label4.Text = "Eredmény= " + c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = a / b;
            label3.Text = "/";
            label4.Text = "Eredmény= "+c.ToString();
        }
    }
}

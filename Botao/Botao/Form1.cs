﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Botao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = "Carlos";
            int x = 3;
            x = x  * 17;
            double d = Math.PI / 2;
            MessageBox.Show("nome é" + nome + "\nx is " + x + "\nd is " + d); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            if( x == 10)
            {
                MessageBox.Show("X must be 10");
            }
            else
            {
                MessageBox.Show("x isn t 10");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int somaValor = 4;
            string name = "Boboo Jr.";
            if((somaValor == 3) && (name == "Joe"))
            {
                MessageBox.Show("x is 3 and the name is Joe");
            }

            MessageBox.Show("this line runs no matter what");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;

            while (count < 10)
            {
                count += 1;
            }
            for (int i = 0; i < 5; i++)
            {
                count -= 1;
            }

            MessageBox.Show("The answer is " + count);
        }
    }
}
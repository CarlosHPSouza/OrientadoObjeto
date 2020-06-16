using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaLogin
{
    public partial class Form2 : Form
    {
        int tempo = 0;
        int minuto = 0;
        int segundo = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Sistema";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            tempo = Convert.ToInt32(textBox1.Text);
            if(tempo >= 60)
            {
                minuto = tempo / 60;
                segundo = tempo % 60;

            }
            else
            {
                minuto = 0;
                segundo = tempo;
            }
            label3.Text = "0" + minuto + ":" + segundo;
            timer1.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundo--;
            if(minuto > 0)
            {
                if(segundo < 0)
                {
                    segundo = 59;
                    minuto--;
                }
            }
            label3.Text = "0" + minuto + ":" + segundo;
            if( minuto == 0 && segundo == 0)
            {
                timer1.Enabled = false;
                pictureBox1.Visible = true;
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            label4.Text = Convert.ToString(e.KeyValue);
        }
    }
}

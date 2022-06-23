using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0623
{
    public partial class Form1 : Form
    {
        int vx = 10;
        int vy = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left<0)
            {
                vx = vy;
            }
            if(label1.Top<0)
            {
                vy = vx;
            }
            if(label1.Left > 0)
            {
                vx = -vy;
            }
            if(label1.Top>0)
            {
                vy = -vx;
            }

            //Scale--;
            //label2.Text = S"SCORE{Score}";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("小船");
            timer1.Enabled = !timer1.Enabled;
        }
    }
}

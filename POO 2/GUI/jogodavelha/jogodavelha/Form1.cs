using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogodavelha
{
    public partial class Form1 : Form
    {
        int contador;
        public Form1()
        {
            InitializeComponent();
            contador = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(contador % 2 ==0)
            {
                label1.Text = "X";
            }
            else
            {
                label1.Text = "O";
            }
            contador++;
        }


        private void label9_Click(object sender, EventArgs e)
        {

            if (contador % 2 == 0)
            {
                label9.Text = "X";
            }
            else
            {
                label9.Text = "O";
            }
            contador++;
        }

        private void label7_Click(object sender, EventArgs e)
        {

            if (contador % 2 == 0)
            {
                label7.Text = "X";
            }
            else
            {
                label7.Text = "O";
            }

            contador++;
        }

        private void label3_Click(object sender, EventArgs e)
        {

            if (contador % 2 == 0)
            {
                label3.Text = "X";
            }
            else
            {
                label3.Text = "O";
            }
            contador++;
        }

        private void label5_Click(object sender, EventArgs e)
        {

            if (contador % 2 == 0)
            {
                label5.Text = "X";
            }
            else
            {
                label5.Text = "O";
            }
            contador++;
        }

        private void label4_Click(object sender, EventArgs e)
        {

            if (contador % 2 == 0)
            {
                label4.Text = "X";
            }
            else
            {
                label4.Text = "O";
            }
            contador++;
        }

        private void label6_Click(object sender, EventArgs e)
        {

            if (contador % 2 == 0)
            {
                label6.Text = "X";
            }
            else
            {
                label6.Text = "O";
            }
            contador++;
        }

        private void label8_Click(object sender, EventArgs e)
        {

            if (contador % 2 == 0)
            {
                label8.Text = "X";
            }
            else
            {
                label8.Text = "O";
            }
            contador++;
        }

        private void label2_Click(object sender, EventArgs e)
        {

            if (contador % 2 == 0)
            {
                label2.Text = "X";
            }
            else
            {
                label2.Text = "O";
            }
            contador++;
            if(label1.Text == label9.Text && label2.Text == label1.Text)
            {
                label10.Text = "Winner = " + label1.Text;
            }
            if(label1.Text == "O" &&  label9.Text == "O" && label2.Text == "O")
            {
                label10.Text = "Winner = X";
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
            label2.Text = "-";
            label3.Text = "-";
            label4.Text = "-";
            label5.Text = "-";
            label6.Text = "-";
            label7.Text = "-";
            label8.Text = "-";
            label9.Text = "-";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}

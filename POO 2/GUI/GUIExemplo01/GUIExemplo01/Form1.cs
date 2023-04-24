using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIExemplo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonclique_Click(object sender, EventArgs e)
        {
            int contador = 0;//iniciando contador
            contador = int.Parse(lblcliques.Text);//receber o valor de cliques atual
            contador++;//somar mais 1 no valor de cliques atual
            lblcliques.Text = contador.ToString();//retornar esse valor com acrescimo para a variavel que mostra cliques
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int reset = 0;
            lblcliques.Text = reset.ToString();
        }
    }
}

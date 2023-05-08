using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_telefonica
{
    public partial class Form1 : Form
    {
        List<Contatos> contatos = new List<Contatos>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txbnome.Text) || String.IsNullOrWhiteSpace(txbsobrenome.Text) ||
                String.IsNullOrWhiteSpace(txbddd.Text) || String.IsNullOrWhiteSpace(txbnumero.Text))
            {
                MessageBox.Show("Existem Campos a Serem Preenchidos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                contatos.Add(new Contatos(txbnome.Text, txbsobrenome.Text, txbddd.Text, txbnumero.Text));
                
                txbnome.Clear();
                txbsobrenome.Clear();
                txbddd.Clear();
                txbnumero.Clear();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_telefonica
{
    internal class Contatos
    {
        public String nome { get; set; }
        public String sobrenome { get; set; }
        public String ddd { get; set; }
        public String numero { get; set; }

        public Contatos()
        {

        }
        public Contatos(string nome, string sobrenome, string ddd, string numero)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.ddd = ddd;
            this.numero = numero;
        }

    }
}

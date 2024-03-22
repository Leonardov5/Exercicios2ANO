using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex3
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string NIF { get; set; }
        public HashSet<Fatura> Faturas { get; set; }

        public Cliente(string nome, string nif)
        {
            this.Nome = nome;
            this.NIF = nif;
            Faturas = new HashSet<Fatura>();
        } 

    }
}
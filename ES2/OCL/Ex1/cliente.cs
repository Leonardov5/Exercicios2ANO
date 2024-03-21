using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class cliente
    {
        private string nome {get; set;}
        private string NIF {get; set;}

        public cliente(string nome, string NIF){
            this.nome = nome;
            this.NIF = NIF;
        }
    }
}
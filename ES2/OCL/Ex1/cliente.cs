using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class cliente
    {
        public string nome {get; set;}
        public string NIF {get; set;}
        public HashSet<venda> vendas {get; set;}

        public cliente(string nome, string NIF){
            this.nome = nome;
            this.NIF = NIF;
            this.vendas = new HashSet<venda>();
        }

        public bool Validate(){
            return NIF.Length == 9;
        }

        // OCL: context cliente
        // inv: NIF.size() = 9

    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class campanha
    {
        public string Nome {get; set;}
        public float valorGasto {get; set;}
        public HashSet<Restaurante> restaurantes {get; set;}

        public campanha(string Nome)
        {
            this.Nome = Nome;
            this.valorGasto = 0;
            this.restaurantes = new HashSet<Restaurante>();
        }

        public bool Validate()
        {
            return valorGasto > 0;
        }        

        // OCL: context campanha
        // inv: valorGasto > 0
    }
}
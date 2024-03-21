using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class campanha
    {
        private string Nome {get; set;}
        private float valorGestao {get; set;}
        private HashSet<Restaurante> restaurantes {get; set;}

        public campanha(string Nome)
        {
            this.Nome = Nome;
            this.valorGestao = 0;
            this.restaurantes = new HashSet<Restaurante>();
        }

        
    }
}
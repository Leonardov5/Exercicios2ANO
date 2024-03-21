using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
  
    public class Restaurante
    {
        private string Nome {get; set;}
        private float royalties {get; set;}

        public Restaurante(string Nome){
            this.Nome = Nome;
            this.royalties = 0;
        }
    }
}
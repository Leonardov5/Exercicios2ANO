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
		private HashSet<despesa> despesas {get; set;}
        private HashSet<campanha> campanhas {get; set;}
        private HashSet<alfa> alfas {get; set;}
        private HashSet<venda> vendas {get; set;}

        public Restaurante(string Nome){
            this.Nome = Nome;
            this.royalties = 0;
            this.despesas = new HashSet<despesa>();
            this.campanhas = new HashSet<campanha>();
            this.alfas = new HashSet<alfa>();
            this.vendas = new HashSet<venda>();
        }

        private Boolean isFranchisado(){
            return alfas.Count > 0;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ex1
{
  
    public class Restaurante
    {
        public string Nome {get; set;}
        public float royalties {get; set;}
		public HashSet<despesa> despesas {get; set;}
        public HashSet<campanha> campanhas {get; set;}
        public HashSet<alfa> alfas {get; set;}
        public HashSet<venda> vendas {get; set;}
        public bool franchisado {get; set;}

        public Restaurante(string Nome){
            this.Nome = Nome;
            this.royalties = 0;
            this.despesas = new HashSet<despesa>();
            this.campanhas = new HashSet<campanha>();
            this.alfas = new HashSet<alfa>();
            this.vendas = new HashSet<venda>();
        }

        public bool isFranchisado()
        {
            return this.franchisado;
        }

        public bool Validate()
        {
            if (isFranchisado())
            {
                return alfas.Count > 0;
            }
            else
            {
                var profit = vendas.Sum(v => v.valorTotal) - despesas.Sum(d => d.valor) - alfas.Sum(a => a.valorAlfa) - campanhas.Sum(c => c.valorGasto);
                return profit > 0;

                // OCL
                // context Restaurante
                // inv: not self.isFranchisado() implies self.alfas->isEmpty
                // inv: self.royalties = self.vendas->collect( v : Venda | v.valorTotal)->sum() - 
                //      self.despesas->collect( d : Despesa | d.valor)->sum() - 
                //      self.alfas->collect( a : Alfa | a.valorAlfa)->sum() - 
                //      self.campanhas->collect( c : Campanha | c.valorGasto)->sum()
            }
        }
    }
}
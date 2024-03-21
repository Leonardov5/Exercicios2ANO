using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class sobremesa
    {
        private float preco {get; set;}
        private string designacao {get; set;}
        private HashSet<pedido> pedidos {get; set;}

        public sobremesa(float preco, string designacao){
            this.preco = preco;
            this.designacao = designacao;
            this.pedidos = new HashSet<pedido>();
        }
    }
}
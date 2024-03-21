using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class bebida
    {
        private string designacao {get; set;}
        private HashSet<pedido> pedidos {get; set;}

        public bebida(string designacao){
            this.designacao = designacao;
            this.pedidos = new HashSet<pedido>();
        }
    }
}
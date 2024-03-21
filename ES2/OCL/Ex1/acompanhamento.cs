using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class acompanhamento
    {
        private string designacao {get; set;}
        private HashSet<pedido> pedidos {get; set;}

        public acompanhamento(string designacao){
            this.designacao = designacao;
            this.pedidos = new HashSet<pedido>();
        }
    }
}
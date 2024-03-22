using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class acompanhamento
    {
        private string designacao {get; set;}
        public float preco {get; set;}
        private HashSet<pedido> pedidos {get; set;}

        public acompanhamento(string designacao, float preco){
            this.designacao = designacao;
            this.preco = preco;
            this.pedidos = new HashSet<pedido>();
        }

        public bool Validate(){
            return preco > 0;
        }

        // OCL: context acompanhamento
        // inv: preco > 0
    }
}
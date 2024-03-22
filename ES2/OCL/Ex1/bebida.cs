using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class bebida
    {
        public string designacao {get; set;}
        public HashSet<pedido> pedidos {get; set;}
        public float preco {get; set;}

        public bebida(string designacao, float preco){
            this.designacao = designacao;
            this.preco = preco;
            this.pedidos = new HashSet<pedido>();
        }

        public bool Validate(){
            return preco > 0;
        }

        // OCL: context bebida
        // inv: preco > 0
    }
}
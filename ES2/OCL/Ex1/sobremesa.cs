using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class sobremesa
    {
        public float preco {get; set;}
        public string designacao {get; set;}
        public HashSet<pedido> pedidos {get; set;}

        public sobremesa(float preco, string designacao){
            this.preco = preco;
            this.designacao = designacao;
            this.pedidos = new HashSet<pedido>();
        }

        public bool Validate(){
            return preco > 0;
        }

        // OCL: context sobremesa
        // inv: preco > 0
    }
}
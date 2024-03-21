using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class menu
    {
        private float preco {get; set;}
        private string designacao {get; set;}   
        private tipoMenu tipo {get; set;}
        private HashSet<pedido> pedidos {get; set;}

        public menu(float preco, string designacao, tipoMenu tipo){
            this.preco = preco;
            this.designacao = designacao;
            this.tipo = tipo;
            this.pedidos = new HashSet<pedido>();
        }   
    }
}
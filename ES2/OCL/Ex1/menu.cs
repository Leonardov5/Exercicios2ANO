using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class menu
    {
        public float preco {get; set;}
        public string designacao {get; set;}   
        public tipoMenu tipo {get; set;}
        public HashSet<pedido> pedidos {get; set;}

        public menu(float preco, string designacao, tipoMenu tipo){
            this.preco = preco;
            this.designacao = designacao;
            this.tipo = tipo;
            this.pedidos = new HashSet<pedido>();
        } 

        public bool Validate(){
            return preco > 0;
        }

        // OCL: context menu
        // inv: preco > 0  
    }
}
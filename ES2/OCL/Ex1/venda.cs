using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class venda
    {
        public DateTime data {get; set;}
        public float valorTotal {get; set;}
        public Restaurante restaurante {get; set;}
        public cliente cliente {get; set;}
        public HashSet<pedido> pedidos {get; set;}

        public venda(DateTime data, float valorTotal, Restaurante restaurante){
            this.data = data;
            this.valorTotal = valorTotal;   
            this.restaurante = restaurante;
            this.cliente = null;
            this.pedidos = new HashSet<pedido>();
        }

        public bool Validate(){
            valorTotal = pedidos.Sum(pedido => pedido.precoTotal);
            return valorTotal > 0;
        }

        // OCL: context venda
        // inv: self.pedidos->collect(p: pedido | p.precoTotal).sum() > 0

    }
}
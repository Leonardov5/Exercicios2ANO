using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class venda
    {
        private DateTime data {get; set;}
        private float valorTotal {get; set;}
        private Restaurante restaurante {get; set;}
        private cliente cliente {get; set;}
        private HashSet<pedido> pedidos {get; set;}

        public venda(DateTime data, float valorTotal, Restaurante restaurante){
            this.data = data;
            this.valorTotal = valorTotal;   
            this.restaurante = restaurante;
            this.cliente = null;
            this.pedidos = new HashSet<pedido>();
        }
    }
}
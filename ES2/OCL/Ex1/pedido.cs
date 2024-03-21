using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class pedido
    {
        private float precoTotal {get; set;}
        private venda venda {get; set;}
        private sobremesa sobremesa {get; set;}
        private bebida bebida {get; set;}
        private acompanhamento acompanhamento {get; set;}
        private menu menu {get; set;}

        public pedido(float precoTotal, venda venda, menu){
            this.precoTotal = precoTotal;
            this.venda = venda;
            this.sobremesa = null;
            this.bebida = null;
            this.acompanhamento = null;
            this.menu = menu;
        }
    }
}
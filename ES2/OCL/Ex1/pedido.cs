using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class pedido
    {
        public float precoTotal {get; set;}
        public venda venda {get; set;}
        public sobremesa? sobremesa {get; set;}
        public bebida? bebida {get; set;}
        public acompanhamento? acompanhamento {get; set;}
        public menu menu {get; set;}

        public pedido(float precoTotal, venda venda, menu menu){
            this.precoTotal = precoTotal;
            this.venda = venda;
            this.sobremesa = null;
            this.bebida = null;
            this.acompanhamento = null;
            this.menu = menu;
        }

        public bool validate(){
            return this.precoTotal == this.menu.preco + (this.sobremesa?.preco ?? 0) + (this.bebida?.preco ?? 0) + (this.acompanhamento?.preco ?? 0);
        }
        // OCL  
        // context pedido
        // inv: self.precoTotal = self.menu.preco + ( if self.sobremesa != null then self.sobremesa.preco else 0 endif) + (if self.bebida != null then self.bebida.preco else 0 endif) + (if self.acompanhamento != null then self.acompanhamento.preco else 0 endif)
    }
}

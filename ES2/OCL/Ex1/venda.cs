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
    
        public venda(DateTime data, float valorTotal){
            this.data = data;
            this.valorTotal = valorTotal;   
    }
}
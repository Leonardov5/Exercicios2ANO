using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class alfaTotalDiario
    {
        private DateTime data {get; set;}
        private float valorALfa {get; set;}
    
        public alfaTotalDiario(DateTime data, float valorALfa){
            this.data = data;
            this.valorALfa = valorALfa;
        }
    }
}
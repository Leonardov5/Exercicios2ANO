using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class despesa
    {
        private DateTime data {get; set;}
        private float valor {get; set;}
        private string descricao {get; set;}    

        public despesa(DateTime data, float valor, string descricao){
            this.data = data;
            this.valor = valor;
            this.descricao = descricao;
        }
    }
}
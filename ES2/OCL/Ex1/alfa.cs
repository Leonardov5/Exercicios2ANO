using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class alfa
    {
        private DateTime data {get; set;}
        private float valorALfa {get; set;}
        private Restaurante restaurante {get; set;}
        private alfaTotalDiario alfaTotalDiario {get; set;}

        public alfa(DateTime data, float valorALfa, Restaurante restaurante, alfaTotalDiario alfaTotalDiario){
            this.data = data;
            this.valorALfa = valorALfa;
            this.restaurante = restaurante;
            this.alfaTotalDiario = alfaTotalDiario;
        }   
    }
}
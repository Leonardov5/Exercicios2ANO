using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class alfa
    {
        public DateTime data {get; set;}
        public float valorAlfa {get; set;}
        public Restaurante restaurante {get; set;}
        public alfaTotalDiario alfaTotalDiario {get; set;}

        public alfa(DateTime data, float valorAlfa, Restaurante restaurante, alfaTotalDiario alfaTotalDiario){
            this.data = data;
            this.valorAlfa = valorAlfa;
            this.restaurante = restaurante;
            this.alfaTotalDiario = alfaTotalDiario;
        }   

        public bool Validate(){
            return  valorAlfa > 0;
        }

        // OCL: context alfa
        // inv: valorAlfa > 0

    }
}
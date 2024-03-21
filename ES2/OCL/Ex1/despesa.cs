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
        private Restaurante restaurante {get; set;}
        private tipoDespesa tipo {get; set;}

        public despesa(DateTime data, float valor, string descricao, Restaurante restaurante, tipoDespesa tipo){
            this.data = data;
            this.valor = valor;
            this.descricao = descricao;
            this.restaurante = restaurante;
            this.tipo = tipo;
        }
    }
}
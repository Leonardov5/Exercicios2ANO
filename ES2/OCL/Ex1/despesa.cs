using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class despesa
    {
        public DateTime data {get; set;}
        public float valor {get; set;}
        public string descricao {get; set;}    
        public Restaurante restaurante {get; set;}
        public tipoDespesa tipo {get; set;}

        public despesa(DateTime data, float valor, string descricao, Restaurante restaurante, tipoDespesa tipo){
            this.data = data;
            this.valor = valor;
            this.descricao = descricao;
            this.restaurante = restaurante;
            this.tipo = tipo;
        }
    }
}
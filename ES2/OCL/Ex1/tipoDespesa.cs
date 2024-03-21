using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class tipoDespesa
    {
        private int codigo {get; set;}
        private string designacao {get; set;}
        private HashSet<despesa> despesas {get; set;}

        public tipoDespesa(int codigo, string designacao){
            this.codigo = codigo;
            this.designacao = designacao;
            this.despesas = new HashSet<despesa>();
        }
    }
}
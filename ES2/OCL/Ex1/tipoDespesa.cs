using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class tipoDespesa
    {
        public int codigo {get; set;}
        public string designacao {get; set;}
        public HashSet<despesa> despesas {get; set;}

        public tipoDespesa(int codigo, string designacao){
            this.codigo = codigo;
            this.designacao = designacao;
            this.despesas = new HashSet<despesa>();
        }
    }
}
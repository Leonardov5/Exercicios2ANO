using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class tipoMenu
    {
        private int codigo {get; set;}
        private string designacao {get; set;}

        public tipoMenu(int codigo, string designacao){
            this.codigo = codigo;
            this.designacao = designacao;
        }
    }
}
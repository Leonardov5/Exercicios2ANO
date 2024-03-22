using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class tipoMenu
    {
        public int codigo {get; set;}
        public string designacao {get; set;}
        public HashSet<menu> menus {get; set;}

        public tipoMenu(int codigo, string designacao){
            this.codigo = codigo;
            this.designacao = designacao;
            this.menus = new HashSet<menu>();
        }
    }
}
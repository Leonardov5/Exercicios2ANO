using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class menu
    {
        private float preco {get; set;}
        private string designacao {get; set;}   

        public menu(float preco, string designacao){
            this.preco = preco;
            this.designacao = designacao;
        }   
    }
}
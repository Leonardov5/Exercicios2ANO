using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2
{
    public class Drama : Programa
    {
        public Drama(string titulo, float duracao, string realizador) : base(titulo, duracao, realizador)
        {
        }
    }
}
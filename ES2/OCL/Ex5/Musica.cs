using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex5
{
    public class Musica : ItemStream
    {
        public string Banda { get; set; }
        public string Letra { get; set; }

        public Musica(string Nome, float Duracao, string banda, string letra) : base(Nome, Duracao)
        {
            this.Banda = banda;
            this.Letra = letra;
        }
    }
}
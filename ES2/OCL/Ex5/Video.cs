using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex5
{
    public class Video : ItemStream
    {
        public HashSet<string> Artistas { get; set; }

        public Video(string Nome, float Duracao) : base(Nome, Duracao)
        {
            this.Artistas = new HashSet<string>();
        }
    }
}
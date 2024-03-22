using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex4
{
    public class Ator
    {
        public string nome { get; set; }
        public string shortBio { get; set; }
        public HashSet<Filme> filmes { get; set; }
        public HashSet<Serie> series { get; set; }

        public Ator(string nome, string shortBio)
        {
            this.nome = nome;
            this.shortBio = shortBio;
            this.filmes = new HashSet<Filme>();
            this.series = new HashSet<Serie>();
        }

    }
}
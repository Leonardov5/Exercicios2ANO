using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2
{
    public class Ator
    {
        public string Nome {get; set;}
        public int shortBio {get; set;}
        private HashSet<string> programasParticipados;

        public Ator(string nome, int shortBio)
        {
            this.Nome = nome;
            this.shortBio = shortBio;
            programasParticipados = new HashSet<string>();
        }
    }
}
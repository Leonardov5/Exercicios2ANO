using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex4
{
    public class Filme
    {
        private string titulo;
        private float duracao;
        private string realizador;
        private HashSet<Ator> atores;
        private HashSet<ProgramacaoDiaria> dias;

        public Filme(string titulo, float duracao, string realizador)
        {
            this.titulo = titulo;
            this.duracao = duracao;
            this.realizador = realizador;
            this.atores = new HashSet<Ator>();
            this.dias = new HashSet<ProgramacaoDiaria>();
        }

        public string getTitulo()
        {
            return this.titulo;
        }

        public float getDuracao()
        {
            return this.duracao;
        }   

        public string getRealizador()
        {
            return this.realizador;
        }

        public HashSet<string> getNomesElenco()
        {
            return this.atores.Select(a => a.nome).ToHashSet();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex4
{
    public class Serie
    {
        private string titulo;
        private string realizador;
        private int numTemporadas;
        private HashSet<Ator> atores;
        private HashSet<Episodio> episodios;

        public Serie(string titulo, string realizador, int numTemporadas)
        {
            this.titulo = titulo;
            this.realizador = realizador;
            this.numTemporadas = numTemporadas;
            this.atores = new HashSet<Ator>();
            this.episodios = new HashSet<Episodio>();
        }

        public string getTituloSerie()
        {
            return this.titulo;
        }

        public string getRealizador()
        {
            return this.realizador;
        }

        public HashSet<string> getNomesElenco()
        {
            return this.atores.Select(a => a.nome).ToHashSet();
        }

        public bool validate(){
            return this.numTemporadas == (int)episodios.Select(e => e.getTemporada()).Max();
        }

        // OCL
        // context Serie
        // inv: self.numTemporada = self.episodios->collect(e : Episodio | e.temporada)->max()
    }
}
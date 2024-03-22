using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex4
{
    public class Episodio
    {
        private int temporada;
        private int numero;
        private string titulo;
        private float duracao;
        private Serie serie;

        public Episodio(int temporada, int numero, string titulo, float duracao, Serie serie)
        {
            this.temporada = temporada;
            this.numero = numero;
            this.titulo = titulo;
            this.duracao = duracao;
            this.serie = serie;
        }

        public string getTituloEpisodio()
        {
            return this.titulo;
        }

        public float getDuracao()
        {
            return this.duracao;
        }

        public float getTemporada()
        {
            return this.temporada;
        }
    }
}
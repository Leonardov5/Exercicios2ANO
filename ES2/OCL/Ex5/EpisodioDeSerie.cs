using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex5
{
    public class EpisodioDeSerie : ItemStream
    {
        public int NumeroEpisodio { get; set; }
        public string Descricao { get; set; }

        public EpisodioDeSerie(string Nome, float Duracao, int numeroEpisodio, string descricao) : base(Nome, Duracao)
        {
            this.NumeroEpisodio = numeroEpisodio;
            this.Descricao = descricao;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex5
{
    public class ItemStream
    {
        public string Nome { get; set; }
        public float Duracao { get; set; }
        public HashSet<Playlist> playlists { get; set; }

        public ItemStream(string nome, float Duracao)
        {
            this.Nome = nome;
            this.Duracao = Duracao;
            this.playlists = new HashSet<Playlist>();
        }
    }
}
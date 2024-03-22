using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex5
{
    public class Playlist
    {
        public string Nome { get; set; }
        public float Duracao { get; set; }
        public Utilizador Owner { get; set; }
        public HashSet<Utilizador> subscritores { get; set; }
        public HashSet<ItemStream> itensPlaylist { get; set; }

        public Playlist(string nome, float Duracao, Utilizador owner)
        {
            this.Nome = nome;
            this.Duracao = Duracao;
            this.Owner = owner;
            this.subscritores = new HashSet<Utilizador>();
            this.itensPlaylist = new HashSet<ItemStream>();
        }

        public bool validate()
        {
            return this.itensPlaylist.Sum(i => i.Duracao) == this.Duracao;
        }

        // OCL
        // context Playlist 
        // inv: self.duracao = self.itensPlaylist->collect(i : ItemStream | i.duracao)->sum()
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex5
{
    public class Utilizador
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public HashSet<Playlist> playlistsSubscritas { get; set; }
        public HashSet<Playlist> playlistsCriadas { get; set; }


        public Utilizador(string nome, string email, string username, string password)
        {
            this.Nome = nome;
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.playlistsSubscritas = new HashSet<Playlist>();
            this.playlistsCriadas = new HashSet<Playlist>();
        }
    }
}
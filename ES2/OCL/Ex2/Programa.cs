using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2
{
    public class Programa
    {
        private string titulo;
        private float duracao;
        private string realizador;
    
        public Programa(string titulo, float duracao, string realizador)
        {
            this.titulo = titulo;
            this.duracao = duracao;
            this.realizador = realizador;
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
    }
}
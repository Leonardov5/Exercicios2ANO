using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex5
{
    public class PodCast : ItemStream
    {
        public string Descricao { get; set; }
        public string TecnicoDeSom { get; set; }

        public PodCast(string Nome, float Duracao, string descricao, string tecnicoDeSom) : base(Nome, Duracao)
        {
            this.Descricao = descricao;
            this.TecnicoDeSom = tecnicoDeSom;
        }
    }
}
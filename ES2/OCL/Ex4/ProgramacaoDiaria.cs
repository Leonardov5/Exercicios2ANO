using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex4
{
    public class ProgramacaoDiaria
    {
        public DateTime data { get; set; }
        public HashSet<Filme> filmes { get; set; }

        public ProgramacaoDiaria(DateTime data)
        {
            this.data = data;
            this.filmes = new HashSet<Filme>();
        }

        public void addPrograma(Filme filme)
        {
            this.filmes.Add(filme);
        }
    }
}
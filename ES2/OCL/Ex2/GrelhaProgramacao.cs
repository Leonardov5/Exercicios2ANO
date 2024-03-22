using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2
{
    public class GrelhaProgramacao
    {
        private DateTime data;
        private HashSet<Programa> programas;

        public GrelhaProgramacao(DateTime data)
        {
            this.data = data;
            programas = new HashSet<Programa>();
        }

        public void addPrograma(Programa prog)
        {
            programas.Add(prog);
        }

        public bool validate(){
            return programas.Sum(x => x.getDuracao()) <= 24;
        }

        // OCL
        // context GrelhaProgramacao
        // inv: programa->collect()(p: Programa | p.getDuracao())->sum() <= 24
        
    }
}
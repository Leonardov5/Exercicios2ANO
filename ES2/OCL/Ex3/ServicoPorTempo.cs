using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex3
{
    public class ServicoPorTempo : Servico
    {
        public float precoPorHora { get; set; }
        public HashSet<LinhaServicoTempo> faturas { get; set; }

        public ServicoPorTempo(string nome, float precoPorHora) : base(nome)
        {
            this.precoPorHora = precoPorHora;
            faturas = new HashSet<LinhaServicoTempo>();
        }
    }
}
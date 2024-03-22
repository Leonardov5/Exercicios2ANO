using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex3
{
    public class LinhaServicoTempo : LinhaFatServico
    {
        public float precoPorHora { get; set; }
        public float tempo { get; set; }  
        public ServicoPorTempo servicoPorTempo { get; set; }

        public LinhaServicoTempo(float precoPorHora, float tempo, ServicoPorTempo servicoPorTempo) : base(0, DateTime.Now, "", null)
        {
            this.precoPorHora = precoPorHora;
            this.tempo = tempo;
            this.servicoPorTempo = servicoPorTempo;
        }  
    }
}
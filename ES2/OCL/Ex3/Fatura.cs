using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex3
{
    public class Fatura
    {
        public float valorTotal { get; set; }
        public DateTime data { get; set; }
        public Cliente cliente { get; set; }
        public HashSet<LinhaFatura> LinhasFatura { get; set; }

        public Fatura(float valorTotal, DateTime data, Cliente cliente)
        {
            this.valorTotal = valorTotal;
            this.data = data;
            this.cliente = cliente;
            LinhasFatura = new HashSet<LinhaFatura>();
        }
    }
}
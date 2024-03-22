using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex3
{
    public class ServicoPrecoFixo : Servico
    {
        public float precoTotal { get; set; }
        public HashSet<LinhaServicoFixo> faturas { get; set; }

        public ServicoPrecoFixo(string nome, float precoTotal) : base(nome)
        {
            this.precoTotal = precoTotal;
            faturas = new HashSet<LinhaServicoFixo>();
        }
    }
}
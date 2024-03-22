using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Ex3
{
    public class LinhaServicoFixo : LinhaFatServico
    {
        public float precoFixo { get; set; }
        public ServicoPrecoFixo servicoPrecoFixo { get; set; }
        public LinhaServicoFixo(float valorLinha, DateTime data, string descricao, Fatura fatura, float precoFixo, ServicoPrecoFixo servicoPrecoFixo) : base(valorLinha, data, descricao, fatura)
        {
            this.servicoPrecoFixo = servicoPrecoFixo;
            this.precoFixo = precoFixo;
        }
    }
}
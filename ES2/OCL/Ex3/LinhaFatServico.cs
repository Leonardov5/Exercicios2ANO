using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex3
{
    public class LinhaFatServico : LinhaFatura
    {
        public LinhaFatServico(DateTime data, string descricao, Fatura fatura) : base(data, descricao, fatura)
        {       
        }
    }
}
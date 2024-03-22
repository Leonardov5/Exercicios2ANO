using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex3
{
    public class LinhaFatProduto : LinhaFatura
    {   
        public float precoUnitario { get; set; }
        public int quantidade { get; set; }
        public Produto produto { get; set; }

        public LinhaFatProduto(DateTime data, string descricao, Fatura fatura, int quantidade, Produto produto) : base(data, descricao, fatura)
        {
            this.produto = produto;
            this.precoUnitario = produto.precoUnit;
            this.quantidade = quantidade;
        }
    }
}
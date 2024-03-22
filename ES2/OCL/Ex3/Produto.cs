using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex3
{
    public class Produto
    {
        public string nome { get; set; }
        public float precoUnit { get; set; }
        public HashSet<LinhaFatProduto> faturas { get; set; }

        public Produto(string nome, float precoUnit)
        {
            this.nome = nome;
            this.precoUnit = precoUnit;
            faturas = new HashSet<LinhaFatProduto>();
        }
    }
}
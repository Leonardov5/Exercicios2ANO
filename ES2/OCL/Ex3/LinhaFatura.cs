using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex3
{
    public class LinhaFatura
    {
        public float valorLinha { get; set; }
        public DateTime data { get; set; }
        public string descricao { get; set; }
        public Fatura fatura { get; set; }

        public LinhaFatura(DateTime data, string descricao, Fatura fatura)
        {
            this.data = data;
            this.descricao = descricao;
            this.fatura = fatura;

            if (this.GetType() == typeof(LinhaFatProduto))
            {
                this.valorLinha = ((LinhaFatProduto)this).precoUnitario * ((LinhaFatProduto)this).quantidade;
            }else if (this.GetType() == typeof(LinhaFatServico))
            {
                if (this.GetType() == typeof(LinhaServicoTempo))
                {
                    this.valorLinha = ((LinhaServicoTempo)this).precoPorHora * ((LinhaServicoTempo)this).tempo;
                }
                else if (this.GetType() == typeof(LinhaServicoFixo))
                {
                    this.valorLinha = ((LinhaServicoFixo)this).precoFixo;
                }
            }
        }

        // OCL
        // Context LinhaFatura
        // inv: if (self.oclIsTypeOf(LinhaFatProduto))then self.valorLinha = self.oclAsType(LinhaFatProduto).precoUnitario * self.oclAsType(LinhaFatProduto).quantidade endif
        // or
        // if (self.oclIsTypeOf(LinhaFatServico) and self.oclIsKindOf(LinhaServicoTempo)) then self.valorLinha = self.oclAsType(LinhaServicoTempo).precoPorHora * self.oclAsType(LinhaServicoTempo).tempo endif
        // or
        // if (self.oclIsTypeOf(LinhaFatServico) and self.oclIsKindOf(LinhaServicoFixo)) then self.valorLinha = self.oclAsType(LinhaServicoFixo).precoTotal endif
    }
}
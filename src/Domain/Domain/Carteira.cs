using System;
using System.Collections.Generic;
using Domain.ChildEntity;
using Domain.ValueObject;

namespace Domain
{
    public class Carteira
    {
        public Carteira(TipoCarteira tipoCarteira)
        {
            _id = new Guid();
            Ativos = new List<Ativo>();
            TipoCarteira = tipoCarteira;
        }

        public Guid _id { get; private set; }
        public List<Ativo> Ativos { get; private set; }
        public TipoCarteira TipoCarteira { get; private set; }
        public decimal PorcentagemDeLucro { get; private set; }
        public decimal ValorTotalBruto { get; private set; }
        public decimal ValorTotalAtualizado { get; private set; }
        public decimal ValorUnitarioDoAtivoAtualizado { get; private set; }
        public decimal Lucro { get; private set; }
        public decimal QuantidadeTotal { get; private set; }

        public void AdicionarAtivo(Ativo ativo)
        {
            //Todo: O tipo da carteira precisa ser o mesmo tipo do ativo?
            Ativos.Add(ativo);
            CalcularQuantidadeTotal(ativo);
            CalcularValorTotalBruto(ativo);
        }
        private void CalcularQuantidadeTotal(Ativo ativo)
        {
            QuantidadeTotal = QuantidadeTotal + ativo.Quantidade;
        }

        private void CalcularValorTotalBruto(Ativo ativo)
        {
            ValorTotalBruto = ValorTotalBruto + ativo.ValorUnitarioNaCompra / ativo.Quantidade;
        }
        public void AtualizarValorDoAtivo(decimal valorUnitarioDoAtivoAtualizado)
        {
            ValorUnitarioDoAtivoAtualizado = valorUnitarioDoAtivoAtualizado;
            CalcularLucro();
            CalcularPorcentagemDeLucro();
        }
        private void CalcularLucro()
        {
            Lucro = ValorTotalBruto - ValorTotalAtualizado;
        }

        private void CalcularPorcentagemDeLucro()
        {
            PorcentagemDeLucro = (ValorTotalAtualizado - ValorTotalBruto) / ValorTotalBruto;
        }
    }
}
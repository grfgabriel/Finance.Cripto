using System;
using Domain.ChildEntity;

namespace Domain.ValueObject
{
    public class Lancamento
    {
        public Lancamento(string nomeAtivo, TipoAtivo tipoAtivo, decimal preco, decimal quantidade, DateTime? dataDaCompra)
        {
            NomeAtivo = nomeAtivo;
            TipoAtivo = tipoAtivo;
            Preco = preco;
            Quantidade = quantidade;
            CalculaCusto();
            DataDaCompra = dataDaCompra.HasValue? dataDaCompra.Value: DateTime.Now;

        }
        public Guid _id {get; private set;}

        public Guid IdCarteira {get; private set;}
        public string NomeAtivo { get; private set; }
        public TipoAtivo TipoAtivo { get; private set; }
        public decimal Preco { get; private set; }
        public decimal Custo { get; private set; }
        public decimal Quantidade { get; private set; }
        public DateTime DataDaCompra { get; private set; }

        private void CalculaCusto()
        {
            Custo = Quantidade * Preco;
            Custo = Decimal.Round(Custo, 2);
        }
    }
}
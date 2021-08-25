using System;
using Domain.ChildEntity;

namespace Domain.ValueObject
{
    public class Ativo
    {
        public Ativo(string nome, TipoAtivo tipoAtivo, decimal valorUnitarioNaCompra, decimal quantidade, DateTime? dataDaCompra)
        {
            Nome = nome;
            TipoAtivo = tipoAtivo;
            ValorUnitarioNaCompra = valorUnitarioNaCompra;
            Quantidade = quantidade;
            DataDaCompra = dataDaCompra.HasValue? dataDaCompra.Value: DateTime.Now;

        }
        public Guid IdCarteira {get; private set;}
        public string Nome { get; private set; }
        public TipoAtivo TipoAtivo { get; private set; }
        public decimal ValorUnitarioNaCompra { get; private set; }
        public decimal Quantidade { get; private set; }
        public DateTime DataDaCompra { get; private set; }
    }
}
using System;
using Domain.ChildEntity;
using Service.Commons;

namespace Service.BoundedContext.NovaCompra.Input
{
    public class NovaCompraInput
    {
        public TipoCarteira TipoCarteira { get; set; }
        public string NomeDoAtivo { get; set; }
        public TipoAtivoInput TipoAtivo { get; set; }
        public decimal ValorUnitarioNaCompra { get; set; }
        public decimal Quantidade { get; set; }
        public DateTime? DataDaCompra { get; set; }
    }
}
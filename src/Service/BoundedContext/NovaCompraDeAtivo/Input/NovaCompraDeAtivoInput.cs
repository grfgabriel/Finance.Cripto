using System;
using Domain.ChildEntity;
using Service.Commons;

namespace Service.BoundedContext.NovaCompraDeAtivo.Input
{
    public class NovaCompraDeAtivoInput
    {
        public TipoCarteira TipoCarteira { get; set; }
        public string Nome { get; set; }
        public TipoAtivoInput TipoAtivo { get; set; }
        public decimal ValorUnitarioNaCompra { get; set; }
        public decimal Quantidade { get; set; }
        public DateTime? DataDaCompra { get; set; }
    }
}
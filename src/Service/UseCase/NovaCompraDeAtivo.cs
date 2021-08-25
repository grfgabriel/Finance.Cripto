using System.Threading.Tasks;
using Domain.ChildEntity;
using Domain.Data.Interface;
using Domain.ValueObject;
using Service.BoundedContext.NovaCompraDeAtivo.Input;

namespace Service.UseCase
{
    public class NovaCompraDeAtivo
    {
        public NovaCompraDeAtivo(ICarteiraRepository carteiraRepository)
            => _carteiraRepository = carteiraRepository;

        private readonly ICarteiraRepository _carteiraRepository;

        public async Task Handler(NovaCompraDeAtivoInput input)
        {
            var carteira = await _carteiraRepository.Get(input.TipoCarteira);

            Ativo ativo = new Ativo(input.Nome, (TipoAtivo)input.TipoAtivo,
            input.ValorUnitarioNaCompra, input.Quantidade, input.DataDaCompra);
            carteira.AdicionarAtivo(ativo);
        }
    }





}
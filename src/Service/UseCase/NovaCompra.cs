using System.Threading.Tasks;
using Domain.ChildEntity;
using Domain.Data.Interface;
using Domain.ValueObject;
using Service.BoundedContext.NovaCompra.Input;

namespace Service.UseCase
{
    public class NovaCompra
    {
        public NovaCompra(ICarteiraRepository carteiraRepository)
            => _carteiraRepository = carteiraRepository;

        private readonly ICarteiraRepository _carteiraRepository;

        public async Task Handler(NovaCompraInput input)
        {
            var carteira = await _carteiraRepository.GetAsync(input.TipoCarteira);

            Lancamento lancamento = new Lancamento(input.NomeDoAtivo, (TipoAtivo)input.TipoAtivo,
            input.ValorUnitarioNaCompra, input.Quantidade, input.DataDaCompra);
            carteira.NovoLancamento(lancamento);

            await _carteiraRepository.UpdateAsync(carteira);
        }
    }





}
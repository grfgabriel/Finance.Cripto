using System.Threading.Tasks;
using Domain.Data.Interface;
using Service.BoundedContext.AtualizarValorDoAtivo.Input;

namespace Service.UseCase
{
    public class AtualizarValorDoAtivo
    {
        public AtualizarValorDoAtivo(ICarteiraRepository carteiraRepository)
            => _carteiraRepository = carteiraRepository;

        private readonly ICarteiraRepository _carteiraRepository;


        public async Task Handler(AtualizarValorDoAtivoInput input)
        {
            var carteira = await _carteiraRepository.Get(input.TipoCarteira);
            carteira.AtualizarValorDoAtivo(input.ValorUnitarioDoAtivoAtualizado);
        }
    }
}
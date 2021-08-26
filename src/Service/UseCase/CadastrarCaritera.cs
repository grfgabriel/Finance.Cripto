using System.Threading.Tasks;
using Domain;
using Domain.Data.Interface;
using Service.BoundedContext.CadastrarCaritera.Input;

namespace Service.UseCase
{
    public class CadastrarCaritera
    {
        public CadastrarCaritera(ICarteiraRepository carteiraRepository)
        => _carteiraRepository = carteiraRepository;
        private readonly ICarteiraRepository _carteiraRepository;
        public async Task Handler(CadastrarCariteraInput input)
        {
            Carteira carteira = new Carteira(input.tipoCarteira);
            await _carteiraRepository.CreateAsync(carteira);
        }
    }
}
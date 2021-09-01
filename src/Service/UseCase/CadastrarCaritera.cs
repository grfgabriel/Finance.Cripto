using System.Threading;
using System.Threading.Tasks;
using Domain;
using Domain.Data.Interface;
using MediatR;
using Service.BoundedContext.CadastrarCaritera.Input;
using Service.BoundedContext.CadastrarCaritera.Output;

namespace Service.UseCase
{
    public class CadastrarCaritera: IRequestHandler<CadastrarCariteraInput, CadastrarCariteraOutput>
    {
        public CadastrarCaritera(ICarteiraRepository carteiraRepository)
        => _carteiraRepository = carteiraRepository;
        private readonly ICarteiraRepository _carteiraRepository;

        public async Task<CadastrarCariteraOutput> Handle(CadastrarCariteraInput request, CancellationToken cancellationToken)
        {
            Carteira carteira = new Carteira(request.tipoCarteira);
            await _carteiraRepository.CreateAsync(carteira);   
            
            var result = new CadastrarCariteraOutput();
            return result;
        }
    }
}
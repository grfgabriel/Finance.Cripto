using System.Threading.Tasks;
using Domain.ChildEntity;

namespace Domain.Data.Interface
{
    public interface ICarteiraRepository
    {
        Task Create(Carteira carteira);
        Task<Carteira> Get(TipoCarteira tipoCarteira);
    }
}
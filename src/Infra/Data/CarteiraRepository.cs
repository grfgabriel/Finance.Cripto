using System.Threading.Tasks;
using Domain;
using Domain.ChildEntity;
using Domain.Data.Interface;
using MongoDB.Driver;
using System.Linq;

namespace Infra.Data
{
    public class CarteiraRepository : ICarteiraRepository
    {
        private readonly IMongoCollection<Carteira> _carteiraCollection;
        public CarteiraRepository()
        {
            //Todo: Pegar conection string do config. 
            var client = new MongoClient(
                "mongodb+srv://user_app:user_app!@localhost:27017"
            );
            
            _carteiraCollection = client.GetDatabase("FinanceCripto").GetCollection<Carteira>(nameof(Carteira));

        }
        public async Task CreateAsync(Carteira carteira)
        {
            await _carteiraCollection.InsertOneAsync(carteira);
        }

        public async Task<Carteira> GetAsync(TipoCarteira tipoCarteira)
        {
            var result = await _carteiraCollection.FindAsync<Carteira>(carteira => carteira.TipoCarteira == tipoCarteira);
            return result.FirstOrDefault();
        }

        public async Task UpdateAsync(Carteira carteira)
        {
            await _carteiraCollection.ReplaceOneAsync(x => x._id == carteira._id, carteira);
        }
    }
}
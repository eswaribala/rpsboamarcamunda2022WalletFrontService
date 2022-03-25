using MongoDB.Driver;
using WalletFrontService.Models;

namespace WalletFrontService.Repository
{
    public class WalletMongoRepository
    {
        private IConfiguration _configuration;
        private IMongoDatabase _db;
        public WalletMongoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            MongoClient _client = new MongoClient(_configuration["MongoUrl"]);
            _db = _client.GetDatabase(_configuration["MongoDatabase"]);
        }

        

        //findall
        public List<WalletMongoEntity> GetWallets()
        {
            return _db.GetCollection<WalletMongoEntity>(_configuration["MongoCollection"]).Find(_ => true).ToList();
        }
    }

}

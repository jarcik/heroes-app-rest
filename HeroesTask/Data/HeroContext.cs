using HeroesTask.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace HeroesTask.Data
{
    public class HeroContext
    {

        private readonly IMongoDatabase _database = null;

        public HeroContext(IOptions<MongoDbSettings> mongoDbSettings)
        {
            var client = new MongoClient(mongoDbSettings.Value.ConnectionString);
            if (client != null)
                _database.Client.GetDatabase(mongoDbSettings.Value.Database);
        }

        public IMongoCollection<Hero> Heroes => _database.GetCollection<Hero>("Hero");
    }
}

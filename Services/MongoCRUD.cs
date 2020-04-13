using MongoDB.Driver;

namespace Akko.Services
{
    public class MongoService
    {
        private IMongoDatabase db;

        public MongoService(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }
    }
}
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace corsoIngProject.Dal
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database = null;
        private IMongoCollection<Student> students;

        public MongoDbContext(IOptions<Settings> settings)
        {
            var client = new MongoClient();
            if(client != null)
            {
                _database = client.GetDatabase(settings.Value.DatabaseName);
                students = _database.GetCollection<Student>(settings.Value.CollectionName);
            }
        }

        public IMongoCollection<Student> Students
        {
            get
            {
                return students;
            }
        }
    }
}

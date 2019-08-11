namespace XamarinBus
{
  using MongoDB.Driver;
  using MongoDB.Bson;
  using System;
  using System.Threading.Tasks;
  //using MongoDB.Driver.Builders;
  //using MongoDB.Driver.GridFS;
  using MongoDB.Driver.Linq;

  class BusService
  {
    public ObjectId Id { get; set; }
    public string Name { get; set; }

    static void Main(string[] args)
    {
      var client = new MongoClient();
      var database = client.GetDatabase("FredsDB");
      var collection = database.GetCollection<BsonDocument>("FredsCollection");
      var document = new BsonDocument
      {
          { "name", "MongoDB" },
          { "type", "Database" },
          { "count", 1 },
          { "info", new BsonDocument
          {
              { "x", 203 },
              { "y", 102 }
          }}
      };
      collection.InsertOne(document);
      
    }
  }
}

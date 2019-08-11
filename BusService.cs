namespace XamarinBus
{
  using MongoDB.Driver;
  using MongoDB.Bson;
  using System;
  using System.Threading.Tasks;
  //using MongoDB.Driver.Builders;
  //using MongoDB.Driver.GridFS;
  using MongoDB.Driver.Linq;
  using System.Web;

  public class BusService
  {
    private static MongoClient client { get; set; }
    private static IMongoDatabase db { get; set; }
    private static IMongoCollection<BsonDocument> collection { get; set; }

    static void Main(string[] args)
    {
      client = new MongoClient();
      db = client.GetDatabase("FredsDB");
      collection = db.GetCollection<BsonDocument>("FredsCollection");
      IntegrationTest test = new IntegrationTest();
    }

    public bool AddADocument(BsonDocument dtoDocument)
    {
      try
      {
        collection.InsertOne(dtoDocument);
      }
      catch (Exception e)
      {
        return false;
      }
      return true;
    }
  }
}

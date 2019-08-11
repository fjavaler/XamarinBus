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
    private static IMongoCollection<PlayerDTO> collection { get; set; }

    static void Main(string[] args)
    {
      client = new MongoClient();
      db = client.GetDatabase("FredsDB");
      collection = db.GetCollection<PlayerDTO>("FredsCollection");
    }

    public bool AddADocument(PlayerDTO dto)
    {
      try
      {
        BsonDocument player = (BsonDocument)dto.ToBson();
      }
      catch (Exception e)
      {
        return false;
      }
      return true;
    }
  }
}

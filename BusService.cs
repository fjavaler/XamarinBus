namespace XamarinBus
{
  using MongoDB.Driver;
  using MongoDB.Bson;
  using System;
  using System.Threading.Tasks;
  //using MongoDB.Driver.GridFS;
  using MongoDB.Driver.Linq;
  using System.Web;
  using System.Collections.Generic;
  using System.Linq;

  public class BusService
  {
    private static MongoClient client { get; set; }

    private static IMongoDatabase db { get; set; }
    private static IMongoCollection<BsonDocument> collection { get; set; }

    public static void Main(string[] args)
    {
      client = new MongoClient();
      db = client.GetDatabase("FredsDB");
      collection = db.GetCollection<BsonDocument>("FredsCollection");

      // for testing purposes
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
        Console.WriteLine(e.Message);
      }
      return true;
    }

    public List<BsonDocument> FindAllDocuments()
    {
      var filter = "{ }";
      return collection.Find(filter).ToList();

    }

    public bool RemoveADocument(string id)
    {
      string filter = "{ _id: ObjectId(\"" + id + "\") }";
      try
      {
        collection.FindOneAndDelete(filter);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        return false;
      }
      return true;
    }

    public BsonDocument FindDocumentByID(string _id)
    {
      string filter = "{ _id: ObjectId(\"" + _id + "\") }";
      BsonDocument result = new BsonDocument();
      try
      {
        //result = collection.UpdateOne
      }
      catch (Exception e)
      {
        throw new Exception(e.Message);
      }

      return result;
    }

    public bool UpdateADocument(string updateId, string firstName, string lastName, string position)
    {
      string filter = "{ _id: ObjectId(\"" + updateId + "\") }";
      PlayerDTO dto = new PlayerDTO("Donovan","Mitchell", "SG");
      BsonDocument playerUpdate = dto.DtoToBsonDocument();

      try
      {
        //List<BsonDocument> list = collection.Find(filter);
        collection.UpdateOne
          (
            { "firstName", firstName},
            { "lastName", lastName},
            { "position", position},
          );
      }
      catch (Exception e)
      {
        Console.WriteLine("updateADocument failed. " + e.Message);
      }
      return true;
    }
  }
}

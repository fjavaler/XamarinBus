using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Threading.Tasks;

namespace XamarinBus
{
  class IntegrationTest
  {
    private BusService service;
    // Needed for find and remove tests.
    private const string FINDANDREMOVEID = "5d50af74c1eb715eb0bdc651";
    private const string UPDATEID = "5d50b11d7192857e60b468a0";

    public IntegrationTest()
    {
      service = new BusService();

      //// Add a document Test.
      //Console.WriteLine("Add a document test:");
      //PlayerDTO dto = new PlayerDTO("Joe", "Ingles", "C");
      //BsonDocument document = dto.DtoToBsonDocument();
      //bool addResult = service.AddADocument(document);
      //if (addResult == false)
      //  throw new Exception("AddADocument failed.");
      //else
      //{
      //  List<BsonDocument> list4 = service.FindAllDocuments();
      //  foreach (BsonDocument player in list4)
      //  {
      //    Console.WriteLine(player.ToJson());
      //  }
      //}

      //// Find a document by ID test.
      //Console.WriteLine("\nFind a document test:");
      //BsonDocument bson = service.FindDocumentByID(FINDANDREMOVEID);
      //Console.WriteLine(bson.ToJson());

      //// Find all documents test.
      //Console.WriteLine("\nFind all documents test:");
      //List<BsonDocument> list2 = service.FindAllDocuments();
      //foreach (BsonDocument player in list2)
      //{
      //  Console.WriteLine(player.ToJson());
      //}

      //// Remove a document test.
      //Console.WriteLine("\nRemove a document test:");
      //// Manually enter the id to Remove here
      //bool removeResult = service.RemoveADocument(FINDANDREMOVEID);
      //if(removeResult == false)
      //{
      //  Console.WriteLine("Remove a document test failed");
      //  throw new Exception("RemoveADocument returned false.");
      //}
      //else
      //{
      //  List<BsonDocument> list3 = service.FindAllDocuments();
      //  foreach (BsonDocument player in list3)
      //  {
      //    Console.WriteLine(player.ToJson());
      //  }
      //}

      string firstName = "Donovan";
      string lastName = "Mitchell";
      string position = "SG";

      // Update a document test.
      Console.WriteLine("\nUpdate a document test:");
      bool updateResult = service.UpdateADocument(UPDATEID, firstName, lastName, position);
    }
  }
}

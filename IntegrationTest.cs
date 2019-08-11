using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;

namespace XamarinBus
{
  class IntegrationTest
  {
    private BusService service;
    
    public IntegrationTest()
    {
      service = new BusService();
      PlayerDTO dto = new PlayerDTO("Joe", "Ingles", "C");
      BsonDocument document = dto.DtoToBsonDocument();
      bool result = service.AddADocument(document);
      if (result == false)
        throw new ArgumentNullException();
    }
  }
}

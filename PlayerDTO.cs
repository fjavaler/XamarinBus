using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;

namespace XamarinBus
{
  public class PlayerDTO
  {
    private string firstName { get; set; }
    private string lastName { get; set; }
    private string position { get; set; }
    private string id { get; set; }

    public PlayerDTO(string _firstName, string _lastName, string _position)
    {
      firstName = _firstName;
      lastName = _lastName;
      position = _position;
    }

    public BsonDocument DtoToBsonDocument()
    {
      BsonDocument document = new BsonDocument()
      {
        { "firstName", this.firstName },
        { "lastName", this.lastName },
        { "position", this.position },
      };

      return document;
    }

    public PlayerDTO BsonDocumentToDto(string firstName, string lastName, string position)
    {
      PlayerDTO playerDto = new PlayerDTO(firstName, lastName, position);
      return playerDto;
    }
  }
}

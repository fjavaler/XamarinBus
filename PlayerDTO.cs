using System;
using System.Collections.Generic;
using System.Text;

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
  }
}

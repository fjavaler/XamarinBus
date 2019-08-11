using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinBus
{
  class IntegrationTests
  {
    private BusService service;
    
    public IntegrationTests()
    {
      service = new BusService();
      PlayerDTO dto = new PlayerDTO("Joe", "Ingles", "C");
      service.AddADocument(dto);
    }
  }
}

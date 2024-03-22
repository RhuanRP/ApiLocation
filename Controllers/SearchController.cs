using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class SearchController : ControllerBase
{
  [HttpGet]
  public IEnumerable<object> Search(string cityName)
  {
    var cities = DataLoad.Cidades().Where(city => city.name.Contains(cityName));
    var result = new List<object>();

    foreach (var city in cities)
    {
      var state = DataLoad.Estados().FirstOrDefault(s => s.state_code == city.state_code);
      var country = DataLoad.Paises().FirstOrDefault(c => c.iso2 == city.country_code);
      result.Add(new
      {
        City = city.name,
        State = state?.name,
        Country = country?.name
      });
    }

    return result;
  }
}

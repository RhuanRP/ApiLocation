using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class CitiesController : ControllerBase
{
  [HttpGet]
  public IEnumerable<string> GetCities(string stateCode, string countryCode)
  {
    var cities = DataLoad.Cidades().Where(cities => cities.state_code == stateCode && cities.country_code == countryCode);
    return cities.Select(cities => cities.name).ToList();
  }
}
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class CountriesController : ControllerBase
{
  [HttpGet]
  public IEnumerable<string> GetCountries()
  {
    return DataLoad.Paises().Select(country => country.name).ToList();
  }
}

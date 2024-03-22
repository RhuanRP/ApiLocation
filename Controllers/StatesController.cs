using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class StatesController : ControllerBase
{
  [HttpGet]
  public IEnumerable<string> GetStates(string countryCode)
  {
    var states = DataLoad.Estados().Where(state => state.country_code == countryCode);
    return states.Select(state => state.name).ToList();
  }
}
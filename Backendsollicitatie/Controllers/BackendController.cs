using System;
using System.Collections.Generic;
using System.Web.Http;
using Backendsollicitatie.Facade;

namespace Backendsollicitatie.Controllers
{
  [Route("api/[controller]")]
  public class BackendController : ApiController
  {
    facade facade = new facade();
 
    [HttpGet]
    [Route("fizzbuzz/from={from:int}/to={to:int}")]
    public List<string> GetFizzBuzzElement(int from, int to)
    {
      return facade.fizzbuzzplan(from,to);
    }


    [HttpGet]
    [Route("formateer/sommatie")]
    public string sommatieFormation()
    {
      return facade.sommatieformatie();
    }

    [HttpGet]
    [Route("group/plain")]
    public Dictionary<int, int> groupPlain()
    {
      return facade.groupPlain();
    }
  }
}
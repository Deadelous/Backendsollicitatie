using System;
using System.Collections.Generic;
using System.Web.Http;
using Backendsollicitatie.Facade;

namespace Backendsollicitatie.Controllers
{
  [Route("api/[controller]")]
  public class FizzBuzzController : ApiController
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
    public string sommatieformatie()
    {
      return facade.sommatieformatie();
    }
  }
}
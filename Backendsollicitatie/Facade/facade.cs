using System;
using System.Collections.Generic;
using Backendsollicitatie.Models;
using Backendsollicitatie.Interfaces;

namespace Backendsollicitatie.Facade
{
  public class facade
  {
    IFizzBuzzcs fizz;
    ISommatie sommatie;
  

    public facade()
    {
      fizz = new Fizzbuzz();
      sommatie = new Sommatie();
    }

    public List<string> fizzbuzzplan(int from, int to)
    {
      return fizz.plainText(from, to);
    }

    public string sommatieformatie()
    {
      return sommatie.formatSommatie();
    }
  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Backendsollicitatie.Models;

namespace Backendsollicitatie.Facade
{
  public class facade
  {
    Fizzbuzz fizz;

    public facade()
    {
      fizz = new Fizzbuzz();
    }

    public List<string> fizzbuzzplan(int from, int to)
    {
      return fizz.plainText(from, to);
    }

  }
}
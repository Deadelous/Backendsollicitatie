﻿using System;
using System.Collections.Generic;
using Backendsollicitatie.Models;
using Backendsollicitatie.Interfaces;

namespace Backendsollicitatie.Facade
{
  public class facade
  {
    IFizzBuzzcs fizz;
    ISommatie sommatie;
    IGroup group;
  

    public facade()
    {
      fizz = new Fizzbuzz();
      sommatie = new Sommatie();
      group = new Groupplain();
    }

    public List<string> fizzbuzzplan(int from, int to)
    {
      return fizz.plainText(from, to);
    }

    public string sommatieformatie()
    {
      return sommatie.formatSommatie();
    }

    public Dictionary<int, int> groupPlain()
    {
      return group.GetElements();
    }
  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Backendsollicitatie.Interfaces;

namespace Backendsollicitatie.Models
{
  public class Groupplain : IGroup
  {
    public Dictionary<int, int> GetElements()
    {
      IEnumerable<int> elements = RandomNumbers();
      IEnumerable<int> result = elements.OrderBy(e => e);
      Dictionary<int, int> dictionary = new Dictionary<int, int>();

      List<int> list = new List<int>();
     
      foreach (var element in result)
      {
        if (dictionary.ContainsKey(element))
        {
          var count = dictionary[element]++;
          list.Add(dictionary[element]);
          
          string.Format("{0}: {1} keer", dictionary.Keys, dictionary.Values);
        }
        else
        {
          list.Add(dictionary[element] = 1);
        }
      }
      return dictionary;
     
    }

    public static IEnumerable<int> RandomNumbers(int seed = 123)
    {
      var random = new System.Random(seed);
      for (int i = 0; i < 1000; i++)
      {
        yield return random.Next(25);
      }
    }
  }
}
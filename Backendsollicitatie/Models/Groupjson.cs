using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Backendsollicitatie.Interfaces;
using Newtonsoft.Json;

namespace Backendsollicitatie.Models
{
  public class Groupjson : IJson
  {
    public string  GetElements()
    {
      IEnumerable<int> elements = RandomNumbers();
      IEnumerable<int> result = elements.OrderBy(e => e);
      Dictionary<int, int> dictionary = new Dictionary<int, int>();
      var element = elements.OrderBy(e => e).OrderByDescending(k => k);
      List<int> list = new List<int>();

      foreach (var e in element)
      {
        if (dictionary.ContainsKey(e))
        {
        
          var count = dictionary[e]++;
          list.Add(dictionary.Keys.Count);

          string.Format("{0}: {1} keer", dictionary.Keys, dictionary.Values);
        }
        else
        {
          list.Add(dictionary[e] = 1);
        }
      }
      string json = JsonConvert.SerializeObject(dictionary.OrderBy(o => o.Value), Formatting.Indented);
      return json;

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
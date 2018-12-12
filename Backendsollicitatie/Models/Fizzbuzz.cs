using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Backendsollicitatie.Interfaces;

namespace Backendsollicitatie.Models
{
  public class Fizzbuzz : IFizzBuzzcs
  {
    private int number = 0;
    public List<string> plainText(int from, int to)
    {
      int correct = to + 1;
      int[] getnumbers = new int[correct];
      string fizzbuzz = "Fizzbuzz";
      string fizz = "fizz";
      string buzz = "buzz";
      List<string> addnumber = new List<string>();
      try
      {
        for (int i = number + 1; i < getnumbers.Length; i++)
        {
          if ((i % 3) == number && (i % 5) == number)
          {
            addnumber.Add(fizzbuzz);
          }
          else if ((i % 3) == number)
          {
            addnumber.Add(fizz);
            
          }
          else if ((i % 5) == number)
          {
            addnumber.Add(buzz);
          }
          else
          {
            addnumber.Add(i.ToString());
            
          }
        }
      }
      catch(Exception ex)
      {
        Console.WriteLine(ex);
      }
      return addnumber;
    }

    
  }
}
using System;
using System.Globalization;
using Backendsollicitatie.Interfaces;

namespace Backendsollicitatie.Models
{
  public class Sommatie : ISommatie
  {
    static object[] inputvalues()
    {
      return new[]
          {
                "5",
                "1,2e2",
                null,
                "    -5555",
                "6.767",

            };
    }

    public string formatSommatie()
    {
      object[] values = inputvalues();

      decimal sum = 0;

      decimal response = 0;

      foreach (object item in values)
      {
        try
        {
          if (item == values[1])
          {
            sum += Math.Round(Decimal.Parse(item.ToString().Replace(",", "."), System.Globalization.NumberStyles.Any)) / 10;
          }
          else if (item != null)
          {
            sum += Math.Round(Decimal.Parse(item.ToString()));
          }
        }
        catch (FormatException ex)
        {
          Console.WriteLine(ex.ToString());
        }
      }
    
      NumberFormatInfo nfi = new NumberFormatInfo();
      nfi.NumberDecimalSeparator = ".";
      response = sum / 1000;
      string result = response.ToString("0.000", nfi);
      return result;
    }
  }
}
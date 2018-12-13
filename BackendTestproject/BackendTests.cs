using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backendsollicitatie.Interfaces;
using Backendsollicitatie.Models;
using Backendsollicitatie.Facade;
using System.Collections.Generic;

namespace BackendTestproject
{
  [TestClass]
  public class BackendTests
  {
    facade facade = new facade();
    [TestMethod]
    public void TestBuzz()
    {
      List<string> testfizzbuzz = facade.fizzbuzzplan(1, 30);
      Assert.AreEqual("Fizzbuzz", testfizzbuzz[29]);
      Assert.AreEqual(30, testfizzbuzz.Count);
    }
    [TestMethod]
     public void TestSommatie()
    {
      string sommatie = facade.sommatieformatie();
      Assert.AreEqual("1.337", sommatie);

    }
    [TestMethod]
    public void TestGroupPlain()
    {
      Dictionary<int, int> groupplain = facade.groupPlain();
      int elementvalue = 0;
      foreach (KeyValuePair<int, int> element in groupplain)
      {
        if (groupplain[element.Key] == 52)
        {
          elementvalue = element.Key;
        }
        Assert.AreEqual(0, elementvalue);
      }
    }

    [TestMethod]
    public void TestGroupJson()
    {
      Dictionary<int, int> groupplain = facade.groupPlain();
      int elementvalue = 29;
      foreach (KeyValuePair<int, int> element in groupplain)
      {
        if (groupplain[element.Key] == 22)
        {
          elementvalue = element.Key;
        }
        Assert.AreEqual(29, elementvalue);
      }
    }
  }
}

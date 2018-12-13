using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backendsollicitatie.Interfaces;
using Backendsollicitatie.Models;
using Backendsollicitatie.Facade;
using System.Collections.Generic;

namespace BackendTestproject
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestBuzz()
    {
      facade facade = new facade();
      List<string> testfizzbuzz = facade.fizzbuzzplan(1, 30);
      Assert.AreEqual("Fizzbuzz", testfizzbuzz[29]);
      Assert.AreEqual(30, testfizzbuzz.Count);
    }
  }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PrimeSifting.Models;
using System;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class NumberTests
  {

    // public void Dispose()
    // {
    //   Item.ClearAll();
    // }

    [TestMethod]
    public void PrimeCounter_RemovesNumbersMultipleOFPrimeVariable_Int()
    {
      List<int> primeList = new List<int> { 2, 3, 5, 7 };
      List<int> goal = Number.PrimeCounter(10);
      CollectionAssert.AreEqual(primeList, goal);
    }
  }
}
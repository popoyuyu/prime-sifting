using System;
using System.Collections.Generic;

namespace PrimeSifting.Models
{
  public class Number
  {
    public static List<int> PrimeCounter(int num)
    {
      List<int> newList = new List<int> { };
      for (int i = 2; i <= num; i++)
      {
        newList.Add(i);
      }
      for (int i = 2; i <= newList.Count; i++)
      {
        for (int j = i + 1; j < newList.Count; j++)
        {
          if (newList[i] % j == 0 && j < newList.Count)
          {
            newList.RemoveAt(j);
          }
        }
      }
      Console.WriteLine(newList.Count);
      return newList;
    }
  }
}
namespace ConnectFour.Extensions.Array
{
  using System;
  using System.Collections.Generic;

  public static class ArrayExtensions
  {
    public static IEnumerable<T> ToEnumerable<T>(this Array input)
    {
      foreach (T item in input)
      {
        yield return item;
      }
    }
  }
}
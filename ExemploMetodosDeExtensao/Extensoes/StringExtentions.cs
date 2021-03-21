using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
  public static class StringExtentions
  {
    public static string FirstToUpper(this string str)
    {
      string[] strs = str.Split(" ");
      string firstToUpper = string.Empty;

      for (int i = 0; i < strs.Length; i++)
      {
        var one = strs[i].Substring(0, 1);
        var two = strs[i].Substring(1);

        firstToUpper += one.ToUpper() + two + " ";
      }
      return firstToUpper;
    }
  }
}

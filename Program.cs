using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{  
  public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
  {
    List<int> list = new List<int>();
    for (int i = 0; i < listOfItems.Count; i++)
    {
      try
      {
        int result = (int)listOfItems[i];
        list.Add(result);
      } 
      catch(System.Exception e)
      {
        // does not fit
      }
    }
    return list;
  }
}
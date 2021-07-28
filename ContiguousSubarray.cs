using System.Collections.Generic;
using System.Linq;
public class ContiguousSubarrayClass
{
  public static int[] ContiguousSubarray(int[] arr, int X)
  {
    List<int> result = new List<int>();
    for (var i = 0; i < arr.Length; i++)
    {
      int sum = 0;
      for (var j = i; j < arr.Length; j++)
      {
        sum += arr[j];
        if (sum == X)
        {
          for (int k = i; k <= j; k++)
          {
            result.Add(arr[k]);
          }
          return result.ToArray();
        }
      }
    }
    return result.ToArray();
  }
  static void Main(string[] args)
  {
    int[] arr = { 14, 12, 70, 15, 99, 65, 21, 90 };
    int X = 97;
    var result = ContiguousSubarray(arr, X);
    foreach (var v in result)
    {
      System.Console.Write(v + " ");
    }
    System.Console.WriteLine();
  }
}
using System.Collections.Generic;
using System.Linq;
public class ArrayPermutation
{
  public static void PrintPermutation(int[] arr)
  {
    Permutate(arr, 0, arr.Length - 1);
  }
  public static void Permutate(int[] arr, int start, int end)
  {
    if (start == end)
    {
      PrintArray(arr);
      return;
    }
    for (var i = start; i <= end; i++)
    {
      SwapArray(arr, i, start);
      Permutate(arr, start + 1, end);
      SwapArray(arr, i, start);
    }
  }
  public static void PrintArray(int[] arr)
  {
    System.Console.Write('[');
    var first = false;
    foreach (int i in arr)
    {
      if (first)
      {
        System.Console.Write(", ");
      }
      else
      {
        first = true;
      }
      System.Console.Write(i);
    }
    System.Console.WriteLine(']');
  }
  public static void SwapArray(int[] arr, int l, int r)
  {
    int temp = arr[l];
    arr[l] = arr[r];
    arr[r] = temp;
  }
  static void Main(string[] args)
  {
    int[] a = { 10, 20, 30, 40 };
    PrintPermutation(a);
  }
}
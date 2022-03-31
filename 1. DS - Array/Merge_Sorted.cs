using System.Linq;
using System;

class MergeSortedArray
{
    static int[] array1 = { 1, 2, 3 };
    static int[] array2 = { 1, 2, 3 };
    static int[] array3 = { 0, 0, 0, 0, 0, 0 };

    static int[] MergeArrays(int[] arr1, int[] arr2)
    {
        return new int[] { 1, 2, 3, 4, 5, 6 };
    }

    public static void Main()
    {
        array3 = MergeArrays(array1, array2);
        Console.WriteLine(String.Join(",", array3.Select(x => x.ToString()).ToArray()));
        Console.ReadLine();
        Console.ReadLine();
    }
}

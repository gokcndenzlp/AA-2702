using System;

class Program
{
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i; // En iyi durum: Ω(1)
        }
        return -1; // En kötü durum: O(n)
    }

    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        int result = LinearSearch(arr, 30);
        Console.WriteLine(result); // 2 döner
    }
}


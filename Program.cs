using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Tablica wejsciowa:");
        PrintArray(numbers);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
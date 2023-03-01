using System;
using System.Diagnostics.CodeAnalysis;

namespace derss5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int sum = 0;
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            for (int i =0; i < arr.Length; i++)
            {
                


                    count++;
                    sum = sum + arr[i];
                
            }
            Console.WriteLine(sum / count);
        }
        
    }
}
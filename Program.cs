using System;

namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[2];
            Console.WriteLine("Enter array size");
            int N = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref arr, N);
            for (int i = 0; i != arr.Length; i++)
            {
                arr[i] = i;
                Console.Write(arr[i].ToString() + " ");
            }
            for (int i = 0; i != arr.Length / 2; i++)
            {
                int a = arr[i];
                int b = arr[i + arr.Length / 2];
                arr[i] = b;
                arr[i + arr.Length / 2] = a;
            }
            Console.WriteLine("\n Result: ");
            for (int i = 0; i != arr.Length; i++)
            {
                Console.Write(arr[i].ToString() + " ");
            }
        }
    }
}

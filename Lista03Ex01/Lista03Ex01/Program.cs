using System;

namespace Lista03Ex01
{
    internal class Program
    {
        public static void Main()
        {
            int [] A = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int[] B = { 12, 14, 15, 17, 19, 21, 23, 25, 27, 29 };
            Console.WriteLine($"Os valores em A são:");
            foreach (int valor in A)
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine();
            
            Console.WriteLine($"O valores em B são:");
            foreach (int valor in B)
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine();

            int[] C = new int[10];

            for (int i = 0; i < 10; i++)
            {
                C[i] = A[i] + B[9 - i];
            }
            Console.WriteLine($"Os valores em C são:");
            foreach (var valor in  C)
            {
                Console.Write(valor + " ");
            }
        }
    }
}
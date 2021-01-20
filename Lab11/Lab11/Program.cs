using System;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int a = 1; a <= n - i; a++)
                    Console.Write(" ");
                Console.Write("*");
                for (int a = 1; a < i; a++)
                    Console.Write(" *");
                Console.WriteLine();
            }
            for (int i = n-1; i > 0; i--)
            {
                for (int a = 1; a <= n - i; a++)
                    Console.Write(" ");
                Console.Write("*");
                for (int a = 1; a < i; a++)
                    Console.Write(" *");
                Console.WriteLine();
            }
        }
    }
}

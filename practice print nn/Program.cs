using System;

namespace practice_print_nn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入N:");

            int x;
            x = int.Parse(Console.ReadLine());

            for(int i = 1 ; i < x + 1; i++)
            {
                Console.WriteLine(x +  " * " + i  );
            }
        }
    }
}

using System;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the last number");
            int last = int.Parse(Console.ReadLine());
            for (int i = first; i <= last; ++i)
            {
                int flag = 1;
                for (int j = 2; j < i; ++j)
                {
                    if (i % j == 0)
                        flag = 0;
                    if (flag == 1)
                        Console.WriteLine(i);
                }


            }
        }
    }
}

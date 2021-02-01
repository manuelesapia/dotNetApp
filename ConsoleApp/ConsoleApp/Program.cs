using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {



            int a = 5;
            int b = 2;
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("the answer id greater");
            }
            else
            {
                Console.WriteLine("the answer is not greater");
            }



            int counter = 0;
            do
            {
                Console.WriteLine($"hello");
                counter++;
            }
            while (counter < 10);




            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {

                if (i % 3 == 0)
                {
                    sum = sum + i;
                }
                Console.WriteLine($"sum is {sum}");
            }



        }
    }
}

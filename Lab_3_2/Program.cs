using System;

namespace Lab_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ввести число N:");
                int N = int.Parse(Console.ReadLine());

                for (int a = 1; a <= N; a++ )
                {
                    for(int b = 1; b <= N; b++)
                    {
                        int c = (a + b) * (a - b);
                        Console.WriteLine($"c:={c}");
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

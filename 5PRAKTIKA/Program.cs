using System;

namespace _5PRAKTIKA
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int size = int.Parse(Console.ReadLine());
            int[] mas = new int[size];
            for(int i=0;i<mas.Length;i++)
            {
                mas[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < mas.Length; i+=2)
            {
                Console.WriteLine(mas[i]);
            }
            for (int i = 0; i < mas.Length; i += 2)
            {
                if (mas[i] > max)
                    max = mas[i];
            }
            Console.WriteLine(max);
        }
    }
}

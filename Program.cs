using System;

namespace homeWorkCycleLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countRepeat;

            Console.WriteLine("Введите количество циклов");
            countRepeat = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < countRepeat; i++) 
            {
                Console.WriteLine("message " + (i + 1));
            }
        }
    }
}

using System;

namespace ArraysAsParametersChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] happiness = new int[] { 12, 15, 18, 19, 1, 57, 65 };

            foreach (int happy in happiness)
            {
                Console.WriteLine($"The Happy meter starts at {happy}");
            }

            SunIsShining(happiness);

            foreach (int happy in happiness)
            {
                Console.WriteLine($"The Happy meter ends at {happy}");
            }
            
            Console.WriteLine("Hello World!");
        }

        private static void SunIsShining(int[] happyMeter)
        {
            int size = happyMeter.Length;

            for(int i = 0; i < size; i++)
            {
                happyMeter[i] += 2; // this line increases the passed arrays values - arrays are a reference type in C#
                // so when you pass the array to a function, the function can directly manipulate the array
                Console.WriteLine("The value of happiness was just increased by the Sun Is Shining");
            }


        }
    }
}

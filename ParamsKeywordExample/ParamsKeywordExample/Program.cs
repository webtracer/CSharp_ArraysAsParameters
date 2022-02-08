using System;

namespace ParamsKeywordExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Price is {0}, pi is {1}, at is {2}",32,3.14, '@');
            Console.WriteLine("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}={8}",1,2,3,4,5,6,7,8,1 + 2 + 3 + 4 + 5 + 6 + 7 + 8);

            ParamsMethod("This", "is", "a", "really", "long", "string", "to", "demonstrate", "the", "ParamsMethod", "I", "just","wrote","in","my","C#","Udemy","class");

            int price = 50;
            float pi = 3.14f;
            char at = '@';
            string book = "The Hobbit";
            ParamsMethod2(price, pi, at, book);
            ParamsMethod2("Hello", 5.3, '$');

            Console.WriteLine("The Minimum value of 25 and 50 is " + Math.Min(25,50)); //Math.Min() - Only takes 2 values 

            int min = MinV2(6, 4, 2, 8, 0, 1, 5, -27);
            Console.WriteLine($"The Minimum value that was passed out of 6, 4, 2, 8, 0, 1, 5, -27 is {min}");
        }

        public static void ParamsMethod(params string[] sentence)
        {
            for(int i = 0; i < sentence.Length; i++)
            {
               Console.Write(sentence[i]);
            }
            Console.WriteLine();
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            //for each loop to go through the array of objects
            foreach(object obj in stuff)
            {
                //print each object followed by a space
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;  //assigns the largest integer value possible to int min
            Console.WriteLine($"The max Min is {min}");

            foreach  (int number in numbers)
            {
                if(number < min)
                {
                    min = number;
                }
            }

            return min;
        }
    }
}

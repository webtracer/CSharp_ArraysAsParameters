using System;

namespace ArraysAsParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 20, 18, 2, 16 };
            double averageResult = GetAverage(studentsGrades);

            foreach(int grade in studentsGrades)
            {
                Console.WriteLine(grade);
            }
            Console.WriteLine($"The average grade is {averageResult}");
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for(int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }

            average = (double)sum / size;

            return average;

        }
    }
}

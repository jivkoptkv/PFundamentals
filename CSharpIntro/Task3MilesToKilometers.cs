using System;

namespace CSharpIntro
{
    public class Task3MilesToKilometers : IExercise
    {
        private const double RATIO_M2K = 1.60934;
        private double miles;
        private double kilometers;

        public void PrintResult()
        {
            Console.WriteLine(kilometers.ToString("0.00"));
        }

        public void ReadInput()
        {
            miles = double.Parse(Console.ReadLine());
        }

        public void Solve()
        {
            kilometers = miles * RATIO_M2K;
        }
    }
}

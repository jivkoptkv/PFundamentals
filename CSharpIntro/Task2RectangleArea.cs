using System;
using System.Text;

namespace CSharpIntro
{
    public class Task2RectangleArea : IExercise
    {
        private StringBuilder result = new StringBuilder();
        private float width;
        private float height;

        public void PrintResult()
        {
            Console.WriteLine(result.ToString());
        }

        public void ReadInput()
        {
            width = float.Parse(Console.ReadLine());
            height = float.Parse(Console.ReadLine());
        }

        public void Solve()
        {
            float Area = CalculateArea();
            result.Append(FormatFloat(Area));
        }

        private string FormatFloat(float area)
        {
            return String.Format("{0:0.00}", area);
        }

        private float CalculateArea()
        {
            return height * width;
        }
    }
}

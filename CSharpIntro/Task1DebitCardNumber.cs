using System;
using System.Linq;
using System.Text;

namespace CSharpIntro
{
    public class Task1DebitCardNumber : IExercise
    {
        private int[] input = new int[4];

        private StringBuilder sb = new StringBuilder();

        public void Solve()
        {
            foreach (var num in input)
            {
                var digits = SplitToDigits(num);

                int zerosToAddCount = 4 - digits.Length;

                appendZeros(zerosToAddCount);
                appendNum(num);
            }
        }

        public void PrintResult()
        {
            Console.WriteLine(sb.ToString());
        }

        public void ReadInput()
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }
        }

        private static int[] SplitToDigits(int number)
        {
            string numStr = String.Concat("", number);
            return numStr.Select((ch) => int.Parse(String.Concat("", ch))).ToArray();
        }

        private static void printArray(int[] arr)
        {
            Console.WriteLine(String.Join(" ", arr));
        }

        private void appendNum(int num)
        {
            sb.Append(num);
            sb.Append(" ");
        }

        private void appendZeros(int zerosToAddCount)
        {
            for (int i = 0; i < zerosToAddCount; i++)
                sb.Append("0");
        }
    }
}

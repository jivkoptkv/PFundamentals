using System;
using System.Text;

namespace CSharpIntro
{
    public class Task5CharacterStats : AbstractExercise
    {
        private const string FORMAT_NAME = "Name: {0}";
        private const string FORMAT_ENERGY = "Energy: {0}";
        private const string FORMAT_HEALTH = "Health: {0}";
        private string name;
        private Tuple<int, int> health;
        private Tuple<int, int> energy;

        public override void ReadInput()
        {
            name = Console.ReadLine();
            health = new Tuple<int, int>(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            energy = new Tuple<int, int>(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }

        public override void Solve()
        {
            result.AppendFormat(FORMAT_NAME, name);
            result.AppendLine();
            result.AppendFormat(FORMAT_HEALTH, GenerateBars(health));
            result.AppendLine();
            result.AppendFormat(FORMAT_ENERGY, GenerateBars(energy));
        }

        private string GenerateBars(Tuple<int, int> stats)
        {
            char BAR = '|';
            char DOT = '.';
            StringBuilder bars = new StringBuilder();
            bars.Append(BAR);

            bars.Append(BAR, stats.Item1);
            bars.Append(DOT, stats.Item2 - stats.Item1);

            bars.Append(BAR);

            return bars.ToString();
        }
    }
}

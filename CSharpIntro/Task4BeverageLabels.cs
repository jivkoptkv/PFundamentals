using System;

namespace CSharpIntro
{
    internal class Task4BeverageLabels : IExercise
    {
        private const string FORMAT_TITLE = "{0}ml {1}:";
        private const string FORMAT_CONTENTS = "{0}kcal, {1}g sugars";
        private string name;
        private int volume;
        private int energy_100Ml;
        private int sugar_100Ml;

        private double energy_InVolume;
        private double sugar_InVolume;

        public void PrintResult()
        {
            Console.WriteLine(FORMAT_TITLE, volume, name);
            Console.WriteLine(FORMAT_CONTENTS, energy_InVolume, sugar_InVolume);
        }

        public void ReadInput()
        {
            name = Console.ReadLine();
            volume = int.Parse(Console.ReadLine());
            energy_100Ml = int.Parse(Console.ReadLine());
            sugar_100Ml = int.Parse(Console.ReadLine());
        }

        public void Solve()
        {
            double volumeRatio;
            volumeRatio = ((double)volume) / ((double)100);
            energy_InVolume = (volumeRatio * energy_100Ml);
            sugar_InVolume = (volumeRatio * sugar_100Ml);
        }
    }
}

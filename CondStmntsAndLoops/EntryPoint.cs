using System;
using System.Text;

namespace PFundamentals.CondStmntsAndLoops
{
    public interface IExercise
    {
        void ReadInput();

        void Solve();

        void PrintResult();
    }

    public abstract class AbstractExercise : IExercise
    {
        protected readonly StringBuilder result = new StringBuilder();

        public abstract void ReadInput();

        public abstract void Solve();

        public void PrintResult()
        {
            Console.WriteLine(result.ToString());
        }
    }

    public class EntryPoint
    {
        public static void Main(String[] args)
        {
            //FindSolution<TaskClassGoesHere>();
        }

        private static void FindSolution<T>() where T : IExercise
        {
            Type targetType = typeof(T);

            IExercise exercise = Activator.CreateInstance(targetType) as IExercise;

            exercise.ReadInput();
            exercise.Solve();
            exercise.PrintResult();
        }
    }
}

using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestProject1")]

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, seed, capacity;

            Console.Write("Enter the number of items: ");
            n = int.Parse(Console.ReadLine());  

            Console.Write("Enter the seed: ");
            seed = int.Parse(Console.ReadLine());

            Console.Write("Enter the capacity: ");
            capacity = int.Parse(Console.ReadLine());

            Problem problem = new Problem(n, seed);
            Console.WriteLine("\nGenerated list: ");
            problem.ShowList();

            Result result = new Result(capacity);
            result = problem.Solve(capacity);
            Console.WriteLine();
            Console.WriteLine(result.ToString());

        }
    }
}
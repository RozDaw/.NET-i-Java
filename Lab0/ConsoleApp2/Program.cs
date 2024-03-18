namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the UpperBound: ");
            int upperBound = int.Parse(Console.ReadLine());
            FizzBuzz fz1 = new FizzBuzz(upperBound);
            fz1.Display();
        }
    }
}

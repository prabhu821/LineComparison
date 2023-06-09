namespace LineComparisonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem !");
            LineComparison lineComparison = new LineComparison(8, 6, 4, 2);
            lineComparison.CalculateLength();
        }
    }
}
namespace GradingSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            int score;
            string input =Console.ReadLine();


            if (int.TryParse(input, out score))
            {
                Grading.GradeCalculator(score);
            }
            else
            {
                Console.WriteLine("Error: Score Score should be in digit only(" + input + ")");
            }
        }
    }
}
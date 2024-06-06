namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();

           Console.WriteLine("Try to guess my favorite number");

            var userInput = int.Parse(Console.ReadLine());

            var favNumber = r.Next(1, 1000);

            if (userInput == favNumber)
            {
                Console.WriteLine($"You guessed it!!");
            }
            else if (userInput < favNumber)
            {
                Console.WriteLine($"Too low");
            }
            else
            {
                Console.WriteLine($"Too High");
            }
        }
    }
}

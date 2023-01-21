namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("My favorite number is between 1 and 1000.");

            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Try to guess my favorite number. Input your guess.");

            var userInput = int.Parse(Console.ReadLine());


            if(userInput > favNumber)
            {
                Console.WriteLine("Your guess is too high! Sorry!");
            }
            else if(userInput < favNumber)
            {
                Console.WriteLine("Your guess is too low! Sorry!");
            }
            else
            {
                Console.WriteLine("Your guess is correct!!");
            }
        }
    }
}

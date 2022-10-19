namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {


            var r = new Random();
            var favNumber = r.Next(1, 1001);

            do
            {
                Console.WriteLine("Pick a number from 1-1000.");
                var userInput = int.Parse(Console.ReadLine());



                if (userInput == favNumber)
                {
                    Console.WriteLine($"You guessed it correct at {userInput}, way to go!");
                }
                if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} is too high, try guessing a lower number.");
                }

                if (userInput < favNumber)

                {
                    Console.WriteLine($"{userInput} is too low, try guessing a higher number.");
                }

            }while (true);
        }
    }
}

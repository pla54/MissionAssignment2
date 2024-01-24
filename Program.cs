using MissionAssignment2;

internal class Program
{
    private static void Main(string[] args)
    {
        //Welcoming the user to the program and getting user input for the number of rolls
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");

        int numrolls = 0;
        numrolls = int.Parse(System.Console.ReadLine());

        //Creating an object of the diceroller and then rolling the dice with the user information
        RollDice diceRoller = new RollDice();

        int[] resultsArray = diceRoller.rolling(numrolls);

        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = " + numrolls);

        //Printing out the information as according to the ruberic and the percentage of each roll
        for(int i = 2; i < 13; i++)
        {
            int percentage = (int)Math.Round((resultsArray[i] * 100.0) / numrolls);

            Console.WriteLine(i + ": " + new string('*', percentage));
        }

        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}
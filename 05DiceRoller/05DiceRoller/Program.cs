using ConsoleLibrary;

namespace _05DiceRoller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Dice Roller App ~");

            string choice = "y";
            MyConsole.PromptReqString("Roll the dice? (y/n): ","y","n");
            while (choice=="y") {
                Random random = new Random();
                int die1 = random.Next(1,7);
                int die2 = random.Next(1,7);
                int total = die1+die2;
                MyConsole.PrintLine($"Die 1: {die1}");
                MyConsole.PrintLine($"Die 2: {die2}");
                MyConsole.PrintLine($"Total: {total}");
                if (total==2) {
                    MyConsole.PrintLine("Snake Eyes!");
                }
                else if (total==12) {
                    MyConsole.PrintLine("Box Cars!");
                }
                choice=MyConsole.PromptReqString("Roll again? (y/n): ","y","n");


            }
            // roll the dice? 
            // random # between 1-6
            // die 1
            // die 2
            // sum of die 1 and die 2
            // if total = 2 -> snake eyes
            // if total = 12 -> box cars
            // roll again?
            MyConsole.PrintLine("Goodbye!");
        }
    }
}

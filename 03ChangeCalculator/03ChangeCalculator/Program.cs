using ConsoleLibrary;

namespace _03ChangeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Change Calculator!");
            int cents = MyConsole.PromptInt("Enter # of cents (0-99): \n");
            int quarters = cents/25;
            int dimes = (cents%25)/10;
            int nickels = (cents%25%10)/5;
            int pennies = (cents%25%10%5);
            MyConsole.PrintLine($"Quarters: {quarters}\nDimes: {dimes} \nNickels: {nickels} \nPennies: {pennies} \n");




        }
    }
}

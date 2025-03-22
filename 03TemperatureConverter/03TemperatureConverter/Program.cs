using ConsoleLibrary;

namespace _03TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Temperature Converter!");
            string choice = "y";
            while (choice.ToLower()=="y") {
                double degF = MyConsole.PromptDouble("\nEnter degrees in Fahrenheit: ");
                double degC = (degF-32)*5/9;
                MyConsole.PrintLine($"Degrees in Celsius: {degC:F2}");
                choice = MyConsole.PromptReqString("\nContinue? (y/n): ","y","n");
            }
            MyConsole.PrintLine("Goodbye!");
        }
    }
}

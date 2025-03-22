using ConsoleLibrary;

namespace _03TravelTimeCalculator {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the Travel Time Calculator!~\n");
            string choice = "y";
            while (choice=="y") {
                double miles = MyConsole.PromptDouble("Enter miles: ");
                double mph = MyConsole.PromptDouble("Enter miles per hour: ");
                // Calculate time in hours
                // hours = miles /mph
                double totalHours = (miles/mph);
                int hours = (int)totalHours;
                double remainder = totalHours%1;
                int minutes = (int)(remainder*60);
                MyConsole.PrintLine("\nEstimated travel time");
                MyConsole.PrintLine("---------------------");
                MyConsole.PrintLine($"Hours: {hours}");
                MyConsole.PrintLine($"Minutes: {minutes}");
                choice = MyConsole.PromptReqString("Continue? (y/n): ","y","n");
            }
        }
    }
}

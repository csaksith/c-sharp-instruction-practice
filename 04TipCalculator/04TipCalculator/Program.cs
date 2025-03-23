using ConsoleLibrary;

namespace _04TipCalculator {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the Tip Calculator!~\n");
            decimal cost = MyConsole.PromptDecimal("Cost of meal: ");
            string choice = "y";

            while (choice.ToLower()=="y") {
                for (decimal tipPct = .15m; tipPct<=.25m; tipPct+=.05m) {
                    decimal tipAmt = cost*tipPct;
                    decimal totalAmt = cost+tipAmt;
                    MyConsole.PrintLine($"\n{tipPct:P0}");
                    MyConsole.PrintLine($"Tip amount: {tipAmt:C2}");
                    MyConsole.PrintLine($"Total amount: {totalAmt:C2}\n");
                }
                choice=MyConsole.PromptReqString("Continue? (y/n): ","y","n");
            }
            MyConsole.PrintLine("\nBye!~");
        }
    }
}

using ConsoleLibrary;

namespace _03InterestCalculator {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the Interest Calculator!~\n");
            string choice = "y";
            while (choice.ToLower()=="y") {
                decimal loanAmt = MyConsole.PromptDecimal("Enter loan amount: ");
                decimal interestRate = MyConsole.PromptDecimal("Enter interest rate: ");
                MyConsole.PrintLine($"\nLoan amount: {loanAmt:C}");
                MyConsole.PrintLine($"Interest rate: {interestRate:P3}");
                decimal interest = loanAmt*interestRate;
                MyConsole.PrintLine($"Interest: {interest:C}");
                choice=MyConsole.PromptReqString("\nContinue? (y/n): ","y","n").ToLower();
            }
            MyConsole.PrintLine("Bye~");
        }
    }
}

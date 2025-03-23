using ConsoleLibrary;

namespace _04FactorialCalculator {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the Factorial Calculator!~");
            string choice = "y";
            while (choice=="y") {
                int factorial = 1;
                int integer = MyConsole.PromptInt("\nEnter an integer that's greater than 0 and less than 10: ");
                for (int i = 1; i<=integer; i++) {
                    factorial*=i;
                }
                MyConsole.PrintLine($"The factorial of {integer} is {factorial}.\n");
                choice=MyConsole.PromptReqString("Continue? (y/n): ","y","n");
            }
            MyConsole.PrintLine("\nBye!~");
        }
    }
}

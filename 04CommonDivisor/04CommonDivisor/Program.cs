using ConsoleLibrary;

namespace _04CommonDivisor {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the Greatest Common Divisor!~");
            string choice = "y";
            while (choice.ToLower()=="y") {
                int x = MyConsole.PromptInt("\nEnter first number: ");
                int y = MyConsole.PromptInt("Enter second number: ");
                while (x!=0) {
                    while (y>=x) {
                        y-=x;
                    }
                    int tempY = y;
                    y=x; // swap x and y
                    x=tempY; // set x to the previous value of y
                }
                MyConsole.PrintLine($"Greatest common divisor: {y}");
                choice=MyConsole.PromptReqString("\nContinue? (y/n): ","y","n");
            }
            MyConsole.PrintLine("\nGoodbye!~");
        }
    }
}

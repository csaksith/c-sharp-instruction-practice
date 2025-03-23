using ConsoleLibrary;

namespace _04TableOfPowers {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the Squares and Cubes table!~");
            string choice = "y";
            while (choice=="y".ToLower()) {
                    int integer = MyConsole.PromptInt("Enter an integer: ");
                    MyConsole.PrintLine("Number\tSquared\tCubed");
                    MyConsole.PrintLine("======\t=======\t=====");
                for (int i = 1; i<integer+1; i++) {
                    int number = i;
                    int squared = number*number;
                    int cubed = number*number*number;
                    MyConsole.PrintLine($"{number}\t{squared}\t{cubed}");
                }
                choice=MyConsole.PromptReqString("Continue? (y/n): ","y","n");
            }
            MyConsole.PrintLine("Bye!~");
        }
    }
}

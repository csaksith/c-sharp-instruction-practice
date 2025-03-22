using ConsoleLibrary;

namespace _02GradeConverter {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the Letter Grade Converter~");

            string choice = "y";
            string letterGrade = "F";
            while (choice=="y") {
                int numGrade = MyConsole.PromptInt("\nEnter numerical grade: ");

                if (numGrade>88&&numGrade<100) {
                    letterGrade="A";
                    MyConsole.PrintLine($"Letter Grade: {letterGrade}");
                }
                else if (numGrade>=80&&numGrade<=87) {
                    letterGrade="B";
                    MyConsole.PrintLine($"Letter Grade: {letterGrade}");
                }
                else if (numGrade>=68&&numGrade<=79) {
                    letterGrade="C";
                    MyConsole.PrintLine($"Letter Grade: {letterGrade}");
                }
                else if (numGrade>=60&&numGrade<=67) {
                    letterGrade="D";
                    MyConsole.PrintLine($"Letter Grade: {letterGrade}");
                }
                else {
                    letterGrade="F";
                    MyConsole.PrintLine($"Letter Grade: {letterGrade}");
                }
                choice=MyConsole.PromptReqString("\nContinue? (y/n): ","y","n");
            }
            MyConsole.PrintLine("\nGoodbye!");
        }
    }
}

using ConsoleLibrary;

namespace _02RectangleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Area and Perimeter Calculator!~\n");
            string choice = "y";
            while (choice =="y") {
                double length = MyConsole.PromptDouble("Enter length: ");
                double width = MyConsole.PromptDouble("Enter width: ");
                double area = length*width;
                double perimeter = (length*2)+(width*2);
                MyConsole.PrintLine($"Area: {area.ToString("F1")}");
                MyConsole.PrintLine($"Perimeter: {perimeter.ToString("F1")}");
                choice=MyConsole.PromptReqString("\nContinue? (y/n): ","y","n");
            }
            MyConsole.PrintLine("\nBye!~");
        }
    }
}

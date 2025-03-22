using ConsoleLibrary;

namespace _02StudentRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Student Registration Form\n");
            string firstName = MyConsole.PromptString("Enter first name: ");
            string lastName = MyConsole.PromptString("Enter last name: ");
            int year = MyConsole.PromptInt("Enter year of birth: ");

            MyConsole.PrintLine();
            MyConsole.PrintLine($"Welcome {firstName} {lastName}!");
            MyConsole.PrintLine("Your registration is complete.");
            MyConsole.PrintLine($"Your temporary password is: {firstName}*{year}");

            MyConsole.PrintLine("\nGoodbye!");
        }
    }
}

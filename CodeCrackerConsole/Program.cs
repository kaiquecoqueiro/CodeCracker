namespace CodeCrackerConsole
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Human!");
            Console.WriteLine("Press E to encrypt or any key to decrypt a message.");
            var userAction = Console.ReadKey().Key;
            Console.WriteLine("");

            Console.WriteLine($"Type the message that you wish to {(userAction.Equals(ConsoleKey.E) ? "encrypt" : "decrypt")}.");
            var message = Console.ReadLine();

            var codeCracker = new CodeCrackerFactory().DecideDecrypterAction(userAction, message).CrackMessage();

            Console.WriteLine($"Your {(userAction.Equals(ConsoleKey.E) ? "encrypt" : "decrypt")} message is: {codeCracker}");

            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}

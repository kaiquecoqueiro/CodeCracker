namespace CodeCrackerConsole
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Human!");
            Console.WriteLine("Press E to encrypt or D to decrypt a message.");
            var userAction = Console.ReadKey().Key;

            Console.WriteLine($"Type the message that you wish to {(userAction.Equals("E") ? "encrypt" : "decrypt")}.");
            var message = Console.ReadLine();

            var codeCracker = new CodeCrackerFactory().DecideDecrypterAction(userAction, message).CrackMessage();

            Console.WriteLine(codeCracker);

            Console.ReadKey();
        }
    }
}

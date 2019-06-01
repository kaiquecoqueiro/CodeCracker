namespace CodeCrackerConsole
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Human!");
            Console.WriteLine("Press E to encrypt or D to decrypt a message.");

            var userAction = Console.ReadKey();

            var message = Console.ReadLine();
            var codeCracker = new Decrypter(message);

            Console.WriteLine(codeCracker.Message);

            Console.ReadKey();
        }
    }
}

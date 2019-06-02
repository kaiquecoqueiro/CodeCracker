namespace CodeCrackerConsole
{
    using System;

    public class CodeCrackerFactory
    {
        public Cracker DecideDecrypterAction(ConsoleKey userAction, string message)
        {
            if (userAction.Equals(ConsoleKey.E))
                return new Encrypter(message);
            else
                return new Decrypter(message);
        }
    }
}

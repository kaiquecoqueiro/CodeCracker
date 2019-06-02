namespace CodeCrackerConsole
{
    public class CodeCrackerFactory
    {
        public Cracker DecideDecrypterAction(System.ConsoleKey userAction, string message)
        {
            if (userAction.Equals("E"))
            {
                return new Decrypter(message);
            }
            else
            {
                return new Encrypter(message);
            }
        }
    }
}

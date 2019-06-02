namespace CodeCrackerConsole
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            var userInterface = new UserInterfaceMessage();

            Console.WriteLine(userInterface.GreetingMessage);
            var userAction = Console.ReadKey().Key;
            
            while (!userAction.Equals(ConsoleKey.F12))
            {
                Console.WriteLine(userInterface.UserActionMessage);
                userAction = Console.ReadKey().Key;

                Console.WriteLine(userInterface.EncryptionQuestionMessage, userInterface.WriteEncryptOrDecryptByKeyPress(userAction));
                var message = Console.ReadLine();

                var codeCracker = new CodeCrackerFactory().DecideDecrypterAction(userAction, message).CrackMessage();

                Console.WriteLine(userInterface.ResultMessage, userInterface.WriteEncryptOrDecryptByKeyPress(userAction), codeCracker);
                Console.WriteLine(userInterface.ContinueInTheSystemMessage);
                userAction = Console.ReadKey().Key; 
            }
        }
    }
}

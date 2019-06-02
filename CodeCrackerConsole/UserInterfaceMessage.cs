namespace CodeCrackerConsole
{
    using System;

    public class UserInterfaceMessage
    {
        public string GreetingMessage => "Hello, Human! Press any key to continue.";
        public string UserActionMessage => "Press E to encrypt, F12 to exit or any other key to decrypt a message.";
        public string ContinueInTheSystemMessage => "Do you wish to continue? (Press F12 to exit)";
        public string EncryptionQuestionMessage => "Type the message that you wish to {0}.";
        public string ResultMessage = "Your {0} message is: {1}";
        
        public string WriteEncryptOrDecryptByKeyPress(ConsoleKey userAction)
        {
            return (userAction.Equals(ConsoleKey.E) ? "encrypt" : "decrypt");
        }
    }
}

namespace CodeCrackerConsole
{
    using CodeCrackerConsole.Glossary;

    public class Decrypter
    {
        public string Message;
        
        public Decrypter(string message)
        {
            this.Message = DecryptMessage(message);
        }

        private string DecryptMessage(string message)
        {
            var glossary = new AlphabetDecryption().GetKeyValuePairs();

            var arrayOfMessages = message.ToLower().ToCharArray();

            string decodedMessage = string.Empty;

            for (int i = 0; i < arrayOfMessages.Length; i++)
            {
                string decodeString = string.Empty;
                glossary.TryGetValue(arrayOfMessages[i].ToString(), out decodeString);

                decodedMessage += decodeString;
            }

            return decodedMessage;
        }
    }
}

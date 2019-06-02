﻿namespace CodeCrackerConsole
{
    using CodeCrackerConsole.Glossary;

    public class Decrypter : Cracker
    {
        public string Message;
        
        public Decrypter(string message)
        {
            Message = message;
        }
        
        public override string CrackMessage()
        {
            var glossary = new AlphabetDecryption().GetKeyValuePairs();

            var arrayOfMessages = Message.ToLower().ToCharArray();

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

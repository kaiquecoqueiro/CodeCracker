namespace CodeCrackerConsole
{
    using CodeCrackerConsole.Alphabet;
    using System.Linq;

    public class Decrypter : Cracker
    {
        private AlphabetDecryption AlphabetDecryption;
        public string Message;
        
        public Decrypter(string message)
        {
            Message = message;
        }

        private AlphabetDecryption GetAlphabetDecryption()
        {
            if (AlphabetDecryption != null)
                return AlphabetDecryption;
            else
                return AlphabetDecryption = new AlphabetDecryption();
        }

        public override string CrackMessage()
        {
            var glossary = GetAlphabetDecryption().Alphabet;

            var arrayOfMessages = Message.ToLower().ToCharArray();

            string decodedMessage = string.Empty;

            for (int i = 0; i < arrayOfMessages.Length; i++)
                decodedMessage += glossary.FirstOrDefault(x => x.Value == arrayOfMessages[i].ToString()).Key;

            return decodedMessage;
        }
    }
}

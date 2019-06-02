namespace CodeCrackerConsole
{
    using CodeCrackerConsole.Alphabet;
    using System.Linq;

    public class Encrypter : Cracker
    {
        private string Message;

        public Encrypter(string message)
        {
            Message = message;
        }

        public override string CrackMessage()
        {
            var glossary = new AlphabetDecryption().GetAlphabet();

            var arrayOfMessages = Message.ToLower().ToCharArray();

            string decodedMessage = string.Empty;

            for (int i = 0; i < arrayOfMessages.Length; i++)
                decodedMessage += glossary.FirstOrDefault(x => x.Value == arrayOfMessages[i].ToString()).Key;

            return decodedMessage;
        }
    }
}

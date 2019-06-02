namespace CodeCrackerConsole.Alphabet
{
    using System.Collections.Generic;

    public class AlphabetDecryption
    {
        public Dictionary<string, string> Alphabet { get; internal set; }

        public AlphabetDecryption()
        {
            Alphabet = GetAlphabet();
        }
        
        private Dictionary<string, string> GetAlphabet()
        {
            if (Alphabet != null)
            {
                return Alphabet;
            }
            else
                return LoadKeyValuePairs();
        }
        
        private Dictionary<string, string> LoadKeyValuePairs()
        {
            var alphabet = new Dictionary<string, string>();
            alphabet.Add("a", "!");
            alphabet.Add("b", ")");
            alphabet.Add("c", @"""");
            alphabet.Add("d", "(");
            alphabet.Add("e", "£");
            alphabet.Add("f", "*");
            alphabet.Add("g", "%");
            alphabet.Add("h", "&");
            alphabet.Add("i", ">");
            alphabet.Add("j", "<");
            alphabet.Add("k", "@");
            alphabet.Add("l", "a");
            alphabet.Add("m", "b");
            alphabet.Add("n", "c");
            alphabet.Add("o", "d");
            alphabet.Add("p", "e");
            alphabet.Add("q", "f");
            alphabet.Add("r", "g");
            alphabet.Add("s", "h");
            alphabet.Add("t", "i");
            alphabet.Add("u", "j");
            alphabet.Add("v", "k");
            alphabet.Add("w", "l");
            alphabet.Add("x", "m");
            alphabet.Add("y", "n");
            alphabet.Add("z", "o");

            alphabet.Add(" ", "-");

            return alphabet;
        }
    }
}

namespace CodeCrackerConsole.Glossary
{
    using System.Collections.Generic;

    public class AlphabetDecryption
    {
        public AlphabetDecryption()
        {
            LoadKeyValuePairs();
        }

        private Dictionary<string, string> Glossary { get; set; }

        public Dictionary<string, string> GetKeyValuePairs()
        {
            return Glossary;
        }

        public void LoadKeyValuePairs()
        {
            Glossary = new Dictionary<string, string>();
            Glossary.Add("a", "!");
            Glossary.Add("b", ")");
            Glossary.Add("c", @"""");
            Glossary.Add("d", "(");
            Glossary.Add("e", "£");
            Glossary.Add("f", "*");
            Glossary.Add("g", "%");
            Glossary.Add("h", "&");
            Glossary.Add("i", ">");
            Glossary.Add("j", "<");
            Glossary.Add("k", "@");
            Glossary.Add("l", "a");
            Glossary.Add("m", "b");
            Glossary.Add("n", "c");
            Glossary.Add("o", "d");
            Glossary.Add("p", "e");
            Glossary.Add("q", "f");
            Glossary.Add("r", "g");
            Glossary.Add("s", "h");
            Glossary.Add("t", "i");
            Glossary.Add("u", "j");
            Glossary.Add("v", "k");
            Glossary.Add("w", "l");
            Glossary.Add("x", "m");
            Glossary.Add("y", "n");
            Glossary.Add("z", "o");
        }
    }
}

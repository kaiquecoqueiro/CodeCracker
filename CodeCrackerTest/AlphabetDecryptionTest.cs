namespace CodeCrackerTest
{
    using CodeCrackerConsole.Glossary;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AlphabetDecryptionTest
    {
        [TestMethod]
        public void Should_Return_Alphabet()
        {
            var glossary = new AlphabetDecryption().GetKeyValuePairs();

            Assert.IsNotNull(glossary.Values);
        }
    }
}

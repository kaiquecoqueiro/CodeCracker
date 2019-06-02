namespace CodeCrackerTest
{
    using CodeCrackerConsole.Alphabet;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AlphabetDecryptionTest
    {
        [TestMethod]
        public void Should_Return_Full_Alphabet()
        {
            var alphabet = new AlphabetDecryption().Alphabet;

            Assert.IsNotNull(alphabet.Values);
        }
    }
}

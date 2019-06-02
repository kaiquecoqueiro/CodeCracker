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
            var alphabet = new AlphabetDecryption().GetAlphabet();

            Assert.IsNotNull(alphabet.Values);
        }

        [TestMethod]
        public void Should_Return_Same_Instance_Of_The_Alphabet()
        {
            var oldAlphabet = new AlphabetDecryption().GetAlphabet();
            
            Assert.IsNotNull(oldAlphabet.Values);
        }
    }
}

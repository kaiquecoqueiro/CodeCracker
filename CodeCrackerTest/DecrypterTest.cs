namespace CodeCrackerTest
{
    using CodeCrackerConsole;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DecrypterTest
    {
        [TestMethod]
        [DataRow("Hello", "&£aad")]
        [DataRow("World", "ldga(")]
        [DataRow("Hello World", "&£aad-ldga(")]
        public void Should_Crack_Message(string decryptMessage, string encryptMessage)
        {
            var decriptionAction = new Decrypter(decryptMessage);
            var decriptedMessage = decriptionAction.CrackMessage();
            Assert.AreEqual(encryptMessage, decriptedMessage);
        }
    }
}

namespace CodeCrackerTest
{
    using CodeCrackerConsole;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EncrypterTest
    {
        [TestMethod]
        [DataRow("&£aad", "hello")]
        [DataRow("ldga(", "world")]
        [DataRow("&£aad-ldga(", "hello world")]
        public void Should_Crack_Message(string encryptMessage, string decryptMessage)
        {
            var encryptionAction = new Encrypter(decryptMessage);
            var encryptedMessage = encryptionAction.CrackMessage();
            Assert.AreEqual(encryptMessage, encryptedMessage);
        }
    }
}

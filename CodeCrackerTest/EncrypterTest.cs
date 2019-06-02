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
        [DataRow("&£aadldga(", "helloworld")]
        public void Should_Crack_Message(string decryptMessage, string encryptMessage)
        {
            var decriptionAction = new Encrypter(decryptMessage);
            var decriptedMessage = decriptionAction.CrackMessage();
            Assert.AreEqual(encryptMessage, decriptedMessage);
        }
    }
}

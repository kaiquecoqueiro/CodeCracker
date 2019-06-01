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
        [DataRow("Hello World", "&£aadldga(")]
        public void Should_Crack_Message(string decryptMessage, string encryptMessage)
        {
            var decriptionAction = new Decrypter(decryptMessage);

            Assert.AreEqual(encryptMessage, decriptionAction.Message);
        }
    }
}

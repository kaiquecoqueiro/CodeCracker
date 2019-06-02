namespace CodeCrackerTest
{
    using CodeCrackerConsole;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class CodeCrackerFactoryTest
    {
        [TestMethod]
        public void Should_Return_Encrypter_Class()
        {
            var codeCrackerFactoryAction = new CodeCrackerFactory().DecideDecrypterAction(ConsoleKey.E, "Hello");

            Assert.IsInstanceOfType(codeCrackerFactoryAction, typeof(Encrypter));
            Assert.IsNotInstanceOfType(codeCrackerFactoryAction, typeof(Decrypter));
        }

        [TestMethod]
        public void Should_Return_Decrypter_Class()
        {
            var codeCrackerFactoryAction = new CodeCrackerFactory().DecideDecrypterAction(ConsoleKey.D, "Hello");

            Assert.IsInstanceOfType(codeCrackerFactoryAction, typeof(Decrypter));
            Assert.IsNotInstanceOfType(codeCrackerFactoryAction, typeof(Encrypter));
        }
    }
}

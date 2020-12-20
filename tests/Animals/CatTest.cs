using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DotnetStrategy
{
    [TestClass]
    public class CatTest
    {   
        //We need a mock, because we are testing Doc Class, we already have a test for BarkBehaviour
        private Moq.Mock<ISpeakBehaviour> behaviour = new Mock<ISpeakBehaviour>();
        //Now we need to add Moq to our proyect....!!
        Cat cat = new Cat();
        [TestMethod]
        public void TestCat()
        {
            Assert.IsInstanceOfType(cat, typeof(Cat));
        }

        [TestMethod]
        public void TestSetSpeakBehaviour()
        {
            cat.Behaviour = behaviour.Object;
            Assert.IsInstanceOfType(cat.Behaviour, typeof(ISpeakBehaviour));
        }

        [TestMethod]
        public void TestStartSpeak()
        {
            behaviour.Setup(p => p.Speak()).Returns("Meow!");
            cat.Behaviour = behaviour.Object;
            Assert.AreEqual("Meow!", cat.Behaviour.Speak());
        }

        [TestMethod]
        public void TestDisplay()
        {
            Assert.AreEqual("I am a cat", cat.Display()); //we need a way to identify all animals...
        }
    }
}

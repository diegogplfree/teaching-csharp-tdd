using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DotnetStrategy
{
    [TestClass]
    public class DogTest
    {   
        //We need a mock, because we are testing Doc Class, we already have a test for BarkBehaviour
        private Moq.Mock<ISpeakBehaviour> behaviour = new Mock<ISpeakBehaviour>();
        //Now we need to add Moq to our proyect....!!
        Dog dog = new Dog();
        [TestMethod]
        public void TestDog()
        {
            Assert.IsInstanceOfType(dog, typeof(Dog));
        }

        [TestMethod]
        public void TestSetSpeakBehaviour()
        {
            dog.Behaviour = behaviour.Object;
            Assert.IsInstanceOfType(dog.Behaviour, typeof(ISpeakBehaviour));
        }

        [TestMethod]
        public void TestStartSpeak()
        {
            behaviour.Setup(p => p.Speak()).Returns("Woff!");
            dog.Behaviour = behaviour.Object;
            Assert.AreEqual("Woff!", dog.Behaviour.Speak());
        }

        [TestMethod]
        public void TestDisplay()
        {
            Assert.AreEqual("I am a dog", dog.Display()); //we need a way to identify all animals...
        }
    }
}

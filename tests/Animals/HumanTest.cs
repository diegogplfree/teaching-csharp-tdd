using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DotnetStrategy
{
    [TestClass]
    public class HumanTest
    {   
        //We need a mock, because we are testing Doc Class, we already have a test for BarkBehaviour
        private Moq.Mock<ISpeakBehaviour> behaviour = new Mock<ISpeakBehaviour>();
        //Now we need to add Moq to our proyect....!!
        Human human = new Human();
        [TestMethod]
        public void TestHuman()
        {
            Assert.IsInstanceOfType(human, typeof(Human));
        }

        [TestMethod]
        public void TestSetSpeakBehaviour()
        {
            human.Behaviour = behaviour.Object;
            Assert.IsInstanceOfType(human.Behaviour, typeof(ISpeakBehaviour));
        }

        [TestMethod]
        public void TestStartSpeak()
        {
            behaviour.Setup(p => p.Speak()).Returns("Hi!");
            human.Behaviour = behaviour.Object;
            Assert.AreEqual("Hi!", human.Behaviour.Speak());
        }

        [TestMethod]
        public void TestDisplay()
        {
            Assert.AreEqual("I am a human", human.Display()); //we need a way to identify all animals...
        }
    }
}

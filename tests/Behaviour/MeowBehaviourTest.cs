using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotnetStrategy
{
    [TestClass]
    public class MeowBehaviourTest
    {   
        MeowBehaviour behaviour = new MeowBehaviour();
        [TestMethod]
        public void TestMeowBehaviour()
        {
            Assert.IsInstanceOfType(behaviour, typeof(MeowBehaviour));
        }

        [TestMethod]
        public void TestSpeak()
        {
            Assert.AreEqual("Meow!", behaviour.Speak());
        }
    }
}

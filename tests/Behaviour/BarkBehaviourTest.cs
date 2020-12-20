using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotnetStrategy
{
    [TestClass]
    public class BarkBehaviourTest
    {   
        BarkBehaviour behaviour = new BarkBehaviour();
        [TestMethod]
        public void TestBarkBehaviour()
        {
            Assert.IsInstanceOfType(behaviour, typeof(BarkBehaviour));
        }

        [TestMethod]
        public void TestSpeak()
        {
            Assert.AreEqual("Woff!", behaviour.Speak());
        }
    }
}

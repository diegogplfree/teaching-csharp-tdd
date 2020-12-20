using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotnetStrategy
{
    [TestClass]
    public class TalkBehaviourTest
    {   
        TalkBehaviour behaviour = new TalkBehaviour();
        [TestMethod]
        public void TestTalkBehaviour()
        {
            Assert.IsInstanceOfType(behaviour, typeof(TalkBehaviour));
        }

        [TestMethod]
        public void TestSpeak()
        {
            Assert.AreEqual("Hi!", behaviour.Speak());
        }
    }
}

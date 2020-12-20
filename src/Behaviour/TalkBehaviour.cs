using System;

namespace DotnetStrategy
{
    public class TalkBehaviour : ISpeakBehaviour
    {
        public string Speak()
        {
            return "Hi!";
        }
    }
}
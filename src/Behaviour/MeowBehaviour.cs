using System;

namespace DotnetStrategy
{
    public class MeowBehaviour : ISpeakBehaviour
    {
        public string Speak()
        {
            return "Meow!";
        }
    }
}
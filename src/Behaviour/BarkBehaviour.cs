using System;

namespace DotnetStrategy
{
    public class BarkBehaviour : ISpeakBehaviour
    {
        public string Speak()
        {
            return "Woff!";
        }
    }
}
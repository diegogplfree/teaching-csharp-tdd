using System;

namespace DotnetStrategy
{
    internal abstract class Animal
    {
        public ISpeakBehaviour Behaviour 
        { 
            get => behaviour; 
            set => behaviour = value; 
        }

        private ISpeakBehaviour behaviour;

        public abstract string Display();
    }
}
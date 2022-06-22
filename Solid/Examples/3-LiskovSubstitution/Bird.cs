using System;
namespace Solid.Examples.LiskovSubstitution
{
    public class Bird : IFlyer, IWalker
    {
        public bool Fly()
        {
            return true;
        }

        public bool Walk()
        {
            return true;
        }
    }
}

using System;
namespace Solid.Examples.LiskovSubstitution
{
    public class Chicken : IFlyer
    {
        public bool Fly()
        {
            return true;
        }
    }
}

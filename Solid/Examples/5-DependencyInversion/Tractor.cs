using System;
namespace Solid.Examples.DependencyInversion
{
    public class Tractor : IProduction
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Produce()
        {
            return true;
        }
    }
}

using System;
namespace Solid.Examples.DependencyInversion
{
    public class ProductManager
    {
        private IProduction iProduction;

        public ProductManager(IProduction IProduction)
        {
            iProduction = IProduction;
        }

        public void Produce()
        {
            iProduction.Produce();
        }
    }
}

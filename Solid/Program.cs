using System;
using Solid.Examples.DependencyInversion;

namespace Solid
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Motorcycle mlet = new Motorcycle();
            mlet.Id = 1;
            mlet.Name = "Honda";

            var pMan = new ProductManager(mlet);
            pMan.Produce();


            Tractor tractor = new Tractor();
            mlet.Id = 1;
            mlet.Name = "Man";

            var pTractor = new ProductManager(tractor);
            pTractor.Produce();

        }
    }
}

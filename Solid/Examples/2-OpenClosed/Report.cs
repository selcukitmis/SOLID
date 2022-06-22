using System;
using Solid.Examples.SingleResponsibility;

namespace Solid.Examples.OpenClosed
{
    abstract class Report
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
        public abstract void CreateReport(Employee em);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    /// <summary>
    ///  Car extends the vechile class
    /// </summary>
    internal class Car : Vehicle
    {
        /***** constructors section *****/
        // by default, a class has a default constructor that does not take any parameters
        // therfore, you do not have to explicitly create one

        /***** methods sectionns****/
        /// <summary>
        /// Overides the base Vehicles definition for GetInfo()
        /// </summary>
        public override void GetInfo()
        {
            Console.WriteLine($"I'm a {nameof(Car)}");
            Console.WriteLine("I don't want to disclose my information.");
        }




    }
}

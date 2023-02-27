using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    internal class Truck : Vehicle
    {

        private double _sizeOfTruckBed;
        /**** fields section ****/
        /// <summary>
        /// Constructor that takes 4 parametersL truckbrand, truckModel, truckNumberofWheels, and sizeofTruckBed
        /// it reuses the base class (Vehicle)'s constructor that takes 3 parameters: brand,model,numberOfWheels
        /// </summary>
        /// <param name="truckBrand"></param>
        /// <param name="truckModel"></param>
        /// <param name="truckNumberOfWheels"></param>
        /// <param name="sizeOfTruckBed"></param>
        public Truck(string truckBrand, string truckModel, int truckNumberOfWheels, double sizeOfTruckBed) : base(truckBrand, truckModel, truckNumberOfWheels)
        {
            SizeOfTruckBed = sizeOfTruckBed;
        }


        /***** properties sectionn *****/
        public double SizeOfTruckBed
        {
            get { return _sizeOfTruckBed; }
            set { _sizeOfTruckBed = value; }

        }

        public override void GetInfo()
        {
            Console.WriteLine($"I'm a {nameof(Truck)}");
            base.GetInfo();
            Console.WriteLine($"I also have a {SizeOfTruckBed} ft truck bed ");
        }
    }
}

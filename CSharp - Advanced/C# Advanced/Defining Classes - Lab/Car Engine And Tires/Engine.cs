using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Engine
    {
        public int horsePower;
        public double cubicCapacity;

        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }

        public int HorsePower { get { return horsePower; } set { horsePower = value; } }

        public double CubicCapacity { get { return cubicCapacity; } set { cubicCapacity = value; } }
    }
}

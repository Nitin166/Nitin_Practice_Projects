using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car
    {
        public string BrandName { get; set; }
        public string car{ get; set; }
        public string Color { get; set; }
        public int Wheels { get; set; }

        public int Speed(int speed)
        {
            return speed;
        }
        public int Break(int power)
        {
            return power * 4;

        }
        public int Clutch(int power)
        {
            return power;
        }



    }
}

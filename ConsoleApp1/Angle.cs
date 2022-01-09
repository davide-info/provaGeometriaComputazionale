using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static  class Angle
    {
        public static double ToDegrees(double radians)
        {
            return (radians * 180) / Math.PI;
        }
        public static double ToRadians(double angle)
        {
            return (angle * Math.PI)/180;
        }

    }
}

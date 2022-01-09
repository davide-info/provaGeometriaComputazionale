using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Coordinate : IComparable<Coordinate>,ICloneable 
    {
        public const double NULL_ORDINATE = Double.NaN;
        private double x, y, z;

        public double X {  get { return x; } set { x = value; } }
        public double Y {  get { return y; } set { y = value; } }
        public double Z { get { return z; } set { z = value; } }
      

        public Coordinate():this(0.0,0.0,0.0) { }

        public Coordinate(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Coordinate(double x, double y):this(x,y, NULL_ORDINATE) { }
        public Coordinate(Coordinate cord) :this(cord.x, cord.y, cord.z) { }

        public object Clone()
        {
            Coordinate coord = new Coordinate(this);
            return coord;
        }

        public int CompareTo(Coordinate other)
        {
            var result = x.CompareTo(other.x);
            if(result ==0)
            {
                return y.CompareTo(other.y);
            }
            
            return result;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Coordinate;
            if (Object.ReferenceEquals(other, null)) return false;
            return other.x == x && other.y == y;
        }
        public override int GetHashCode()
        {
            int result = 17;
            result = 37 * result + HashCode(x);
            result = 37 * result + HashCode(y);

            return result;
        }
        public double Distance(Coordinate coord)
        {
            double dx = x - coord.x;
            double dy = y - coord.y;
            return Math.Sqrt(dx*dx + dy*dy);
            
        }
        public double Distance3D(Coordinate coord)
        {
            double dx = x - coord.x;
            double dy = y - coord.y;
            double dz = z - coord.z;
            return Math.Sqrt(dx*dx+dy*dy*dz*dz);

        }
        

        public static int  HashCode(double x)
        {
            long f = BitConverter.DoubleToInt64Bits(x);
            return (int)(f ^ (f>>32));
        }
    }
}

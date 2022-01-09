using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Geometric3DVector
    {
        private double x, y, z;
        public double X { set { x = value; }  get { return x; } }
        public double Y { set { y = value; } get { return y; } }
        public double Z { set { z = value; } get { return z; } }

        public Geometric3DVector() : this(0.0, 0.0) { }

        public double SquaredLength { get { return X * X + Y * Y + Z * Z; }  }
        public double Length { get { return Math.Sqrt(SquaredLength); } }


        public Geometric3DVector(double  x,  double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Geometric3DVector(double x, double y):this(x,y,0.0)
        {
            
        }

        public Geometric3DVector(double x) : this(x,0.0)
        {

        }

        public static Geometric3DVector operator- (Geometric3DVector v1, Geometric3DVector v2)
        {
            return GetDifferenceVector(v1, v2);
        }

        public static Geometric3DVector operator+(Geometric3DVector v1, Geometric3DVector v2)
        {
            return SumVector(v1, v2);
        }

        public static Geometric3DVector SumVector(Geometric3DVector v1, Geometric3DVector v2)
        {
    
          

            return new Geometric3DVector(v2.x + v1.x, v2.y + v1.y, v2.z + v1.z);
            
            
         
        }
      static   public double GetEuclideanDistance(Geometric3DVector v1)
        {
            return GetEuclideanDistance(v1,new Geometric3DVector());
        }
        
        static public double GetDotProduct(Geometric3DVector v1, Geometric3DVector v2) {



           
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z; 
        }
     static    public Geometric3DVector GetCrossProduct(Geometric3DVector v, Geometric3DVector u)
        {
         

            double resX = u.y * v.z-v.y*u.z;
            double resY = u.z * v.x-v.z*u.x;
            double resZ=u.x*v.y-v.x*u.y;


            return new Geometric3DVector(resX, resY, resZ);
        }

        static public double GetEuclideanDistance(Geometric3DVector v1, Geometric3DVector v2)
        {
            Geometric3DVector diff = v1 - v2;
            //Console.WriteLine("Vettore differenza " + diff);
            double dotProduct = GetDotProduct(diff,diff);
           // Console.WriteLine("dotProduct " + dotProduct);
            return Math.Sqrt(dotProduct);
        }

        static public  Geometric3DVector GetDifferenceVector(Geometric3DVector v1, Geometric3DVector v2)
        {
           // Console.WriteLine("Differenza Vettori  v1 {0} e v2 {1} ", v1.ToString(), v2.ToString());
            return  new Geometric3DVector(v1.x-v2.x, v1.y-v2.y,v1.z-v2.z);
           
        }

       
        public Geometric3DVector MultiplyVectorByScalar( double fatt)
        {

            return new Geometric3DVector(x*fatt, y*fatt);
        }
        public Geometric3DVector UnitVector()
        {
            double length = GetEuclideanDistance(this);
            if(length!=0.0)
            {
                return new Geometric3DVector(x/length, y/length);
            }
            throw new Exception("Impossibile divide by 0");
        }

        public override string ToString()
        {
            return "( " + x + " , " + y + " , " + z  + " )";
        }
        public override bool Equals(object obj)
        {
            Geometric3DVector gv = obj as Geometric3DVector;
            if(object.ReferenceEquals(gv, null)) return false;
            return x == gv.x && y == gv.y && z==gv.z;
        }
        public override int GetHashCode()
        {
            return x.GetHashCode() ^ y.GetHashCode()^z.GetHashCode();
        }
       static  public double AngleBetween(Geometric3DVector a, Geometric3DVector b)
        {
            var res = GetDotProduct(a, b) / (GetEuclideanDistance(a) * GetEuclideanDistance(b));
         //   Math.Atan2()
            Console.WriteLine("Risultato " + res);

          //  var radians = Angle.ToRadians(res);
            

            return Math.Acos(res);
        }

    }
}

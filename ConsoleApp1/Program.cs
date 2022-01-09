using System;

namespace ConsoleApp1
{
    class Program
    {

        private static void TestVector()
        {
            Geometric3DVector gv = new Geometric3DVector(3, 4);
            Geometric3DVector v1 = new Geometric3DVector(2, 1);
            Console.WriteLine("Distanza origine vettore " + Geometric3DVector.GetEuclideanDistance(gv));
            Console.WriteLine("Prodotto vettoriale vettore gv {0} e vettore v1 {1} è uguale al vettore {2}", gv.ToString(), v1.ToString(), Geometric3DVector.GetCrossProduct(gv,v1));

            Console.WriteLine("Angolo tra il vettore gv {0} e vettore v1 {1} è uguale al vettore {2}", gv.ToString(), v1.ToString(), Geometric3DVector.AngleBetween(gv, v1));

            Console.WriteLine("Distanza dal vettore gv  {0} al vettore v1 {1}  è uguale a {2} ", gv.ToString(), v1.ToString(), Geometric3DVector.GetEuclideanDistance(gv, v1));
        }
        static void Main(string[] args)
        {
            TestVector();
        }
    }
}

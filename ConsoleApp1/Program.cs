using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть дві коодинати для двох векторів:");
            
            TVector2D vectors_2 = new TVector2D();            

            double vector_AB = 0;
            vector_AB = vectors_2.VectorLength1(vector_AB);

            
            double vector_CD = 0;
            vector_CD = vectors_2.VectorLength2(vector_CD);
            

            Console.WriteLine(vectors_2);
           
            Console.WriteLine("{0}", vectors_2.ComparisonOfVectors(vector_AB, vector_CD));

            Console.WriteLine("Введіть три коодинати для двох векторів:");

            TVector3D vectors_3 = new TVector3D();            

            vector_AB = 0;
            vector_AB = vectors_3.VectorLength1(vector_AB);

            vector_CD = 0;
            vector_CD = vectors_3.VectorLength2(vector_CD);
            

            Console.WriteLine(vectors_3);

            Console.WriteLine("{0}", vectors_3.ComparisonOfVectors(vector_AB, vector_CD));


            Console.ReadKey();

        }

    }

}

   
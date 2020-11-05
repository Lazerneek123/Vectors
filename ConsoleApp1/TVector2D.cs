using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TVector2D
    {
        public int[] vector_1_Cordinate = new int[2];
        public int[] vector_2_Cordinate = new int[2];
        public double vector_1_Length;
        public double vector_2_Length;
        public int[] vector_sum_Cordinate = new int[2];


        public TVector2D()
        {           
            vector_1_Cordinate[0] = Int32.Parse(Console.ReadLine());
            vector_1_Cordinate[1] = Int32.Parse(Console.ReadLine());
            vector_2_Cordinate[0] = Int32.Parse(Console.ReadLine());
            vector_2_Cordinate[1] = Int32.Parse(Console.ReadLine());
        }


        public TVector2D(int[] vector_1_Cordinate, int[] vector_2_Cordinate)
        {
            this.vector_1_Cordinate = vector_1_Cordinate;
            this.vector_2_Cordinate = vector_2_Cordinate;
        }

        public TVector2D(TVector2D vectors)
        {
            vector_1_Cordinate = vectors.vector_1_Cordinate;
            vector_2_Cordinate = vectors.vector_2_Cordinate;
        }

        public int Length
        {
            get
            {
                return vector_1_Cordinate.Length;
            }
        }       


        public double VectorLength1(double vector_AB)
        {
            int x = vector_1_Cordinate[0];
            int y = vector_1_Cordinate[1];


            vector_AB = x * x + y * y;

            vector_AB = Math.Sqrt(vector_AB);
            vector_1_Length = vector_AB;

            return vector_AB;
        }

        public double VectorLength2(double vector_CD)
        {
            int x = vector_2_Cordinate[0];
            int y = vector_2_Cordinate[1];


            vector_CD = x * x + y * y;

            vector_CD = Math.Sqrt(vector_CD);
            vector_2_Length = vector_CD;

            return vector_CD;
        }


        public string ComparisonOfVectors(double vector_AB, double vector_CD)
        {  
            string comparison = null;

            if (vector_AB == vector_CD)
            {
                comparison = "Вектори рівні!";
            }

            if (vector_AB > vector_CD)
            {
                comparison = "Вектор AB більший за вектор СD!";
            }
            if (vector_AB < vector_CD)
            {
                comparison = "Вектор AB менший за вектор СD!";
            }


            return comparison;
        }


        public static TVector2D operator +(TVector2D a, TVector2D b)
        {
            TVector2D c = new TVector2D();            
            c.vector_sum_Cordinate[0] = a.vector_1_Cordinate[0] + b.vector_2_Cordinate[0];
            c.vector_sum_Cordinate[1] = a.vector_1_Cordinate[1] + b.vector_2_Cordinate[1];

            return c;
        }

        public static TVector2D operator -(TVector2D a, TVector2D b)
        {
            TVector2D c = new TVector2D();
            c.vector_sum_Cordinate[0] = a.vector_1_Cordinate[0] - b.vector_2_Cordinate[0];
            c.vector_sum_Cordinate[1] = a.vector_1_Cordinate[1] - b.vector_2_Cordinate[1];

            return c;
        }


        public static TVector2D operator *(TVector2D a, int y)
        {
            TVector2D c = new TVector2D();
            c.vector_sum_Cordinate[0] = a.vector_1_Cordinate[0] * a.vector_2_Cordinate[0] + a.vector_1_Cordinate[1] * a.vector_2_Cordinate[1];
            
            return c;
        }


        public override string ToString()
        {           
            return "Довжина вектора AB = " + vector_1_Length + "; CD = " + vector_2_Length + " - з двома координатами x, y!";
        }


    }
}

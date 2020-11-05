using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TVector3D : TVector2D
    {
        public int[] vector_3_Cordinate = new int[2];
        public new int[] vector_sum_Cordinate = new int[3];

        public TVector3D()
        {            
            vector_3_Cordinate[0] = Int32.Parse(Console.ReadLine());
            vector_3_Cordinate[1] = Int32.Parse(Console.ReadLine());
        }


        public TVector3D(int[] vector_1_Cordinate, int[] vector_2_Cordinate, int[] vector_3_Cordinate) : base(vector_1_Cordinate, vector_1_Cordinate)
        {
            this.vector_3_Cordinate = vector_3_Cordinate;
           
        }

        public TVector3D(TVector3D vectors)
        {
            vector_3_Cordinate = vectors.vector_3_Cordinate;
            
        }


        public new double VectorLength1(double vector_AB)
        {
            int x = vector_1_Cordinate[0];
            int y = vector_1_Cordinate[1];
            int z = vector_3_Cordinate[0];


            vector_AB = x * x + y * y + z *z;            

            vector_AB = Math.Sqrt(vector_AB);
            vector_1_Length = vector_AB;

            return vector_AB;
        }

        public new double VectorLength2(double vector_CD)
        {
            int x = vector_2_Cordinate[0];
            int y = vector_2_Cordinate[1];
            int z = vector_3_Cordinate[1];

            vector_CD = x * x + y * y + z * z;

            vector_CD = Math.Sqrt(vector_CD);
            vector_2_Length = vector_CD;

            return vector_CD;
        }

        public static TVector3D operator +(TVector3D a)
        {
            TVector3D c = new TVector3D();
            c.vector_sum_Cordinate[0] = a.vector_1_Cordinate[0] + a.vector_2_Cordinate[0];
            c.vector_sum_Cordinate[1] = a.vector_1_Cordinate[1] + a.vector_2_Cordinate[1];
            c.vector_sum_Cordinate[0] = a.vector_3_Cordinate[0] + a.vector_3_Cordinate[1];

            return c;
        }

        public static TVector3D operator -(TVector3D a)
        {
            TVector3D c = new TVector3D();
            c.vector_sum_Cordinate[0] = a.vector_1_Cordinate[0] - a.vector_2_Cordinate[0];
            c.vector_sum_Cordinate[1] = a.vector_1_Cordinate[1] - a.vector_2_Cordinate[1];
            c.vector_sum_Cordinate[0] = a.vector_3_Cordinate[0] - a.vector_3_Cordinate[1];

            return c;
        }


        public static TVector3D operator *(TVector3D a, int y)
        {
            TVector3D c = new TVector3D();
            c.vector_1_Cordinate[0] = a.vector_1_Cordinate[0] * a.vector_2_Cordinate[0] + a.vector_1_Cordinate[1] * a.vector_2_Cordinate[1] + a.vector_3_Cordinate[0] * a.vector_3_Cordinate[1];

            return c;
        }



        public override string ToString()
        {
            return "Довжина вектора AB = " + vector_1_Length + "; CD = " + vector_2_Length + " - з трьома координатами x, y, z!";
        }


    }
}

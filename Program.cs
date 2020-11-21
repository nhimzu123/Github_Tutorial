using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevenShteinDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Nhap chuoi 1: ");
            //string chuoi1 = Console.ReadLine();

            //Console.Write("Nhap chuoi 2: ");
            //string chuoi2 = Console.ReadLine();

            //Console.WriteLine("\nKhoang cach giua 2 van ban la: " + leven(chuoi1, chuoi2));
            Console.Write("Nhap muc xam!");
            Console.Write("Nhap muc xam dau: ");
            int a = int.Parse(Console.ReadLine());
            int b = 0;
            do
            {
                Console.Write("Nhap muc xam cuoi: ");
                b = int.Parse(Console.ReadLine());
            } while (b <= a);

            int n = b - a + 1; // Tong so mau!




            Console.ReadLine();


        }

        private static float[] Histo (int[,] x, int[,] q, int n)
        {
            float[] b = new float[n];
            return b;

        }

        private static int leven(string str1, string str2)
        {
            int src1Length = str1.Length;
            int src2Length = str2.Length;

            if (src1Length == 0)
            {
                return src2Length;
            }
            if (src2Length == 0)
            {
                return src1Length;
            }

            int[,] matrix = new int[src1Length + 1, src2Length + 1];

            for (int i = 0; i < src1Length+1; i++)
            {
                matrix[i, 0] = i;
            }
            for (int j = 0; j < src2Length+1; j++)
            {
                matrix[0, j] = j;
            }

            for (int i = 1; i < src1Length+1; i++)
            {
                for (int j = 1; j < src2Length + 1; j++)
                {
                    int cost = (str1[i - 1] == str2[j - 1]) ? 0 : 1;
                    matrix[i, j] = Math.Min(Math.Min(matrix[i - 1, j] + 1, matrix[i, j - 1] + 1),
                            matrix[i - 1, j - 1] + cost);
                }
            }
            return matrix[src1Length, src2Length];
        }

        private static int LevenShteinDistance(string source1, string source2)
        {
            int source1Length = source1.Length;
            int source2Length = source2.Length;

            if (source1 ==  String.Empty) 
            {
                return source2Length;
            }
  
            if(source2 == String.Empty)
            {
                return source1Length;
            }

            int[,] matrix = new int[source1Length + 1, source2Length + 1];

            for (int i = 0; i < source1Length + 1; i++)
                matrix[i, 0] = i;
            for (int j = 0; j < source2Length + 1; j++)
                matrix[0, j] = j;

            for (int i = 1; i < source1Length + 1; i++)
            {
                for (int j = 1; j < source2Length + 1; j++)
                {
                    int cost = (source2[j - 1] == source1[i - 1]) ? 0 : 1;
                    matrix[i, j] = Math.Min(
                        Math.Min(matrix[i - 1, j] + 1, matrix[i, j - 1] + 1),
                        matrix[i - 1, j - 1] + cost);
                }
            }
            return matrix[source1Length, source2Length];


        }
    }
}

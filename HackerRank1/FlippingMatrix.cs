using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank1
{
    internal class FlippingMatrix
    {
        public static int flippingMatrix(List<List<int>> matrix)
        {
            matrix = new List<List<int>>
        {
            new List<int> { 1, 2, 3, 4 },
            new List<int> { 4, 5, 6, 7 },
            new List<int> { 7, 8, 9, 10 },
            new List<int> { 11, 12, 13, 14 }
        };

            int n = matrix.Count / 2;

            int[,] arr = new int[matrix.Count, matrix.Count];

            for (int i = 0; i < matrix.Count; i++)
            {
                List<int> eachRow = matrix[i];

                for (int j = 0; j < eachRow.Count; j++)
                {
                    arr[i, j] = eachRow[j];
                }
            }

            int final = 0;

            for (int a = 0; a < matrix.Count; a++)
            {
                // Reverse

                int[,] newarr = new int[matrix.Count, matrix.Count];


                // Calculate Sum
                int tempfinal = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        tempfinal = tempfinal + arr[i, j];
                    }
                }

                if (tempfinal > final)
                {
                    final = tempfinal;
                }
            }

            return final;

        }
    }
}

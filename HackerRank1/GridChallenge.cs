using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank1
{
    internal class GridChallenge
    {
        public static string gridChallenge(List<string> grid)
        {
            List<char[]> chars = new List<char[]>();

            foreach (var item in grid)
            {
                char[] arr = item.ToCharArray();

                Array.Sort(arr);

                chars.Add(arr);
            }

            int curr = -1;
            int prev = -1;

            for (int i = 0; i < chars.Count; i++)
            {
                curr = Convert.ToInt32(chars[i][0]);

                if (curr < prev)
                {
                    return "NO";
                }

                prev = curr;
            }

            return "YES";

        }
    }
}

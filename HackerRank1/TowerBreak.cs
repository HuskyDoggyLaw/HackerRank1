using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank1
{
    internal class TowerBreak
    {
        public static int towerBreakers(int n, int m)
        {
            List<List<int>> towers = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                List<int> eachTower = new List<int>();

                for (int j = 0; j < m; j++)
                {
                    eachTower.Add(1);
                }

                towers.Add(eachTower);
            }

            while (0 < 1)
            {
                int currentPlayer = 1;
                int players = 2;

                while (0 < 1)
                {
                    if (RunForEachPlayer(towers) == true)
                    {
                        return currentPlayer;
                    }

                    currentPlayer++;

                    if (currentPlayer > players)
                    {
                        currentPlayer = 1;
                    }
                }
            }

            return -1;
        }

        private static bool RunForEachPlayer(List<List<int>> towers)
        {
            int optTower = -1;
            int optFloors = -1;

            for (int i = 0; i < towers.Count; i++)
            {
                int remainingFloors = towers[i].Count;

                if (remainingFloors > 1)
                {
                    for (int j = 1; j < remainingFloors; j++)
                    {
                        int rem = remainingFloors - j;

                        if (remainingFloors % rem == 0)
                        {
                            optFloors = j;
                            optTower = i;

                            goto EndLoops;
                        }
                    }
                }
            }

        EndLoops:

            towers[optTower].RemoveRange(0, optFloors);

            if (CheckIfAllTowersHasOnlyOneFloor(towers) == true)
            {
                return true;
            }

            return false;
        }

        private static bool CheckIfAllTowersHasOnlyOneFloor(List<List<int>> towers)
        {
            int count = 0;

            for (int i = 0; i < towers.Count; i++)
            {
                if (towers[i].Count == 1)
                {
                    count++;
                }
            }

            if (count == towers.Count)
                return true;

            return false;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionAssignment2
{
    internal class RollDice
    {
        public int[] rolling(int numberOfRolls)
        {
            int[] results = new int[13];
            Random r = new Random();

            for (int i = 0; i < numberOfRolls; i++)
            {
                int dice1 = r.Next(1, 7);
                int dice2 = r.Next(1, 7);
                int sum = dice1 + dice2;

                results[sum]++;
            }

            return results;
        }
    }
}

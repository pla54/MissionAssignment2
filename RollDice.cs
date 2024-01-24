using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionAssignment2
{
 //Creating class to roll the dice that returns the array of dice rolls in each respective position
    internal class RollDice
    {
        public int[] rolling(int numberOfRolls)
        {
            int[] results = new int[13];
            Random r = new Random();

            //Rolling the two random dies according to how many rolls to do. This is done with the Random library
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class Build_Tower
    {
        public static string[] TowerBuilder(int nFloors)
        {
            string[] output = new string[nFloors];

            for (int i = 0; i < nFloors; i++)
            {
                output[i] = BuildFloor(nFloors, i);
            }
            return output;
        }


        public static string BuildFloor(int floors, int floor)
        {
            floors = floors + 1;
            floor = floor + 1;
            int bricksLastFloor = 1 + 2 * (floors - 1);
            int bricksCurrentFloor = 1 + 2 * (floor - 1);
            int diffrence = bricksLastFloor - bricksCurrentFloor;

            string clearSpace = "";
            for (int i = 0; i < ((diffrence / 2) - 1); i++)
            {
                clearSpace += " ";
            }
            string bricks = "";
            for (int i = 0; i < bricksCurrentFloor; i++)
            {
                bricks += "*";
            }

            return clearSpace + bricks + clearSpace;
        }

    }
}

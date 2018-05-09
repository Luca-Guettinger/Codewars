using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class MainClass
    {
        static void Main(string[] args)
        {
            string[] tower = Build_Tower.TowerBuilder(20);
            foreach (string s in tower)
            {
                Console.WriteLine(s);


            }
            Console.ReadLine();
        }
    }
}

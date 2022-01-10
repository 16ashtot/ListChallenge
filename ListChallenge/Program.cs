using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // add all names again
            List<string> names = new List<string> { "Ethan", "WillD", "Ashton", "Ben", "Tom", "Henry", "Cormac", "WillR", "Adam"};

            List<int> score = new List<int> { 155, 391, 358, 212, 243, 344, 374, 508, 348};

            Console.WriteLine(names[3]);
        }
    }
}

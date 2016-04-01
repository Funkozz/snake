using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            point p1 = new point();
            for (int i = 1; i <= 10; i++)
            {
                p1.x = i; p1.y = 2; p1.sym = '#'; p1.draw();
            }
            Console.ReadLine();
                    
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST1
{
    class Class4
    {
        public int x;
        public int y;
        public Class4(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Point
    {
        static void Main()
        {
            Class4 c1 = new Class4(2, 3);
            Class4 c2 = new Class4(1, 4);
            Console.WriteLine(c1.x + "," + c1.y);
            Console.WriteLine(c2.x + "," + c2.y);
        }
    }
}

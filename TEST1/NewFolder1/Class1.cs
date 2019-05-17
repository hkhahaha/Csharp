using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST1.NewFolder1
{
    class Class100
    {
        const double PI = 3.14;
        public void area(int r)
        {
            if (r >= 0)
            {
                Console.WriteLine(PI*r*r);
            }
            else
            {
                Console.WriteLine("radius is smaller than zero");
            }
        }
    }
    class ClassMain
    {
        static void Main()
        {
            Class100 c1 = new Class100();
            for (int i = -2; i <= 10; i++)
            {
                c1.area(i);
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST1.NewFolder1
{
    class Class4
    {
        static string Main()
        {
            int x;
            x = int.Parse(Console.ReadLine());
            int y=0;
            if (x > 0)
            {
                y = 1;
            }
            else if (x == 0)
            {
                y = 0;
            }
            else if (x < 0)
            {
                y = -1;
            }
            Console.WriteLine(y);
            return Main();
        }
    }
}

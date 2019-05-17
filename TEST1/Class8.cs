using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST1
{
    class Class8
    {
        static void Main()
        {
            int i = 123;
            object obj1 = i;
            object obj2 = (object)i;
            i = 456;
            int j = (int)obj1;
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
        }
    }
}

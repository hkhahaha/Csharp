using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST1
{
    class Class7
    {
        public int value;
    }
    class Class7two
    {
        static void Main()
        {
            int v1 = 0;
            int v2;
            v2 = 123;
            Class7 r1 = new Class7();
            Class7 r2 = r1;
            r2.value = 123;
            Console.WriteLine(v1 + ","+v2);
            Console.WriteLine(r1.value + "," + r2.value);
        }
    }
}

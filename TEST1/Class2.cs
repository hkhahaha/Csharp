using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST1
{
    class Class2
    {
        static void Main()
        {
            Stack s = new Stack();
            s.push(1);
            s.push(10);
            s.push(100);
            Console.WriteLine("-------------------------");
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.ReadLine();
        }
    }
}

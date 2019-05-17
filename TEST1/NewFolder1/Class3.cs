using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST1.NewFolder1
{
    class Triangle
    {
        public void Perimeter()
        {
            string s;
            s=Console.ReadLine();
            double a = double.Parse(s);
            s=Console.ReadLine();
            double b = double.Parse(s);
            s=Console.ReadLine();
            double c = double.Parse(s);
            double area = a + b + c;
            Console.WriteLine(area);
        }
    }
    class Class3
    {
        static void Main()
        {
            Triangle t1 = new Triangle();
            t1.Perimeter();
            Console.ReadLine();
        }
    }
}

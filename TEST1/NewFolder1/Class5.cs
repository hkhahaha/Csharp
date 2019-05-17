using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST1.NewFolder1
{
    class Class5
    {
        static void Main()
        {
            Random a = new Random();
            int[] mark = new int[100];
            int avg = 0;
            int sum=0;
            for(int i = 0; i < 100; i++)
            {
                mark[i] = a.Next(101);
                Console.WriteLine(mark[i]);
                sum = sum + mark[i];
            }
            avg = sum / 100;
            Console.WriteLine(avg+"123");
            Console.WriteLine(sum+"123");

        }
    }
}

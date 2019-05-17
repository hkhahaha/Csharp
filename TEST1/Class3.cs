using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST1
{
    class SampleClass
    {
        public void SampleMethod()
        {
            Console.WriteLine("TEST.SampleClass.SampleMethod");
        }
    }
    namespace InnerNameSpace
    {
        class SampleClass
        {
            public void SampleMethod()
            {
                Console.WriteLine("TEST.InnerNameSpace.SampleClass.SampleMethod");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            SampleClass outer = new SampleClass();
            outer.SampleMethod();
            TEST1.SampleClass outer2 = new TEST1.SampleClass();
            outer2.SampleMethod();
            InnerNameSpace.SampleClass inner = new InnerNameSpace.SampleClass();
            inner.SampleMethod();
            TEST1.InnerNameSpace.SampleClass inner2 = new TEST1.InnerNameSpace.SampleClass();
            inner2.SampleMethod();
        }
    }
}

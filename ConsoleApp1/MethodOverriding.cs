using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public   class MethodOverriding
    {
         public virtual void test1()
        {
            Console.WriteLine("i am virtural test method 1");
        }
    }
    public class childoverridemethod: MethodOverriding
    {
        public override void test1()
        {
            Console.WriteLine(" i am override test method 1");
        }
    }
}

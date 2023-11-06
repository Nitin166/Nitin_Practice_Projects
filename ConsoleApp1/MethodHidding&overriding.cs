using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class A
    {
        public void a()
        {
            Console.WriteLine("this is test one ");
        }
        public void b()
        {
            Console.WriteLine("this is test method 2");
        }
    }
    public class B:A
    {
        public new void b()
        {
            Console.WriteLine("this is hidding mehtod");
        }
    }
}

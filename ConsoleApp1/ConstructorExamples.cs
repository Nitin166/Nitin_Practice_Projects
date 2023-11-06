using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ConstructorExamples
    {
        public int var1;
        public int var2;
        public int var3;
        public static int var4;
        public ConstructorExamples()
        {
            var1= 200;
            var2= 300;
        }
        public ConstructorExamples(int a)
        {
            var2 = a;
        }
        static ConstructorExamples()
        {
            var4 =300000;
        }
    }
  
}

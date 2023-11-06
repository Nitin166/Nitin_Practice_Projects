using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class AbstractClass
    {

        public AbstractClass()
        {
            Console.WriteLine("this is Abstract class Constructor");
        }
        public void test1(int a)
        {
            Console.WriteLine("this is my first test" +   a);
        }
        public abstract void test2(int b);


        public abstract int test3(int i, int j);
    }
    public class childabstract  : AbstractClass
    {
        public override void test2(int b)
        {
            Console.WriteLine(b);
        }
        public override int test3(int i, int j)
        {
            return i+j;
        }
    }
}

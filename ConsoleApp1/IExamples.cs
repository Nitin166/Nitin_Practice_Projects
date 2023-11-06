using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IExamples
    {
        public int sum(int a, int b);
        public void test1();
        public void test2();//
        public string test3(string a);
    }
    public interface IExamples2
    {
        public void etest1();
        public void test2();//
        public void etest2();
        public void etest3();

    }
    public class cchildmethods : IExamples2, IExamples
    {
        public void etest1()
        {
            Console.WriteLine("i  etest methhod 1");
        }

        public void etest2()
        {
            Console.WriteLine("this is secound etest2");
        }

        public void etest3()
        {
            Console.WriteLine("this another etest3"); 
        }

        public int sum(int a, int b)
        {
            return a+b;
        }

        public void test1()
        {
            Console.WriteLine("this is test1");
        }

         void IExamples.test2()
        {
            Console.WriteLine("this is test2");
        }
        void IExamples2.test2()///////////////////////this is Explicit implementation/////
        {
            Console.WriteLine("this is secound interface test2");
        }

        public string test3(string a)
        {
            return a;
        }
    }
}
////////////syntax to call explicit implimentation
/// ((interfacename)objectname).methodname();

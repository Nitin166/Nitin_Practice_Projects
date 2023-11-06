using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface InterfaceExample
    {
        public void test1();
        public void test2();
        public void sum(int a, int b);
        public int test3(int a, int b);
    }
    public interface IExample2
    {
        public int example(int i, int j);
        public void example1(int y);
        public void sum(int a, int b);
    }
    public class childclass : IExample2, InterfaceExample
    {
        public int example(int i, int j)
        {
            return i+j;
        }

        public void example1(int y)
        {
            Console.WriteLine(y);
        }

        public void sum(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public void test1()
        {
            Console.WriteLine("this is test method");
        }

        public void test2()
        {
            throw new NotImplementedException();
        }

        public int test3(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}

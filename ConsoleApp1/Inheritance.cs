using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Inheritance
    {
    }
    public class parent
    {
        public void testmethod1()
        {
            Console.WriteLine("this is first testmethod");
        }
        public int sum(int a, int v)
        {
            return a+v;
        }
    }
    public class child : parent
    {
        public void childclass()
        {
            Console.WriteLine("this is child class method");
        }
        public void childclasstest1()
        {
            Console.WriteLine("this is chid class test 1");
        }
        public class grandclass:child
        {
            public void grandclassmethod()
            {
                Console.WriteLine("this is grandchild method");
            }
            public int multiplication(int p, int q)
            {
                return p*q;
            }
        }
    }
}
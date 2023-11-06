using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Inheritance_Constructor
    {
    }
    public class parentmethods
    {
        public void parenrttest1()
        {
            Console.WriteLine("this is test method1");
        }
        public parentmethods()
        {

        }
        static parentmethods()
        {

        }
    }
    public class childmethods: parentmethods
    {
        public void childmethodtest1()
        {
            Console.WriteLine("this is child methods test");
        }
        public childmethods()
        {

        }
        static childmethods()
        {

        }
    }
    public class grandchildmethods: childmethods
    {
        public void grandtest1()
        {
            Console.WriteLine("this is grandchildmethod");
        }
        public grandchildmethods()
        {

        }
        static grandchildmethods()
        {


        }
    }
}
//////////////////ALL THE NON STATIC CONSTRUCTOR METHODS GET CALLED FROM TOP TO BOTTOM
/////////////////ALL THE STATICC CONSTRUCTOR GET CALLED FROM BOTTOM TO TOP////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MethodDetails
    {

        /// //////default methods

        public void testmethod()
        {
            Console.WriteLine("this is testmethod 1");
        }
        ////////////////////////////////
        ///perameterized method
        ///
        public int sum(int a, int b)
        {
            return a+b;
        }
        public void mathsoperation(int p, int q, string operation)
        {
            int result = 0;
            if (operation=="sum")
            {
                result = p+q;
            }
            else if (operation=="Subtraction ")
            {
                result =p-q;
            }
            else if (operation=="multiply")
            {
                result = p*q;
            }
            else
            {
                result = p/q;
            }
            Console.WriteLine("this is your result " + result);
        }
        /////////////////method that return more than one values
        ///
        public string[] getallanimals()
        {
            string[] animals = new string[3];
            animals[0] = "cat";
            animals[1]= "dog";
            animals[2]="rat";
            return animals;

        }
    }
}

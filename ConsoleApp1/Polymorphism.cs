using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Polymorphism//////same name can behave in diffrtent in differeent situations

    {
        public void add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void add(int r)
        {
            Console.WriteLine(r);
        }
        public void add(string a, string b)
        {
            Console.WriteLine(a+b);
        }
        
    }
}
///////////////polymorphism are two type 
///1.static := this method give error on compile time ex=overloading
///2.Complile time:= this method give error on run time ex= overriding
///METHOD OVERLOADING :- THE METHOD WITH THE SAME NAME BUT SIGNATUREE OT THOSE METHODS ARE DIFFERENT

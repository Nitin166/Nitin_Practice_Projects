using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MobilePhone
    {
        public string mobilename { get; set; }
        public string color { get; set; }
        public int model { get; set; }
        public string simtype { get; set; }
        public string call(string speech)
        {
            return speech;
        }
        public string message(string text)
        {
            return text;
        }
        public String camera(bool click)
        {
            if(click)
            {
                return "photoclicked";
            }
            else
            {
             return   "photo not clicked";
            }
        }




    }
}

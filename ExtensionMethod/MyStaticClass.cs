using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    static class MyStaticClass
    {
        public static void Func3(this Program P)// this is an Extension method
        {
            Console.WriteLine("this is third Function");
        }
    }
}

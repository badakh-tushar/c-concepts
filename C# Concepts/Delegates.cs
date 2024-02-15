using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C__Concepts
{
    public  delegate void Call(string msg);

    class Delegates
    {
        public void Method1(string msg) { 
            Console.WriteLine("method 1 " + msg);
        }

        public void Method2(string msg)
        {
            Console.WriteLine("method 2 " + msg);
        }

    }
}

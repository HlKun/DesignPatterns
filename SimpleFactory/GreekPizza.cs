using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class GreekPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Greek");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class ChessPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Chess");
        }
    }
}

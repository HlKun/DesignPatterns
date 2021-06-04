using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class PizzaFactory
    {
        public static Pizza creatPizza(string type)
        {
            Pizza p = null;

            switch (type)
            {
                case ("Chess"):
                    {
                        p = new ChessPizza();
                        break;
                    }
                case ("Greek"):
                    {
                        p = new GreekPizza();
                        break;
                    }
                default:
                    break;
            }

            if (p != null)
            {
                p.Prepare();
            }

            return p;
        }
    }
}

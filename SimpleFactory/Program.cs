using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = PizzaFactory.creatPizza("Chess");
            var p2 = PizzaFactory.creatPizza("Greek");

            Console.ReadKey();
        }
    }
}

using System;

namespace Factorymethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new ChessPizzaFactory();
            var c2 = new GreekPizzaFactory();

            var p1 = c1.creatPizza();
            var p2 = c2.creatPizza();

            Console.ReadKey();
        }
    }

    abstract class Pizza
    {
        public abstract void Prepare();

        public void Bake()
        {

        }

        public void Cut()
        {

        }

        public void Box()
        {

        }
    }

    class ChessPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Chess");
        }
    }

    class GreekPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Greek");
        }
    }

    /*
     * 抽象成员、方法必须在抽象类中 
     */
    abstract class Factory
    {
        public abstract Pizza creatPizza();
    }

    class ChessPizzaFactory : Factory
    {
        public override Pizza creatPizza()
        {
            Pizza p = new ChessPizza();
            p.Prepare();
            return p;
        }
    }

    class GreekPizzaFactory : Factory
    {
        public override Pizza creatPizza()
        {
            Pizza p = new GreekPizza();
            p.Prepare();
            return p;
        }
    }
}

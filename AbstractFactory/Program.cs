using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var f1 = new BjFactory();
            var f2 = new ShFactory();

            f1.createChees();
            f1.createPepper();

            f2.createChees();
            f2.createPepper();

            Console.ReadKey();
        }
    }

    abstract class PerpaPizza
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

    abstract class CheesPizza
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

    class BjPerpaPizza : PerpaPizza
    {
        public override void Prepare()
        {
            Console.WriteLine("BJ_Pepper");
        }
    }

    class BjCheesPizza : CheesPizza
    {
        public override void Prepare()
        {
            Console.WriteLine("BJ_Chees");
        }
    }

    class ShPerpaPizza : PerpaPizza
    {
        public override void Prepare()
        {
            Console.WriteLine("SH_Pepper");
        }
    }

    class ShCheesPizza : CheesPizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Sh_Chees");
        }
    }

    abstract class Abstract_Factory
    {
        public abstract PerpaPizza createPepper();
        public abstract CheesPizza createChees();
    }

    class BjFactory : Abstract_Factory
    {
        public override CheesPizza createChees()
        {
            CheesPizza p = new BjCheesPizza();
            p.Prepare();

            return p;
        }

        public override PerpaPizza createPepper()
        {
            PerpaPizza p = new BjPerpaPizza();
            p.Prepare();

            return p;
        }
    }
    class ShFactory : Abstract_Factory
    {
        public override CheesPizza createChees()
        {
            CheesPizza p = new ShCheesPizza();
            p.Prepare();

            return p;
        }

        public override PerpaPizza createPepper()
        {
            PerpaPizza p = new ShPerpaPizza();
            p.Prepare();

            return p;
        }
    }
}

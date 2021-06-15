using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder cb = new CommonBuilder();
            Builder hb = new CommonBuilder();

            Director director = new Director();

            director.BuildProduct(cb);
            director.BuildProduct(hb);
        }
    }

    /*
     * 具体的产品
     */
    class Product
    {
        public string Base { get; set; }

        public string Wall { get; set; }

        public string Roof { get; set; }

        public void Show()
        {
            Console.WriteLine(Base);
            Console.WriteLine(Wall);
            Console.WriteLine(Roof);
        }
    }

    /*
     * 抽象建造者
     * 负责构造产品部件、不负责产品构造流程
     */
    abstract class Builder
    {
        protected readonly Product product = new Product();

        public abstract void BuildBase();
        public abstract void BuildWall();
        public abstract void BuildRoof();
        public Product GetProduct()
        {
            product.Show();
            return product;
        }
    }

    /*
     * 具体建造器1
     */
    class CommonBuilder : Builder
    {
        public override void BuildBase()
        {
            product.Base = "石头";
        }

        public override void BuildWall()
        {
            product.Wall = "3m";
        }

        public override void BuildRoof()
        {
            product.Roof = "木头";
        }
    }


    /*
     * 具体建造器2
     */
    class HighBuilder : Builder
    {
        public override void BuildBase()
        {
            product.Base = "石头";
        }

        public override void BuildWall()
        {
            product.Wall = "5m";
        }

        public override void BuildRoof()
        {
            product.Roof = "天花板";
        }
    }

    /*
     * 指挥者
     * 负责建造流程
     */
    class Director
    {
        public Product BuildProduct(Builder builder)
        {
            builder.BuildBase();
            builder.BuildWall();
            builder.BuildRoof();
            return builder.GetProduct();
        }
    }
}

using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1.EchoAndReturn("OK");
            //Console.WriteLine(Test1.y);

            Singleton_Type_One.TheInstance();
            Console.ReadKey();
        }
    }

    /// <summary>
    /// 静态变量在第一次被调用时初始化全部静态变量
    /// </summary>
    class Test1
    {
        public static string x = EchoAndReturn("In type initializer");

        public static string y = "Y";

        public static string EchoAndReturn(string s)
        {
            Console.WriteLine(s);
            return s;
        }
    }

    /// <summary>
    /// 单例模式----饿汉式(静态常量)
    /// 可能会造成内存浪费
    /// </summary>
    class Singleton_Type_One
    {
        // 私有化构造函数、禁止外部实例化
        private Singleton_Type_One() 
        {
            Console.WriteLine("INITED");
        }

        // 实例化对象
        private static Singleton_Type_One instance = new Singleton_Type_One();

        public static Singleton_Type_One TheInstance()
        {
            return instance;
        }
    }

    /// <summary>
    /// 懒汉式(线程不安全)
    /// </summary>
    class Singalton_Type_Sencond
    {
        private Singalton_Type_Sencond() { }

        private static Singalton_Type_Sencond instance;

        public static Singalton_Type_Sencond GetInstance()
        {
            if (instance == null)
                instance = new Singalton_Type_Sencond();

            return instance;
        }
    }

    /// <summary>
    /// 懒汉式(线程安全，同步方法)
    /// 解决了线程不安全的问题
    /// 执行效率低
    /// </summary>
    class Singalton_Type_Third
    {
        private Singalton_Type_Third() { }

        private readonly static object ob = new object();

        private static Singalton_Type_Third instance;

        public static Singalton_Type_Third GetInstance()
        {
            lock (ob)
            {
                if (instance == null)
                    instance = new Singalton_Type_Third();

                return instance;
            }
        }
    }

    /// <summary>
    /// 双重检查(DoubleCheck)
    /// </summary>
    class Singalton_Type_Forth
    {
        private Singalton_Type_Forth() { }

        private readonly static object ob = new object();

        private static Singalton_Type_Forth instance;

        public static Singalton_Type_Forth GetInstance()
        {
            if (instance == null)
            {
                lock (ob)
                {
                    if (instance == null)
                        instance = new Singalton_Type_Forth();
                }
            }

            return instance;
        }
    }

    /// <summary>
    /// 静态内部类
    /// 在调用静态内部类的成员时，静态类进行装载
    /// </summary>
    class Singalton_Type_Fifth
    {
        private Singalton_Type_Fifth() { }

        private static class SingaltonInstance
        {
            public static Singalton_Type_Fifth instance = new Singalton_Type_Fifth();
        }

        public static Singalton_Type_Fifth GetInstance()
        {
            return SingaltonInstance.instance;
        }
    }
}

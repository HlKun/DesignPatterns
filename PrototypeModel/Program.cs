using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PrototypeModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person
            {
                Address = "HB",
                Sheep = new Sheep()
            };
            p.Sheep.ID = "0";
            p.Sheep.Name = "S1";

            var p1 = HelperTools.SerializableClone<Person>(p);
            p1.Sheep.ID = "1";

            Console.WriteLine(p.Sheep.ID);
            Console.WriteLine(p1.Sheep.ID);
        }
    }

    // 浅拷贝
    abstract class SheepPrototype
    {
        public abstract object Clone();
    }

    [Serializable]
    class Sheep
    {
        public string Name { get; set; }

        public string ID { get; set; }
    }

    [Serializable]
    class Person
    {
        public string Address { get; set; }

        public Sheep Sheep { get; set; }
    }


    public static class HelperTools
    {
        /// <summary>
        /// 序列化深拷贝
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T SerializableClone<T>(T source)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("The type must be serializable.", source.GetType().ToString());
            }
            if (Object.ReferenceEquals(source, null))
            {
                return default(T);
            }
            IFormatter formatter = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                // 把对象序列化到流中
                formatter.Serialize(ms, source);
                ms.Seek(0, SeekOrigin.Begin);
                // 反序列化输出对象
                return (T)formatter.Deserialize(ms);
            }
        }

        /// <summary>
        /// 反射属性浅拷贝
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static T PropertyClone<T>(T t)
        {
            if (Object.ReferenceEquals(t, null))
            {
                return default(T);
            }
            Type type = t.GetType();
            PropertyInfo[] propertyInfos = type.GetProperties();
            Object obj = Activator.CreateInstance<T>();
            Object p = type.InvokeMember("", BindingFlags.CreateInstance, null, t, null);
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                if (propertyInfo.CanWrite)
                {
                    object value = propertyInfo.GetValue(t, null);
                    propertyInfo.SetValue(obj, value, null);
                }
            }
            return (T)obj;
        }
    }
}

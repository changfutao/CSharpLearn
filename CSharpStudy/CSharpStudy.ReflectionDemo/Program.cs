namespace CSharpStudy.ReflectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             System.Type的实例代表了类型的元数据
             */

            Type intTypes = typeof(int).MakeArrayType();
            Console.WriteLine(intTypes == typeof(int[]));
        }
        /// <summary>
        /// 获取Type实例的方式
        /// </summary>
        static void GetTypes()
        {
            // 方式一:
            Type t1 = typeof(Person);
            // 方式二:
            Person p1 = new Person();
            Type t2 = p1.GetType();
        }
        /// <summary>
        /// Type实例的信息
        /// </summary>
        static void GetTypeInfo()
        {
            Type t1 = typeof(Person);
            // 类型名
            string name = t1.Name; // Person
            // 命名空间.类名
            string fullName = t1.FullName;
        }
    }
}

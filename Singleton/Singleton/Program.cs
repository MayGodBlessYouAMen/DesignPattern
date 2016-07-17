
namespace Singleton
{
    /// <summary>
    /// 单例模式Singleton
    /// 应用场合：有些对象只需要一个就足够了,比如老婆
    /// 作用：保证整个应用程序中某个实例有且只有一个
    /// 类型：饿汉模式、懒汉模式
    /// </summary>
    class Program
    { 
        /// <summary>
        /// test 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.getInstance();
            Singleton s2 = Singleton.getInstance();
            if (s1==s2)
            {
                System.Console.WriteLine("s1和s2是同一个实例。");
            }
            else
            {
                System.Console.WriteLine("s1和s2不是同一个实例。");
            }

            Singleton2 s3 = Singleton2.getInstance();
            Singleton2 s4 = Singleton2.getInstance();
            if (s3 == s4)
            {
                System.Console.WriteLine("s3和s4是同一个实例。");
            }
            else
            {
                System.Console.WriteLine("s3和s4不是同一个实例。");
            }
        }
    }
}

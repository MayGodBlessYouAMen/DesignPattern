
namespace Singleton
{
    /// <summary>
    /// 饿汉模式：类加载的时候创建类的实例 
    /// 饿汉模式的特点是加载类时比较慢，但运行时获取对象的速度比较快
    /// 饿汉模式是线程安全的
    /// </summary>
    class Singleton
    {
        //1.将构造方法私有化，不允许外部直接创建对象
        private Singleton() { }

        //2.创建类的唯一实例，用private static修饰
        private static Singleton instance = new Singleton();

        //3.提供一个获取实例的方法，用public static修饰
        public static Singleton getInstance() 
        {
            return instance;
        }
    }
}

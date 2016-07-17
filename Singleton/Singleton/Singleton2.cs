
namespace Singleton
{
    /// <summary>
    /// 懒汉模式：用户第一次获取的时候创建类的实例
    /// 懒汉模式的特点是加载类时比较快，但运行时获取对象的速度比较慢
    /// 懒汉模式是线程不安全的
    /// </summary>
    class Singleton2
    {
        //1.将构造方法私有化，不允许外部直接创建对象
        private Singleton2() { }

        //2.声明类的唯一实例，用private static修饰
        private static Singleton2 instance;

        //3.提供一个获取实例的方法，用public static修饰
        public static Singleton2 getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton2();
            }
            return instance;
        }
    }
}

using System;
namespace Readonly_test
{
    class Sizes
    {
        public readonly int Medium = 100; // 선언과 초기화
        public readonly int Large = 105;
        public readonly int XLarge; // 생성자에서 초기화
        public Sizes()
        {
            this.XLarge = 110;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sizes a = new Sizes();
            Console.WriteLine("Medium : {0}", a.Medium);
            Console.WriteLine("Large : {0}", a.Large);
            Console.WriteLine("XLarge : {0}", a.XLarge);
        }
    }
}

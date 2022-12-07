using System;
class StaticConstructor
{
    static int staticWithInitializer = 100; // 선언과 동시에 초기화
    static int staticWithNoInitializer; // static 생성자로 초기화
    static StaticConstructor()
    { // 매개변수와 접근 수정자를 가질 수 없다.
        staticWithNoInitializer = staticWithInitializer + 100; // staticWithNoInitializer 초기화
    }
    public static void PrintStaticVariable()
    {
        Console.WriteLine("field 1 = {0}, field 2 = {1}",
        staticWithInitializer, staticWithNoInitializer);
    }
}
class StaticConstructorApp
{
    public static void Main()
    {
        StaticConstructor.PrintStaticVariable();
    }
}
using System;                           // 引用 System 函式庫

public class Hello                      // 宣告類別 Hello
{
    public static void Main()            // 類別 Hello 的主程式
    {
        Console.WriteLine("sumWhile(1..10)=" + sumWhile(10));
        Console.WriteLine("sum(1..10)=" + sum(10));
    }

    public static int sumWhile(int n)
    {
        int s = 0;
        int i = 1;
        while (i <= n)
        {
            s = s + i;
            i = i + 1;
        }
        return s;
    }

    public static int sum(int n)
    {
        int s = 0;
        for (int i = 1; i <= n; i++)
        {
            s = s + i;
        }
        return s;
    }
}

using System;                           // 引用 System 函式庫

public class Hello                      // 宣告類別 Hello
{
    public static void Main()            // 類別 Hello 的主程式
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine("sum(1..10)=" + sum);
    }
}

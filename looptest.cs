using System;                           // �ޥ� System �禡�w

public class Hello                      // �ŧi���O Hello
{
    public static void Main()            // ���O Hello ���D�{��
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

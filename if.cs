using System;                           // �ޥ� System �禡�w

public class Hello                      // �ŧi���O Hello
{
    public static void Main()            // ���O Hello ���D�{��
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine("sum(1..10)=" + sum);
    }
}

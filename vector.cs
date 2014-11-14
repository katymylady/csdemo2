using System;

class Vector
{
    double[] a;

    public Vector(double[] array)
    {
        a = new double[array.GetLength(0)];
        for (int i = 0; i < a.GetLength(0); i++)
        {
            a[i] = array[i];
        }
    }

    public Vector add(Vector v2)
    {
        Vector rv = new Vector(v2.a);
        for (int i = 0; i < rv.a.GetLength(0); i++)
        {
            rv.a[i] = this.a[i] + v2.a[i];
        }
        return rv;
    }

    public void print()
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
    }
}

class Test
{
    public static void Main(string[] args)
    {
        Vector v1 = new Vector(new double[] { 1.0, 2.0, 3.0 });
        Vector v2 = new Vector(new double[] { 4.0, 5.0, 6.0 });
        Vector v3 = v1.add(v2);

        v1.print();
        v2.print();
        v3.print();
    }
}
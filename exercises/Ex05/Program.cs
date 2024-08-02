using System;
using System.Collections.Generic;

namespace Ex05;

public class FifthExercise
{
    public static void Main(string[] args)
    {
        Ratio r1 = new Ratio();
        r1.A = 2;
        r1.B = 4;

        Ratio r2 = new Ratio();
        r2.A = 4;
        r2.B = 8;

        Console.Write("Ratio1 = ");
        r1.Print();

        Console.Write("Ratio2 = ");
        r2.Print();


        Ratio tmp = new Ratio();
        tmp = r1.Add(r2);
        Console.Write(r1.Show() + " + " + r2.Show() + " = ");
        tmp.Print();

        tmp = r1.Add(10);
        Console.Write(r1.Show() + " + 10 = ");
        tmp.Print();

        tmp = r1.Mul(r2);
        Console.Write(r1.Show() + " * " + r2.Show() + " = ");
        tmp.Print();

        tmp = r1.Mul(10);
        Console.Write(r1.Show() + " * 10 = ");
        tmp.Print();
    }
}
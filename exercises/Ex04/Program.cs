using System;
using System.Collections.Generic;

namespace Ex04;

public class FourthExercise
{
    public static void Main(string[] args)
    {
        Ratio r1 = new Ratio();
        r1.A = 2;
        r1.B = 4;

        Ratio r2 = new Ratio();
        r2.A = 8;
        r2.B = 10;

        Console.Write("Ratio1 = ");
        r1.Print();

        Console.Write("Ratio2 = ");
        r2.Print();


        Ratio tmp = new Ratio();
        tmp = r1.Add(r2);
        Console.Write("Ratio1 + Ratio2 = ");
        tmp.Print();

        tmp = r1.Mul(r2);
        Console.Write("Ratio1 * Ratio2 = ");
        tmp.Print();
    }
}
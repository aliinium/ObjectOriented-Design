using System;
using System.Collections.Generic;

namespace Ex02;

public class SecondExercise
{
    public static void Main(string[] args)
    {
        Point p1 = new Point();
        p1.X = 10;
        p1.Y = 10;

        Point p2 = new Point();
        p2.X = 20;
        p2.Y = 20;

        Console.WriteLine("Point1 Distance From 0,0: \t" + p1.DistanceFromSource().ToString());
        Console.WriteLine("Point2 Distance From 0,0: \t" + p2.DistanceFromSource().ToString());

        Console.WriteLine("Point1 Distance From Point2: \t" + p1.DistanceFromPoint(p2).ToString());
    }
}
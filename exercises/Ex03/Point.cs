using System;
using static System.Math;

namespace Ex03;

public class Point
{
    public int X, Y;

    public double DistanceFromSource() 
    {
        return Math.Sqrt(this.X * this.X + this.Y * this.Y);
    }

    public double DistanceFromPoint(Point p)
    {
        int dx = this.X - p.X;
        int dy = this.Y - p.Y;

        return Math.Sqrt(dx * dx + dy * dy);
    }
}

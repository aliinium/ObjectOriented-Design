using System;
using static System.Math;

namespace Ex04;

public class Ratio
{
    public int A;
    public int B;

    public Ratio Add(Ratio r) {
        Ratio result = new Ratio();

        result.B = this.B * r.B;
        result.A = this.A * r.B + r.A * this.B;

        return result;
    }

    public Ratio Mul(Ratio r)
    {
        Ratio result = new Ratio();

        result.B = this.B * r.B;
        result.A = this.A * r.A;

        return result;
    }

    public void Print() 
    {
        Console.Write(this.A.ToString() + "/" + this.B.ToString() + "\n");
    }
}

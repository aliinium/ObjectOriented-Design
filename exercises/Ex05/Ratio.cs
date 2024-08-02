using System;
using static System.Math;

namespace Ex05;

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
    public Ratio Add(int n) {
        Ratio result = new Ratio();

        result.B = this.B;
        result.A = n * this.B + this.A;

        return result;
    }

    public Ratio Mul(Ratio r)
    {
        Ratio result = new Ratio();

        result.B = this.B * r.B;
        result.A = this.A * r.A;

        return result;
    }
    public Ratio Mul(int n)
    {
        Ratio result = new Ratio();

        result.B = this.B;
        result.A = n * this.A;

        return result;
    }

    public void Print() 
    {
        Console.Write(this.A.ToString() + "/" + this.B.ToString() + "\n");
    }
    
    public string Show()
    {
        return this.A.ToString() + "/" + this.B.ToString();
    }
}

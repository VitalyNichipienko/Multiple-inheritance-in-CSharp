using System;

namespace Multiple_inheritance_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            A objectA = new A();
            B objectB = new B();
            C objectC = new C();
            D objectD = new D();
            E objectE = new E();
            F objectF = new F();

            int value = 2;

            Console.WriteLine($"A: {value} in Pow1 = {(objectA as X1).PowX1(value)}");
            Console.WriteLine($"B: {value} in Pow2 = {(objectB as X2).PowX2(value)}");


            X1 x1 = objectC;
            X2 x2 = objectC;
            X3 x3 = objectF;

            Console.WriteLine($"C: {value} in Pow1 = {x1.PowX1(value)}, in Pow2 = {x2.PowX2(value)}");
            Console.WriteLine($"F: {value} in Pow3 = {x3.PowX3(value)}");
        }
    }
}

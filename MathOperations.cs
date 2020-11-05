using System;
using System.Collections.Generic;
using System.Text;
/*1.	MathOperation
 * Date : 05 Nov 2020
 * a class MathOperations, which should have 3 times method Add(). Method Add() have to be invoked with:
•	Add(int, int): int
•	Add(double, double, double): double
•	Add(decimal, decimal, decimal): decimal
*/
namespace polymorphism
{
    class MathOperations
    {
        public int Add (int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }
        public decimal Add(decimal a, decimal b, decimal c)
        {
            return a + b + c;
        }
    }
}

using System;
/*1.	MathOperation
 * Date : 05 Nov 2020 */
namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MathOperation");
            MathOperations mo = new MathOperations();
            Console.WriteLine(mo.Add(2, 3));
            Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
            Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));

        }
    }
}

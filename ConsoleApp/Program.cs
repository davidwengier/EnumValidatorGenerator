using System;

namespace ConsoleApp
{
    enum Simple
    {
        First,
        Second,

    }

    enum Complex
    {
        First = 3,
        Second = 14,
        Third = 14,
        Fourth = 8,
        Fifth = 9
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            DoSomethingSimple(Simple.Second);
            DoSomethingComplex(Complex.Fourth);

            DoSomethingComplex((Complex)5);
        }

        static void DoSomethingSimple(Simple simple)
        {
            EnumValidation.EnumValidator.Validate(simple);

            Console.WriteLine("Doing someting complex with " + simple);
        }

        static void DoSomethingComplex(Complex complex)
        {
            EnumValidation.EnumValidator.Validate(complex);

            Console.WriteLine("Doing someting complex with " + complex);
        }
    }
}
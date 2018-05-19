using System;

namespace Delegate
{
    class Program
    {
        public delegate double NumberReturnDelegate(int n);
        public delegate void Multidel();

        static void Main(string[] args)
        {
            Console.WriteLine("Delegate examples\n");

            DelegateFunctions df = new DelegateFunctions();

            NumberReturnDelegate number = df.SquareNumber;
            Console.WriteLine($"Squar number of 9 is: {number(9)}");

            number = df.CubeNumber;
            Console.WriteLine($"Cube number of 9 is: {number(9)}\n\n");


            Console.WriteLine("Composed delegate");
            Multidel multidel, multi2, multi3;
            multi2 = df.FirstDel;
            multi3 = df.SecondDel;
            multidel = multi2 + multi3;
            
            multidel();


            Console.WriteLine("Anonymous method");

            NumberReturnDelegate anonymous = delegate (int x)
            {
                return Math.Sqrt(x);
            };

            Console.WriteLine($"The sqrt 9 is: {anonymous(9)} \n");

            Func<string, string, string> anotherAnonymous = (str, str2) => (str+str2).ToUpper();

            Console.WriteLine($"Func and lambda: {anotherAnonymous("kambiz"," soltani")} \n");


            Console.ReadKey();

        }


    }
}

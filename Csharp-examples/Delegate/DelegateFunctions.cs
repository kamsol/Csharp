using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class DelegateFunctions
    {
        //Numeric return functions

        public double SquareNumber(int number) =>  number * number;
        
        public double CubeNumber(int number) => number * number * number;

        //Print text functions

        public void FirstDel() => Console.WriteLine("We are in first delegate");

        public void SecondDel() => Console.WriteLine("We are in second delegate \n\n");

    }
}

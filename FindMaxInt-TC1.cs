using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MaxInt-TC1
{
    internal class Program
    { 
        public static int MaxIntNum(int firstvalue, int secondvalue, int thirdvalue)
        {
            firstvalue = 25;
            secondvalue = 15;
            thirdvalue = 5;

            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return firstvalue;
            }
            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0)
            {
                return secondvalue;
            }
            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0)
            {
                return thirdvalue;
            }
            return firstvalue;
        }
        public static void Main(String[] args)
        {
            Console.WriteLine(MaxIntNum(25, 15, 5));
        }
    }
}





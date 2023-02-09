namespace MaxFloat_UC2
{
    internal class Program
    {
        public static double MaxDouble(double firstvalue, double secondvalue, double thirdvalue)
        {
            firstvalue = 10.5;
            secondvalue = 25.2;
            thirdvalue = 3.1;

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
        static void Main(string[] args)
        {
            Console.WriteLine(MaxDouble(10.5, 25.2, 3.1));
        }
    }
}

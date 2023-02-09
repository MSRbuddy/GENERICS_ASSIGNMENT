namespace MaxInt_TC3
{
    internal class Program
    {
        public static int MaxIntNum(int firstvalue, int secondvalue, int thirdvalue)
        {
            firstvalue = 100;
            secondvalue = 200;
            thirdvalue = 300;

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
            Console.WriteLine(MaxIntNum(100, 200, 300));
        }
    }
}
namespace MaxString_UC3
{
    internal class Program
    {
        public static string MaxString(string firstvalue, string secondvalue, string thirdvalue)
        {
            firstvalue = "Kanna";
            secondvalue = "Anu";
            thirdvalue = "Abhi";

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
            Console.WriteLine(MaxString("Kanna", "Anu", "Abhi"));
        }
    }
}
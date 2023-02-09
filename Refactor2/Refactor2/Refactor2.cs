namespace Refactor2
{
    internal class Refactor2
    {
        public class GenericMax<T> where T : IComparable
        {
            public T firstvalue, secondvalue, thirdvalue;
            public GenericMax(T firstvalue, T secondvalue, T thirdvalue)
            {
                this.firstvalue = firstvalue;
                this.secondvalue = secondvalue;
                this.thirdvalue = thirdvalue;
            }
            public GenericMax()
            {
            }
            public static T MaxValue(T firstvalue, T secondvalue, T thirdvalue)
            {
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
                return default;
            }
            public T MaxMethod()
            {
                T max = GenericMax<T>.MaxValue(this.firstvalue, this.secondvalue, this.thirdvalue);
                return max;

            }
            static void Main()
            {
                GenericMax<int> generic = new GenericMax<int>(5, 3, 1);
                generic.MaxMethod();
                GenericMax<double> generic1 = new GenericMax<double>(44.9, 16.3, 52.4);
                generic1.MaxMethod();
                GenericMax<string> generic2 = new GenericMax<string>("Mango", "PineApple", "Guava");
                generic2.MaxMethod();
            }
        }
    }
}
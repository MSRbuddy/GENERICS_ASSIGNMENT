namespace MaxMethod_UC5
{
    internal class Program
    {
        public class GenericMax<T> where T : IComparable
        {
            public T[] value;
            public GenericMax(T[] value)
            {
                this.value = value;
            }
            public T[] Sort(T[] values)
            {
                Array.Sort(values);
                return values;               
            }
            public T MaxValue(params T[] values)
            {
                var sortedValues = Sort(values);
                return sortedValues[^1];
            }
            public T MaxMethod()
            {
                var max = MaxValue(this.value);
                return max;
            }
            public void printMaxValue()
            {
                var max = MaxValue(this.value);
                Console.WriteLine("Maximum Value is: " + max);
            }
            static void Main(String[] args)
            {
                int[] intArray = { 100, 200, 300, 400, 500 };
                GenericMax<int> generic = new GenericMax<int>(intArray);
                generic.printMaxValue();

                double[] doubleArray = { 75.3, 64.9, 103.2, 59.4, 125.2 };
                GenericMax<double> generic1 = new GenericMax<double>(doubleArray);
                generic1.printMaxValue();

                char[] charArray = { 'A', 'E', 'I', 'O', 'U' };
                GenericMax<char> generic2 = new GenericMax<char>(charArray);
                generic2.printMaxValue();

                string[] stringArray = { "Int", "Long", "Float", "Double", "String" };
                GenericMax<string> generic3 = new GenericMax<string>(stringArray);
                generic3.printMaxValue();
            }
        }
    }
}
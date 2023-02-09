namespace MaxMethod_UC4
{
    internal class Program
    {
        public static void toPrint(int[] Array)
        {
            foreach(int item in Array)
            {
                Console.WriteLine(item);
            }
        }
        public static void toPrint(double[] Array)
        {
            foreach (double item in Array)
            {
                Console.WriteLine(item);
            }
        }
        public static void toPrint(char[] Array)
        {
            foreach (char item in Array)
            {
                Console.WriteLine(item);
            }
        }
        public static void toPrint(string[] Array)
        {
            foreach (string item in Array)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            int[] intArray = {0, 5, 10, 15, 20, 25, 30};
            double[] doubleArray = {1.2, 2.4, 3.6, 4.8, 5.9, 6.5, 7.8};
            char[] charArray = {'M', 'E', 'G', 'H', 'A', 'N', 'A'};
            string[] stringArray = {"One", "Two", "Three", "Four", "Five", "Six", "Seven"};

            Program.toPrint(intArray);
            Program.toPrint(doubleArray);
            Program.toPrint(charArray);
            Program.toPrint(stringArray);
        }
    }
}
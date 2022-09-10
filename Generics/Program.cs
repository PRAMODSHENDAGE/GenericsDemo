namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, 4, 5 };
            double[] doubleArr = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            char[] charArr = { 'a', 'b', };
            PrintIntArr(intArr);
            PrintDoubleArr(doubleArr);
            PrintCharArr(charArr);
        }
        static void PrintIntArr(int[] arr)
        {
            foreach (var data in arr)
            {
                Console.WriteLine(data); ;
            }
        }
        static void PrintDoubleArr(double[] arr)
        {
            foreach (var data in arr)
            {
                Console.WriteLine(data); ;
            }
        }
        static void PrintCharArr(char[] arr)
        {
            foreach (var data in arr)
            {
                Console.WriteLine(data); ;
            }
        }
    }
}

namespace UdemyPractice
{
    class Program
    {

        static void getOdd(Array arr)
        {
            // method should print every odd number 
            foreach (int item in arr)
            {
                if (item % 2 != 0)
                {
                    System.Console.WriteLine(item);
                }
            }
        }
        static void getEven(Array arr)
        {
            // method should print every odd number 
            foreach (int item in arr)
            {
                if (item % 2 == 0)
                {
                    System.Console.WriteLine(item);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            getOdd(array);
            getEven(array);
        }
    }
}
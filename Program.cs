namespace UdemyPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your name");
            string name = Console.ReadLine() ?? "";

            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.Trim());
            Console.WriteLine(name.Substring(3));
        }
    }
}
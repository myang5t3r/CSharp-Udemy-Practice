namespace UdemyPractice
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] friends = { "Vanessa", "Josh", "Nic" };

            foreach (var friend in friends)
            {
                GreetFriend(friend);
            }

        }

        static void GreetFriend(string name)
        {
            Console.WriteLine($"Hi {name}, how are you?");
        }
    }
}
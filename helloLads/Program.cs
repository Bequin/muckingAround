using System;

namespace helloLads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            var Name = TryAnswer();

            Console.WriteLine("What's your age?");
            var Age = TryAnswer();

            Console.WriteLine("What month were you born?");
            var Month = TryAnswer();

            Console.WriteLine("Name: " + Name + ", age: " + Age + ", Month: " + Month);

            if (Month == "March")
            {
                Console.WriteLine("You're an Aeries.");
            }

        }

        static string TryAnswer()
        {
            var Answer = Console.ReadLine();

            if (Answer == "")
            {
                Console.WriteLine("You didn't write anything, champ. Please try again.");
                return Console.ReadLine();
            }
                return Answer;
        }

    }
}

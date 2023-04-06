using System;

namespace Methods_Mills_Justyce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a whole number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter another whole number");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Multiply(x,y));

            Console.WriteLine("enter your username");
            string name = Console.ReadLine();
            WelcomeUser(name);

            Goodbye();
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static void WelcomeUser(string username)
        {
            Console.WriteLine($"Hello {username}! It is nice to meet you!");
        }

        static void Goodbye()
        {
            Console.WriteLine("Have a fantastic day!");
        }
    }
}

using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Mahsati", "Hello");
            user.Age = -20;
            Console.WriteLine($"Username: {user.Username}");
            Console.WriteLine($"Age: {user.Age}");
            Console.WriteLine($"Password: {user.Password}");
        }
    }
}


using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class User
    {
        //User class (Username,Age ,Password)
        public string Username { get; set; }
        //Age propery-i mənfi ola bilməz.
        private int _age;
        private string _password;
        public int Age {
            get
            {
                return _age;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Age cannot be negative");
                    return;
                }
                _age = value;
            }
        }
        public string Password
        {
            get => _password;
            
            set
            {
                if(CheckPassword(value))
                    _password = value;
            }
        }
        private bool CheckPassword(string value)
        {
            //Boş ola bilməz
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Password cannot be empty");
                return false;
            }
            // Uzunluğu 8-dən kiçik ola bilməz
            if (value.Length < 8)
            {
                Console.WriteLine("Password cannot have less than 8 characters"); 
                return false;
            }
            // İçində ən az bir böyük hərf olmalıdır
            bool HasUpper = false;
            bool HasDigit = false;
            foreach (char c in value)
            {
                if (char.IsUpper(c))
                {
                    HasUpper = true;
                }
                if (char.IsDigit(c))
                {
                    HasDigit = true;
                }
            }
            if(!HasUpper)
            {
                Console.WriteLine("Password must have an uppercase character");
                return false;
            }
            if (!HasDigit)
            {
                Console.WriteLine("Password must have a digit");
                return false;
            }
            return true;

        }
        //Username, password property-ləri olmadan user obyekti yaratmaq olmaz. 
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
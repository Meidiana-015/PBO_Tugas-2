using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstruktordanDestruktor
{
    //Program konstruktor
    public class Program
    {
        public class UserKonstruktor
        {
            public string username;
            public string password;

            public UserKonstruktor(string username, string password)
            {
                this.username = username;
                this.password = password;
            }

        }
        public class UserDestruktor
        {
            public UserDestruktor()
            {
                Console.WriteLine("Instance Class Telah Dibuat");
            }
            // Destructor
            ~UserDestruktor()
            {
                Console.WriteLine("Instance Class Telah di Destroy");
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Konstruktor");
            UserKonstruktor supatop = new UserKonstruktor("supadupa", "barongan");
            Console.WriteLine("Usernaem: " + supatop.username);
            Console.WriteLine("Password: " + supatop.password);
            Console.WriteLine(" ");
            Console.WriteLine("Destruktor");
            Run();
            GC.Collect();
        }
        public static void Run()
        {
            // Membuat Instance Class
            UserDestruktor userdestruktor = new UserDestruktor();
        }
    }
}

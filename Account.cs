using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeni_task
{
    internal class Account
    {
        public string Name;
        public string Password="Cavid123";
        public string Username = "cavid123";

        public void Login(string username,string password)
        {
            if(username=="cavid123" && password=="Cavid123")
            {
                Console.WriteLine("giris ugurludur");
            }
            else
            {
                Console.WriteLine("email ve ya password sehvdir");
            }

        }

    }
}

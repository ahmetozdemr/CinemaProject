using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaProject.Entity;

namespace CinemaProject.Operation
{
    public class UserLogin
    {
        public void Login(List<User> users)
        {
           
            bool checkLogin = true;
            while (checkLogin)
            {
                Console.WriteLine("\tKullanıcı Login Sayfası");
                Console.Write("Kullanıcı Adı :");
                string usernm = Console.ReadLine();
                Console.Write("Şifre :");
                string passwrd = Console.ReadLine();

                foreach (var item in users)
                {
                    if (usernm == item.UserName && passwrd == item.Password)
                    {
                        Console.WriteLine("Giriş başarıldı");
                        checkLogin = !checkLogin;
                    }
                }
                if (checkLogin)
                {
                    Console.WriteLine("Yanlış parola ya da şifre girdiniz");
                }
            }
            Console.Clear();
        }
    }
}

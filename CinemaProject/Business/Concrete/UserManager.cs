using CinemaProject.Business.Abstract;
using CinemaProject.Business.ValidationRules;
using CinemaProject.Core.Utilities.Trivia;
using CinemaProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.Business.Concrete
{
    public class UserManager : IUserService
    {
        public void Add(List<User> users)
        {
            string firstName = null;
            string lastName = null;
            string userName = null;
            string password = null;

            bool result = true;
            while (result)
            {
                try
                {
                    Console.ResetColor();
                    Stars.Show(45);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Lütfen Adınızı Giriniz :");
                    firstName = Console.ReadLine();
                    Console.Write("Lütfen Soyadınız Giriniz :");
                    lastName = Console.ReadLine();
                    Console.Write("Lütfen bir kullanıcı adı oluşturunuz :");
                    userName = Console.ReadLine();
                    Console.Write("Lütfen bir kullanıcı şifresi oluşturunuz :");
                    password = Console.ReadLine();

                    string message = (result = !UserValidator.checktValidation(firstName, lastName, userName, password)) ? "Lütfen boş ya da eksik bırakmayınız" : "Tebrikler Başarıyla Kaydoldunuz";
                    Console.WriteLine(message);

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lütfen geçerli bir işlem tuşlayınız !!!");
                    Console.ResetColor();
                    result = true;
                }
            }

            users.Add(new User() { Id = users.Count + 1, FirstName = firstName, LastName = lastName, UserName = userName, Password = password });
        }

        public void Login(List<User> users)
        {
            bool checkLogin = true;
            int activeUserId = 0;
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
                        activeUserId = item.Id;
                    }
                }
                if (checkLogin)
                {
                    Console.WriteLine("Yanlış parola ya da şifre girdiniz");
                }
            }
            Console.Clear();

            // return activeUserId;
        }
    }
}

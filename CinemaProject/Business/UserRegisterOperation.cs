using CinemaProject.Business.ValidationRules;
using CinemaProject.Core.Utilities.Trivia;
using CinemaProject.Entities;
using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace CinemaProject.Business
{
    public class UserRegisterOperation
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
    }

}

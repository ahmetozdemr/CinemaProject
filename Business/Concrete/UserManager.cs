using CinemaProject.Business.Abstract;
using CinemaProject.Business.Utilities.Trivia;
using CinemaProject.Business.ValidationRules;
using CinemaProject.DataAccess.Abstract;
using CinemaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void Add()
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

            _userDal.Add(new User() { Id = _userDal.GetAll().Count + 1, FirstName = firstName, LastName = lastName, UserName = userName, Password = password });
        }

        public int Login()
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

                foreach (var item in _userDal.GetAll())
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

            return activeUserId;
        }
        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }
    }
}

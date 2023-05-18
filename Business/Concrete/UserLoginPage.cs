using CinemaProject.Business.Abstract;
using CinemaProject.Business.Concrete;
using CinemaProject.DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.InstanceFactory;

namespace Business.Concrete
{
    public class UserLoginPage
    {
        public static void Start(out IUserService userService, out int activeUserId)
        {
            userService = UserManagerInstance.Instance;
            Console.WriteLine("Hoş Geldiniz ");
            Console.WriteLine();
            Console.WriteLine("1 Kayıt Ol");
            Console.WriteLine("2 Giriş Yap");
            int num = Int16.Parse(Console.ReadLine());
            activeUserId = default;
            if (num == 1)
            {
                userService.Add();
                activeUserId = userService.Login();
            }
            else
            {
                activeUserId = userService.Login();
            }
        }
    }
}

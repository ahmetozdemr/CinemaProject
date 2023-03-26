using CinemaProject.Core.Utilities.Trivia;
using CinemaProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.Business
{
    public class UserRegisterOperation
    {

        public void Add(List<User> users)
        {
            string firstName = default;
            string lastName = default;
            string userName = default;
            string password = default;
            bool checkGap = default;
            bool checkWrong = default;
            while (checkGap)
            {
                try
                {
                    Console.ResetColor();
                    Stars.Show(45);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Lütfen Adınızı Giriniz :");
                    firstName = Console.ReadLine();
                    Console.WriteLine("Lütfen Soyadınız Giriniz :");
                    lastName = Console.ReadLine();

                    //Bu kısımda name ve surName değişkenlerinin boş,null ya da sadece boşluktan oluşup oluşmadığını kontrol ediyor.
                    //Tüm kuralları sağlıyorsa while döngüsünden çıkıyor
                    //Burdaki y değişkeni if ten sonra bir hata oluşursa hata çıktısı verirsin diye konuldu
                    if (!String.IsNullOrEmpty(firstName) && !String.IsNullOrEmpty(lastName))
                    {
                        foreach (var item1 in firstName)
                        {
                            if (item1 != ' ')
                            {
                                foreach (var item2 in lastName)
                                {
                                    if (item2 != ' ')
                                    {
                                        checkGap = !checkGap;
                                        checkWrong = true;
                                    }
                                }
                                checkWrong = !checkWrong;
                            }
                            checkWrong = !checkWrong;
                        }
                        checkWrong = !checkWrong;
                    }
                    else
                    {
                        checkGap = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Lütfen gerekli yerleri doldurunuz");
                        Console.ResetColor();
                    }
                    if (!checkWrong)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Lütfen gerekli yerleri doldurunuz");
                        Console.ResetColor();
                    }

                }
                catch
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lütfen geçerli bir işlem tuşlayınız !!!");
                    Console.ResetColor();
                    checkGap = true;
                }
            }


            users.Add(new User() { Id = users.Count + 1, FirstName = firstName, LastName = lastName, UserName = userName, Password = password });
            Console.WriteLine("Tebrikler Başarıyla Kaydoldunuz");
        }
    }
}

using CinemaProject.Core.Utilities.Trivia;
using CinemaProject.Entities;
using System;
using System.Collections.Generic;

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
            bool checkValidation = default;
            bool checkTextGap = default;
            while (checkValidation)
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

                    //Bu kısımda name ve surName değişkenlerinin boş,null ya da sadece boşluktan oluşup oluşmadığını kontrol ediyor.
                    //Tüm kuralları sağlıyorsa while döngüsünden çıkıyor

                    if (!String.IsNullOrEmpty(firstName) &&
                        !String.IsNullOrEmpty(lastName) &&
                        !String.IsNullOrEmpty(userName) &&
                        !String.IsNullOrEmpty(password))
                    {
                        foreach (var item1 in firstName)
                        {
                            if (item1 != ' ')
                            {
                                foreach (var item2 in lastName)
                                {
                                    if (item2 != ' ')
                                    {
                                        foreach (var item3 in userName)
                                        {
                                            if (item3 != ' ')
                                            {
                                                foreach (var item4 in password)
                                                {
                                                    if (item4 != ' ')
                                                    {
                                                        checkValidation = !checkValidation;
                                                        checkTextGap = true;
                                                    }
                                                }
                                                checkTextGap = !checkTextGap;
                                            }
                                        }
                                        checkTextGap = !checkTextGap;
                                    }
                                }
                                checkTextGap = !checkTextGap;
                            }
                            checkTextGap = !checkTextGap;
                        }
                        checkTextGap = !checkTextGap;
                    }
                    else
                    {
                        checkValidation = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Lütfen boş bırakmayınız");
                        Console.ResetColor();
                    }
                    if (!checkTextGap)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Lütfen gerekli yerleri sadece boşluk yazarak bırakmayınız");
                        Console.ResetColor();
                    }

                }
                catch
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lütfen geçerli bir işlem tuşlayınız !!!");
                    Console.ResetColor();
                    checkValidation = true;
                }
            }

            users.Add(new User() { Id = users.Count + 1, FirstName = firstName, LastName = lastName, UserName = userName, Password = password });
            Console.WriteLine("Tebrikler Başarıyla Kaydoldunuz");
        }
    }
}

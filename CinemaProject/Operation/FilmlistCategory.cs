using CinemaProject.Data;
using CinemaProject.Other;
using CinemaProject.Trivia;
using System;
using System.Collections.Generic;

namespace CinemaProject.Operation
{
    public class FilmlistCategory
    {
        public byte Show(byte selectedCategoryNumber, Films films, Categories categories)
        {
            Stars.Show(48);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{5} {0}{2}{1}{4}{3}", "|FİLM ADI|", "|FİYAT|", "         ", "|KATEGORİ|", "       ", "|NO|");
            Stars.Show(48);
            Console.ResetColor();

            var temp1 = new List<Film>();

            int i = 0;
            while (i < films.filmList.Count)
            {
                if (films.filmList[i].CategoryId == categories.categoryList[selectedCategoryNumber - 1].Id) //bu kısımda film listimde categori Id si ile categori listinde idleri eşit olan film listesini çağırdım
                {                                             //Burdaki kod fiyat listesinin daha düzgün çkması için yapıldı
                    int difference;
                    string gapLenght;
                    if (i < 9)                                // 9 dan küçük yapmamın sebebi, 9'dan sonra Id sayılar çift basamaklı olduğu için metin bi gıdım fazla çıkıyor
                    {
                        difference = 20 - films.filmList[i].Name.Length;
                        int l = 0;                             // l değişkeniyle differnce değerine kadar while döngüsünü döndürüyoruz
                        gapLenght = "";
                        while (l < difference)
                        {
                            gapLenght += " ";
                            l++;
                        }
                    }
                    else                                        // 9 dan fazla olan Id sayılarının isim uzunluğunu 19'dan çıkardım
                    {
                        difference = 19 - films.filmList[i].Name.Length;
                        int l = 0;
                        gapLenght = "";
                        while (l < difference)
                        {
                            gapLenght += " ";
                            l++;
                        }
                    }
                    temp1.Add(films.filmList[i]);//Geçici bir generic liste oluşturdum ve if koşulunu sağlayan elemankarı buraya attım ve try cact te kullandım                 

                    Console.WriteLine(" {6}{0} {1}{3}{2}{4}{5}", "->", films.filmList[i].Name, films.filmList[i].Price + " TL", gapLenght, "         ", categories.categoryList[selectedCategoryNumber - 1].Name, i + 1);
                }
                i++;
            }
            Stars.Show(48);


            byte selectedFilmNumber = 0;
            bool x = true;
            while (x)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("İzlemek istediğiniz Filmin No suna giriniz:");
                try
                {
                    selectedFilmNumber = byte.Parse(Console.ReadLine());
                    foreach (var item in temp1)
                    {
                        if (item.Id == selectedFilmNumber)
                        {
                            x = false;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Lütfen geçrli bir değer tuşlayınız");
                            Console.ResetColor();
                            x = true;
                        }
                    }

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lütfen geçerli bir değer tuşlayınız");
                    Console.ResetColor();
                    x = true;
                }
            }
            Console.ResetColor();
            Console.Clear();

            return selectedFilmNumber;
        }
    }
}


/*
   //Bu kısımda kategori seçimi yapılıyor
            byte selectedCategoryNumber = 5;

            while (selectedCategoryNumber > 4 || selectedCategoryNumber < 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1 ile 4 arasında bir Kategori Seçiniz");
                for (int i = 0; i < categories.categoryList.Count; i++)

                {
                    Console.WriteLine("\t{0} => {1} ", i + 1, categories.categoryList[i].Name);
                }

                try
                {
                    selectedCategoryNumber = byte.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lütfen geçerli bir işlem tuşlayınız !!!");
                    Console.ResetColor();
                    selectedCategoryNumber = 5;
                }
            }
            Console.Clear();


            return selectedCategoryNumber;
 */
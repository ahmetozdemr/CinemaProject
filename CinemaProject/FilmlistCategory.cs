using CinemaProject.Data;
using CinemaProject.Trivia;
using System;
using System.Collections.Generic;

namespace CinemaProject
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

            int i = 0;
            while (i < films.filmList.Count)
            {
                if (films.filmList[i].CategoryId == categories.categoryList[selectedCategoryNumber].Id)
                {                                             //Burdaki kod fiyat listesinin daha düzgün çkması için yapıldı
                    int difference;
                    string gapLenght;
                    if (i < 9)                                // 9 dan küçük yapmamın sebebi, 9'dan sonra Id sayılar çift basamaklı olduğu için metin bi gıdım fazla çıkıyor
                    {
                        difference = (20 - films.filmList[i].Name.Length);
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
                        difference = (19 - films.filmList[i].Name.Length);
                        int l = 0;
                        gapLenght = "";
                        while (l < difference)
                        {
                            gapLenght += " ";
                            l++;
                        }
                    }
                    Console.WriteLine(" {6}{0} {1}{3}{2}{4}{5}", "->", films.filmList[i].Name, films.filmList[i].Price + " TL", gapLenght, "         ", categories.categoryList[selectedCategoryNumber].Name, i + 1);
                }
                i++;
            }
            Stars.Show(48);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("İzlemek istediğiniz Filmin No suna giriniz:");

            byte selectedFilmNumber = byte.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.Clear();
            return selectedFilmNumber;
        }
    }
}

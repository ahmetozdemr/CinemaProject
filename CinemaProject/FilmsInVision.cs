using CinemaProject.Data;
using System;
using CinemaProject.Trivia;

namespace CinemaProject
{
    public class FilmsInVision
    {
        public byte Show(Films films, Categories categories)
        {
            Stars.Show(48);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                 VİZYONDAKİ FİLMLER");
            Stars.Show(48);

            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{5} {0}{2}{1}{4}{3}", "|FİLM ADI|", "|FİYAT|", "         ", "|KATEGORİ|", "       ", "|NO|");
            Console.ResetColor();
            Stars.Show(48);

            int r = 0;                                    //Burdaki değişken sayesinde film listesini sırasıyla yazdırmamı sağlıyor
            for (int i = 0; i < 4; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int j = 0; j < 3; j++)
                {                                             //Burdaki kod fiyat listesinin daha düzgün çkması için yapıldı
                    int difference;
                    string gapLenght;
                    if (r < 9)                                // 9 dan küçük yapmamın sebebi, 9'dan sonra Id sayılar çift basamaklı olduğu için metin bi gıdım fazla çıkıyor
                    {
                        difference = (20 - films.filmList[r].Name.Length);
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
                        difference = (19 - films.filmList[r].Name.Length);
                        int l = 0;
                        gapLenght = "";
                        while (l < difference)
                        {
                            gapLenght += " ";
                            l++;
                        }
                    }
                    Console.WriteLine(" {6}{0} {1}{3}{2}{4}{5}", "->", films.filmList[r].Name, films.filmList[r].Price + " TL", gapLenght, "         ", categories.categoryList[i].Name, r + 1);
                    r++;
                }

                Stars.Show(48);

            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Bir Kategori Seçiniz");
            for (int i = 0; i < categories.categoryList.Count; i++)
            {
                Console.WriteLine("\t{0} => {1} ", i, categories.categoryList[i].Name);
            }
            byte selectedCategoryNumber = byte.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.Clear();
            return selectedCategoryNumber;
        }
    }
}

using CinemaProject.Data;
using CinemaProject.Trivia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject
{
    public class FilmlistCategory
    {
        public void Show(byte chooseCategoryNumber)
        {
            Films films = new Films();
            Categories categories = new Categories();

            Stars.Show(48);
           
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{5} {0}{2}{1}{4}{3}", "|FİLM ADI|", "|FİYAT|", "         ", "|KATEGORİ|", "       ", "|NO|");
            Stars.Show(48);
            Console.ResetColor();

            int i = 0;
            while (i < films.filmList.Count)
            {
                if (films.filmList[i].CategoryId == categories.categoryList[chooseCategoryNumber].Id)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int lngth2;
                    string ls;
                    if (i < 9)
                    {
                        lngth2 = (20 - films.filmList[i].Name.Length);
                        int l = 0;
                        ls = "";
                        while (l < lngth2)
                        {

                            ls += " ";
                            l++;
                        }
                    }
                    else
                    {
                        lngth2 = (19 - films.filmList[i].Name.Length);
                        int l = 0;
                        ls = "";
                        while (l < lngth2)
                        {

                            ls += " ";
                            l++;
                        }
                    }

                    Console.WriteLine(" {6}{0} {1}{3}{2}{4}{5}", "->", films.filmList[i].Name, films.filmList[i].Price + " TL", ls, "         ", categories.categoryList[chooseCategoryNumber].Name, i + 1);
                }
                i++;
            }
            Stars.Show(48);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("İzlemek istediğiniz Filmin No suna giriniz:");

            byte chooseFilmNumber = byte.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.Clear();
            SeatNumber seatNumber = new SeatNumber();
            seatNumber.Show(chooseFilmNumber);
        }
    }
}

using CinemaProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaProject.Trivia;

namespace CinemaProject
{
    public class FilmsInVision
    {
        public void Show()
        {
            Stars.Show(48);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                 VİZYONDAKİ FİLMLER");
            Stars.Show(48);

            Films films = new Films();
            Categories categories = new Categories();
            int t = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{5} {0}{2}{1}{4}{3}", "|FİLM ADI|", "|FİYAT|", "         ", "|KATEGORİ|", "       ", "|NO|");
            Console.ResetColor();
            Stars.Show(48);
            for (int i = 0; i < categories.categoryList.Count; i++)
            {

                Console.ForegroundColor = ConsoleColor.Cyan;

                for (int j = 0; j < 3; j++)
                {
                    int lngth2;
                    string ls;
                    if (t < 9)
                    {
                        lngth2 = (20 - films.filmList[t].Name.Length);
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
                        lngth2 = (19 - films.filmList[t].Name.Length);
                        int l = 0;
                        ls = "";
                        while (l < lngth2)
                        {

                            ls += " ";
                            l++;
                        }
                    }

                    Console.WriteLine(" {6}{0} {1}{3}{2}{4}{5}", "->", films.filmList[t].Name, films.filmList[t].Price + " TL", ls, "         ", categories.categoryList[i].Name, t + 1);
                    t++;
                }

                Stars.Show(48);

            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Bir Kategori Seçiniz");
            for (int ii = 0; ii < categories.categoryList.Count; ii++)
            {
                Console.WriteLine("\t{0} => {1} ", ii, categories.categoryList[ii].Name);
            }
            byte chooseCategoryNumber = byte.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.Clear();

            FilmlistCategory filmlistCategory = new FilmlistCategory();
            filmlistCategory.Show(chooseCategoryNumber);
        }
    }
}

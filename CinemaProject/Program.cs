using System;
using System.Drawing;
using System.Threading;
using CinemaProject.Data;
using CinemaProject.Other;

namespace CinemaProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowSimplePercentage();
            TheVisionFilms();

           


            Console.ReadKey();
        }



        static void ShowSimplePercentage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rProgress: {i}%   ");
                Thread.Sleep(25);
            }
            Console.ResetColor();
            Console.Clear();

        }
        static void StarShow()
        {Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 50; i++)
                Console.Write("*");
            Console.WriteLine();
            Console.ResetColor();
        }
        static void TheVisionFilms()
        {




            StarShow();
           
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                 VİZYONDAKİ FİLMLER");
            //  Console.ResetColor();

            StarShow();

            Films film = new Films();
            Categories ctgry = new Categories();
            int t = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*{0}*{2}*{1}*{4}*{3} ", "FİLM ADI", "FİYAT", "            ", "KATEGORİ", "       ");
            Console.ResetColor();
            StarShow();
            for (int i = 0; i < ctgry.categoryList.Count; i++)
            {

                Console.ForegroundColor = ConsoleColor.Cyan;

                for (int j = 0; j < ctgry.categoryList.Count; j++)
                {
                    int lngth2 = (20 - film.filmList[t].Name.Length);
                    int l = 0;
                    string ls = "";
                    while (l < lngth2)
                    {

                        ls += " ";
                        l++;
                    }

                    Console.WriteLine("{0} {1}{3}{2}{4}{5}", "=>", film.filmList[t].Name, film.filmList[t].Price+" TL", ls,"         ",ctgry.categoryList[i].Name);
                    t++;
                }

                StarShow();

            }

            Console.WriteLine("Bir Kategori Seçiniz");
            for (int ii = 0; ii < ctgry.categoryList.Count; ii++)
            {
                Console.WriteLine("       {0} => {1} ", ii, ctgry.categoryList[ii].Name);
            }
        }
    }

}

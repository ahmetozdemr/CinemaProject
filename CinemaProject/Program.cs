using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using CinemaProject.Data;
using CinemaProject.Other;
using CinemaProject.Trivia;

namespace CinemaProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // SimplePercentage.Show();

            FilmsInVision filmsInVision = new FilmsInVision();
            filmsInVision.Show();

            // SimplePercentage.Show();

            Console.ReadKey();
        }
    }

}

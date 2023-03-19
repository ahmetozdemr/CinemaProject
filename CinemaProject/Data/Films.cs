using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaProject.Other;

namespace CinemaProject.Data
{
    public class Films : Film
    {
        public List<Film> filmList = new List<Film>()
        {
            new Film() {Id = 1,Name = "Avatar",CategoryId = 1,Price = 60},
            new Film() {Id = 2,Name = "Harry Potter",CategoryId = 1,Price = 65},
            new Film() {Id = 3,Name = "Mumya",CategoryId = 1,Price = 70},
            new Film() {Id = 4,Name = "Hulk",CategoryId = 1,Price = 60},
            new Film() {Id = 5,Name = "Yüzücüler",CategoryId = 2,Price = 50},
            new Film() {Id = 6,Name = "E. Bedeli",CategoryId = 2,Price = 40},
            new Film() {Id = 7,Name = "Yeşil Yol",CategoryId = 2,Price = 75},
            new Film() {Id = 8,Name = "Piyanist",CategoryId = 2,Price = 65},
            new Film() {Id = 9,Name = "G.O.R.A",CategoryId = 3,Price = 55},
            new Film() {Id = 10,Name = "A.R.O.G",CategoryId = 3,Price = 70},
            new Film() {Id = 11,Name = "Kolpaçino",CategoryId = 3,Price = 80},
            new Film() {Id = 12,Name = "Pardon",CategoryId = 3,Price = 90},
            new Film() {Id = 13,Name = "Matrix",CategoryId = 4,Price = 30},
            new Film() {Id = 14,Name = "Cesur Yürek",CategoryId = 4,Price = 40},
            new Film() {Id = 15,Name = "300 Spartalı",CategoryId = 4,Price = 35},
            new Film() {Id = 16,Name = "Gladyatör",CategoryId = 4,Price = 60},
        };
    }
}

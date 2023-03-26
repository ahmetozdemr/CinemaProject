using System.Collections.Generic;
using CinemaProject.Entities.Concrete;

namespace CinemaProject.DataAccess
{
    public class Films: IData
    {

        public List<Film> filmList = new List<Film>()
        {
            new Film() {Id = 1,Name = "Avatar",CategoryId = 1,Price = 60},
            new Film() {Id = 2,Name = "Harry Potter",CategoryId = 1,Price = 65},
            new Film() {Id = 3,Name = "Hulk",CategoryId = 1,Price = 60},
            new Film() {Id = 4,Name = "E. Bedeli",CategoryId = 2,Price = 40},
            new Film() {Id = 5,Name = "Yeşil Yol",CategoryId = 2,Price = 75},
            new Film() {Id = 6,Name = "Piyanist",CategoryId = 2,Price = 65},
            new Film() {Id = 7,Name = "G.O.R.A",CategoryId = 3,Price = 55},
            new Film() {Id = 8,Name = "A.R.O.G",CategoryId = 3,Price = 70},
            new Film() {Id = 9,Name = "Kolpaçino",CategoryId = 3,Price = 80},
            new Film() {Id = 10,Name = "Matrix",CategoryId = 4,Price = 30},
            new Film() {Id = 11,Name = "300 Spartalı",CategoryId = 4,Price = 35},
            new Film() {Id = 12,Name = "Gladyatör",CategoryId = 4,Price = 60},
        };
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaProject.Other;

namespace CinemaProject.Data
{
    public class Categories:Category
    {
     public List<Category> categoryList = new List<Category>()
        {
            new Category(){Id = 1,Name="Fantastik"},
            new Category(){Id = 2,Name="Dram"},
            new Category(){Id = 3,Name = "Komedi"},
            new Category(){Id = 4,Name="Aksiyon"},

        };    
    }
}

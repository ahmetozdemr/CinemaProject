using CinemaProject.Entities;
using System.Collections.Generic;

namespace CinemaProject.DataAccess
{
    public class Categories: IData
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

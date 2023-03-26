using CinemaProject.DataAccess.Abstract;
using CinemaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.DataAccess.Concrete.InMemory
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        List<Category> _categories;

        public InMemoryCategoryDal()
        {
            _categories = new List<Category>()
            {
            new Category(){Id = 1,Name="Fantastik"},
            new Category(){Id = 2,Name="Dram"},
            new Category(){Id = 3,Name = "Komedi"},
            new Category(){Id = 4,Name="Aksiyon"},
            };
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }
    }
}

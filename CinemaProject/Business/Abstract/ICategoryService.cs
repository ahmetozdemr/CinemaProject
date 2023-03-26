using CinemaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.Business.Abstract
{
    public interface ICategoryService
    {
        void Add();
        List<Category> GetAll();
        public int GetAllByCategoryId();
    }
}

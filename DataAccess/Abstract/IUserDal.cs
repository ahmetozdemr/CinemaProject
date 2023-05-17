using CinemaProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.DataAccess.Abstract
{
    public interface IUserDal
    {
        void Add(User user);
        void Update(User user);
        List<User> GetAll();
    }
}

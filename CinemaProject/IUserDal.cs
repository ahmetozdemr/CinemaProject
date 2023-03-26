using CinemaProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject
{
    public interface IUserDal
    {
        void Add(User user);
        void Update(User user);
        List<User> GetAll();
    }
}

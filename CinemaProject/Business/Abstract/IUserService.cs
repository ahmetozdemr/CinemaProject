using CinemaProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.Business.Abstract
{
    public interface IUserService
    {
        void Add(List<User> users);
        void Login(List<User> users);
    }
}

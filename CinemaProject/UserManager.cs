using CinemaProject.DataAccess.Abstract;
using CinemaProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject
{
    public class UserManager
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public List<User> GetAll()
        {
          return  _userDal.GetAll();
        }
    }
}

using CinemaProject.DataAccess.Abstract;
using CinemaProject.Entities;
using System;
using System.Collections.Generic;

namespace CinemaProject.DataAccess.Concrete.InMemory
{
    public class InMemoryUserDal: IUserDal
    {
        List<User> _users;
        public InMemoryUserDal()
        {
            _users = new List<User>()
            {
            new User() { Id = 1, FirstName = "Ahmet", LastName = "Özdemir", UserName = "ahmet", Password = "1234" },
            new User() { Id = 2, FirstName = "Ramazan", LastName = "Tuju", UserName = "rmzn", Password = "4321" },
            new User() { Id = 3, FirstName = "Mustafa", LastName = "Zdmr", UserName = "mstf", Password = "2233" },
            new User() { Id = 4, FirstName = "Mahmut", LastName = "Aga", UserName = "aga", Password = "6754" }
            };
        }

        public void Add(User user)
        {
            _users.Add(user);
        }

        public void Update(User user)
        {
           
        }
        public List<User> GetAll()
        {
            return _users;
        }
    }
}

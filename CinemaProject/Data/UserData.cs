using CinemaProject.Entity;
using System;
using System.Collections.Generic;

namespace CinemaProject.Data
{
    public class UserData
    {
        private List<User> _users;
        public UserData(List<User> users)
        {
            _users = users;
        }
        public List<User> Users{ get => _users;}

        public List<User> UserDataGet()
        {
            Users.Add(new User() { Id = 1, FirstName = "Ahmet", LastName = "Özdemir", UserName = "ahmet", Password = "1234" });
            Users.Add(new User() { Id = 2, FirstName = "Ramazan", LastName = "Tuju", UserName = "rmzn", Password = "4321" });
            Users.Add(new User() { Id = 3, FirstName = "Mustafa", LastName = "Zdmr", UserName = "mstf", Password = "2233" });
            Users.Add(new User() { Id = 3, FirstName = "Mahmut", LastName = "Aga", UserName = "aga", Password = "6754" });
            return Users;
        }
    }
}


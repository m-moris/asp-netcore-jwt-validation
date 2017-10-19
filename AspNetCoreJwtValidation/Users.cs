using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreJwtValidation
{
    public class Users
    {
        public User GetUser(string id, string password)
        {
            if (id == "admin")
            {
                return new User
                {
                    Id = "amdin",
                    Name = "admin taro", 
                    Role = "admin"
                };
            }
            else
            {
                return new User
                {
                    Id = "user",
                    Name = "user taro",
                    Role = "user"
                };
            }
        }
    }

    public class User
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Role { get; set; }
    }
}

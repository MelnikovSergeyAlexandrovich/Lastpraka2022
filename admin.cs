using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastpractin2022___________
{
    internal class admin : ICRUD
    {
       
        public static List< User> Users = new List< User>();

        public admin()
        {
            Read();
        }

        private void Read()
        {
            Users = jsonchik.Deserialize<List< User>>("users.json");
        }

        public void Create(User user)
        {
            Users.Add(user);
            Save();
        }

        public User Read(int userId)
        {
            return Users[userId];
        }

        public void Update(User user)
        {
            Users[user.id] = user;
            Save();
        }

        private void Save()
        {
            jsonchik.Serialize(Users, "users.json");
        }

        public void Delete(User user)
        {
            Users.Remove(user);
            Save();
        }
    }
}

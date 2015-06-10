using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EditProfileData.Model;

namespace EditProfileData.Data
{
    class Store
    {
        public static List<User> usersList = new List<User>();

        public static void insertUser(User u)
        {
            usersList.Add(u);
        }

        public static void updateUser(User u)
        {
            foreach (User user in usersList)
            {
                if (user.getId() == u.getId())
                {
                    user.setPassword(u.getPassword());
                }
            }
        }

        public static User getUserByUserName(string uName)
        {
            foreach (User user in usersList)
            {
                if (user.getUserName().Equals(uName))
                {
                    return user;
                }
            }
            return null;
        }

    }
}

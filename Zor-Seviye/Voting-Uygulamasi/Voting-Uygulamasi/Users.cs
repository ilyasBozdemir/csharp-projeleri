using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_Uygulamasi
{
    public class Users//
    {
        public static List<User> userList { get => getlist(); }
        //static yaptık çünkü ne kadar nesne olusturulsa olusturulsun
        //bu kısım ortak olsun istedik.
        private static List<User> getlist()
        {
            return new List<User>()
            {
                new User() { userName = "ilyas" },
                new User() { userName = "mehmet" }
            }; 

        }

        public void AddUser(User user)
        {
            userList.Add(user);
        }
    }
    public class User
    {
        public string userName { get; set; }
    }
    public class UserControl
    {
        public bool GetUser(User user)
        {
            bool state = false;
            foreach (User _user in Users.userList)
            {
                if (user.userName == _user.userName)
                    state = true;
            }
            return state;
        }
    }
}

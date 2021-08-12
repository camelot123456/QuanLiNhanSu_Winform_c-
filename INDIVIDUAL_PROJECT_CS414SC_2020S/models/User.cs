using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S.models
{
    class User
    {
        private string id;
        private string username;
        private string password;
        private string fullname;
        private string avatar;

        public User()
        {
        }

        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Avatar { get => avatar; set => avatar = value; }
    }
}

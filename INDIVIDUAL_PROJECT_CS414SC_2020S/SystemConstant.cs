using INDIVIDUAL_PROJECT_CS414SC_2020S.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S
{
    class SystemConstant
    {
        public static User USER = new User();
        public static Role ROLE = new Role();
        public static string USERNAME = null;
        public static string PASSWORD = null;
        public static string AVATAR = null;
        public static string FULLNAME = null;
        public static List<string> ROLES = new List<string>();
        public static bool IS_LOGIN = false;
    }
}

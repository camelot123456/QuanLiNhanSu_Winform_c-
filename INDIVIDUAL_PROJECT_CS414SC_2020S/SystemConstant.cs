using INDIVIDUAL_PROJECT_CS414SC_2020S.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S
{
    class SystemConstant
    {
        public static string USERNAME = null;
        public static string PASSWORD = null;
        public static string AVATAR = null;
        public static string FULLNAME = null;
        public static string ID = null;
        public static List<string> ROLES = new List<string>();
        public static bool IS_LOGIN = false;

        public static string PATH_BASE_STAFF = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\img\\avatar\\staff\\";
        public static string PATH_BASE_ACCOUNT = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\img\\avatar\\account\\";
    }
}

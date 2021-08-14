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
        public static User USER_MEMORY = null;
        public static Luong LUONG_MEMORY = null;
        public static Role ROLE_MEMORY = null;
        public static List<string> ROLES = new List<string>();

        public static string PATH_BASE_STAFF = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\img\\avatar\\staff\\";
        public static string PATH_BASE_ACCOUNT = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\img\\avatar\\account\\";

        public static NhanVien STAFF_MEMORY = null;
    }
}

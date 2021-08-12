using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S.models
{
    class Role
    {
        private string id;
        private string username;
        private User user = new User();
        private string roleCode;

        public Role()
        {
        }

        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string RoleCode { get => roleCode; set => roleCode = value; }
        internal User User { get => user; set => user = value; }
    }
}

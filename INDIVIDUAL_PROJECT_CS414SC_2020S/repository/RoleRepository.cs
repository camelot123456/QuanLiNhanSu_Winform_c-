using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S.repository
{
    class RoleRepository
    {
        AbstractDAO dao;

        public RoleRepository()
        {
            dao = new AbstractDAO();
        }

        public DataTable find()
        {
            string sql = "SELECT * FROM [ROLE]";
            return dao.queryForList(sql);
        }

        public DataTable findUserAndRole()
        {
            string sql = "SELECT R.IDROLE, U.FULLNAME, R.USERNAME, R.ROLECODE, U.IDUSER FROM [USER] U, [ROLE] R WHERE U.USERNAME = R.USERNAME";
            return dao.queryForList(sql);
        }

        public DataTable findUser()
        {
            string sql = "SELECT DISTINCT USERNAME FROM [USER]";
            return dao.queryForList(sql);
        }

        public DataTable findRole()
        {
            string sql = "SELECT DISTINCT ROLECODE FROM [ROLE]";
            return dao.queryForList(sql);
        }


        public DataTable findRoleCodeByUsername(string username)
        {
            string sql = "SELECT * FROM [ROLE] WHERE USERNAME = '" + username + "'";
            return dao.queryForList(sql);
        }

        public int save(string username, string roleCode)
        {
            string sql = "INSERT INTO [ROLE] VALUES('" + username + "', '" + roleCode + "')";
            return dao.executeUpdate(sql);
        }
    }
}

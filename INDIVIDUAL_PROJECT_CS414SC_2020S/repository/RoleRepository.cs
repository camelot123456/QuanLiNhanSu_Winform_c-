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
            string sql = "SELECT * FROM [ROLE] WHERE USERNAME NOT IN ('CEO', 'HR', 'PR')";
            return dao.queryForList(sql);
        }

        public DataTable findUserAndRole()
        {
            string sql = "SELECT R.IDROLE, U.FULLNAME, R.USERNAME, R.ROLECODE, U.IDUSER FROM [USER] U, [ROLE] R " +
                "WHERE U.USERNAME = R.USERNAME AND R.USERNAME NOT IN ('CEO', 'HR', 'PR')";
            return dao.queryForList(sql);
        }

        public DataTable findUser()
        {
            string sql = "SELECT DISTINCT USERNAME FROM [USER] WHERE USERNAME NOT IN ('CEO', 'HR', 'PR')";
            return dao.queryForList(sql);
        }

        public DataTable findRoleNotDefault()
        {
            string sql = "SELECT DISTINCT ROLECODE FROM [ROLE] WHERE USERNAME NOT IN ('CEO', 'HR', 'PR')";
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

        public int updateOneRoleCodedById(string roleCode, string idRole)
        {
            string sql = "UPDATE [ROLE] SET ROLECODE = '" + roleCode + "' WHERE IDROLE = '" + idRole + "'";
            return dao.executeUpdate(sql);
        }

        public int deleteOne(string idRole)
        {
            string sql = "DELETE FROM [ROLE] WHERE IDROLE = '" + idRole + "'";
            return dao.executeUpdate(sql);
        }
    }
}

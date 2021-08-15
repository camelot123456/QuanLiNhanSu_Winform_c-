using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S.repository
{
    class UserRepository
    {
        AbstractDAO dao;

        public UserRepository()
        {
            dao = new AbstractDAO();
        }

        public DataTable find()
        {
            string sql = "SELECT * FROM [USER] WHERE USERNAME NOT IN ('CEO', 'HR', 'PR')";
            return dao.queryForList(sql);
        }

        public DataTable findByUsernameAndPassword(string username, string password)
        {
            string sql = "SELECT * FROM [USER] WHERE USERNAME = '" + username + "' AND [PASSWORD] = '" + password + "'";
            return dao.queryForList(sql);
        }

        public int updateOnePasswordByIdUser(string password, string id)
        {
            string sql = "UPDATE [USER] SET [PASSWORD] = '" + password + "' WHERE IDUSER = '" + id + "'";
            return dao.executeUpdate(sql);
        }

        public int save(string fullname, string username, string avatar ,string password)
        {
            string sql = "INSERT INTO [USER] VALUES(N'" + fullname + "', N'"+avatar+"', N'" + username + "', N'" + password + "')";
            return dao.executeUpdate(sql);
        }

        public int updateOneFullnameAndAvatarByUsername(string fullname, string avatar, string username)
        {
            string sql = "UPDATE [USER] SET FULLNAME = N'" + fullname + "', AVATAR = N'" + avatar + "' WHERE USERNAME = '" + username + "'";
            return dao.executeUpdate(sql);
        }
        
        public int deleteOneById(string id)
        {
            string sql = "DELETE FROM [USER] WHERE IDUSER = " + id;
            return dao.executeUpdate(sql);
        }

    }
}

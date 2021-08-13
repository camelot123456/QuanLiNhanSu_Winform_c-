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
            string sql = "SELECT * FROM [USER]";
            return dao.queryForList(sql);
        }

        public DataTable findByUsernameAndPassword(string username, string password)
        {
            string sql = "SELECT * FROM [USER] WHERE USERNAME = '" + username + "' AND [PASSWORD] = '" + password + "'";
            return dao.queryForList(sql);
        }

        public int updateOnePasswordByUsername(string password, string username)
        {
            string sql = "UPDATE [USER] SET [PASSWORD] = '" + password + "' WHERE USERNAME = '" + username + "'";
            return dao.executeUpdate(sql);
        }

        public int save(string fullname, string username, string password)
        {
            string sql = "INSERT INTO [USER](FULLNAME, USERNAME, [PASSWORD]) VALUES(N'" + fullname + "', N'" + username + "', N'" + password + "')";
            return dao.executeUpdate(sql);
        }

        public int updateOneFullnameAndAvatarByUsername(string fullname, string avatar, string username)
        {
            string sql = "UPDATE [USER] SET FULLNAME = N'" + fullname + "', AVATAR = N'" + avatar + "' WHERE USERNAME = '" + username + "'";
            return dao.executeUpdate(sql);
        }
    }
}

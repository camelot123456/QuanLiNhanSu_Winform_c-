using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S.repository
{
    class HRRepository
    {

        AbstractDAO dao;

        public HRRepository()
        {
            dao = new AbstractDAO();
        }

        public DataTable find()
        {
            string sql = "SELECT * FROM NHANVIEN";
            return dao.queryForList(sql);
        }

        public int save(string name, string avatar, DateTime startDate, int gender, string department, string type)
        {
            string sql = "INSERT INTO NHANVIEN VALUES(N'"+ name + "', N'"+ avatar + "', '"+ startDate + "', "+ gender + ", N'"+ department + "', N'"+ type + "')";
            return dao.executeUpdate(sql);
        }

        public int updateOne(string name, string avatar, DateTime startDate, int gender, string department, string typeJob, string id)
        {
            string sql = "UPDATE NHANVIEN SET TENNV=N'" + name + "', AVATAR=N'" + avatar + "', NGAYVAOLAM='" + startDate + "', GIOITINH= " + gender + ", PHONGBAN=N'" + department + "', LOAICONGVIEC='"+typeJob+"' WHERE MANV = '" + id + "'";
            return dao.executeUpdate(sql);
        }

        public int deleteOne(string id)
        {
            string sql = "DELETE FROM NHANVIEN WHERE MANV = '" + id + "'";
            return dao.executeUpdate(sql);
        }
    }
}

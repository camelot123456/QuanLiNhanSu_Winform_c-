using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S.repository
{
    class DashRepository
    {

        AbstractDAO dao;

        public DashRepository()
        {
            dao = new AbstractDAO();
        }

        public object getCountByGender(int gender)
        {
            string sql = "SELECT COUNT(*) FROM NHANVIEN WHERE GIOITINH = " + gender;
            return dao.scalar(sql);
        }

        public object getCountByDepartment(string department)
        {
            string sql = "SELECT COUNT(*) FROM NHANVIEN WHERE PHONGBAN = N'" + department + "'";
            return dao.scalar(sql);
        }

        public object getCountByType(string type)
        {
            string sql = "SELECT COUNT(*) FROM NHANVIEN WHERE LOAICONGVIEC = N'" + type + "'";
            return dao.scalar(sql);
        }



        public DataTable getTotalByGender(int gender)
        {
            string sql = "SELECT * FROM LUONG L, NHANVIEN N WHERE L.MANV = N.MANV AND N.GIOITINH = " + gender;
            return dao.queryForList(sql);
        }

        public DataTable getTotalByDepartment(string department)
        {
            string sql = "SELECT * FROM LUONG L, NHANVIEN N WHERE L.MANV = N.MANV AND PHONGBAN = N'" + department + "'";
            return dao.queryForList(sql);
        }

        public DataTable getTotalByType(string type)
        {
            string sql = "SELECT * FROM LUONG L, NHANVIEN N WHERE L.MANV = N.MANV AND LOAICONGVIEC = N'" + type + "'";
            return dao.queryForList(sql);
        }

        public object countSLNhanVien()
        {
            string sql = "SELECT COUNT(*) FROM NHANVIEN";
            return dao.scalar(sql);
        }

        public object countLNhanVien()
        {
            string sql = "SELECT SUM(L.THANHLUONG) FROM LUONG L, NHANVIEN N WHERE L.MANV = N.MANV";
            return dao.scalar(sql);
        }
    }
}

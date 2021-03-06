using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S.repository
{
    class PRRepository
    {

        AbstractDAO dao;

        public PRRepository()
        {
            dao = new AbstractDAO();
        }

        public DataTable find()
        {
            string sql = "SELECT * FROM LUONG";
            return dao.queryForList(sql);
        }

        public DataTable findIdOfNhanVienByTypeJob(string typeJob)
        {
            string sql = "SELECT * FROM NHANVIEN WHERE LOAICONGVIEC = N'"+typeJob+"'";
            return dao.queryForList(sql);
        }

        
        public int deleteOne(string maluong)
        {
            string sql = "DELETE FROM LUONG WHERE MALUONG = " + maluong + "";
            return dao.executeUpdate(sql);
        }
        //--------------------------------------------------Full-time----------------------------------------------------
        public DataTable getLuongByTypeJobIsFulltime()
        {
            string sql = @"
                    SELECT L.MALUONG, N.AVATAR, N.TENNV, L.LUONGCOBAN, L.HESOLUONG, L.LUONG1NGAY, L.SONGAYLAM, L.LUONGTHUONG, THANHLUONG 
                    FROM LUONG L, NHANVIEN N WHERE L.MANV = N.MANV AND N.LOAICONGVIEC = N'Fulltime'
                ";
            return dao.queryForList(sql);
        }

        public int saveByFull(double lcb, double hsl, double l1n, double snl, double lt, double thanhluong, int manv)
        {
            string sql = "INSERT INTO LUONG(LUONGCOBAN, HESOLUONG, LUONG1NGAY, SONGAYLAM, LUONGTHUONG, THANHLUONG, MANV) " +
                "VALUES(" + lcb + ", " + hsl + ", " + l1n + ", " + snl + ", " + lt + ", " + thanhluong + ", " + manv + ")";
            return dao.executeUpdate(sql);
        }

        public int updateOneByFull(double lcb, double hsl, double l1n, double snl, double lt, double thanhluong, string maluong)
        {
            string sql = "UPDATE LUONG SET LUONGCOBAN=" + lcb + ", HESOLUONG=" + hsl + ", LUONG1NGAY=" + l1n + ", SONGAYLAM=" + snl + ", LUONGTHUONG=" + lt + ", THANHLUONG=" + thanhluong + " WHERE MALUONG=" + maluong + "";
            return dao.executeUpdate(sql);
        }
        //--------------------------------------------------Part-time----------------------------------------------------
        public DataTable getLuongByTypeJobIsParttime()
        {
            string sql = @"
                    SELECT L.MALUONG, N.AVATAR, N.TENNV, L.LUONG1GIO, L.SOGIOLAM, L.SONGAYLAM, L.LUONGTHUONG, THANHLUONG 
                    FROM LUONG L, NHANVIEN N WHERE L.MANV = N.MANV AND N.LOAICONGVIEC = N'Parttime'
                ";
            return dao.queryForList(sql);
        }

        public int saveByPart(double l1g, double snl, double sgl, double lt, double thanhluong, int manv)
        {
            string sql = "INSERT INTO LUONG(LUONG1GIO, SONGAYLAM, SOGIOLAM, LUONGTHUONG, THANHLUONG, MANV) " +
                "VALUES(" + l1g + ", " + snl + ", " + sgl + ", " + lt + ", " + thanhluong + ", " + manv + ")";
            return dao.executeUpdate(sql);
        }

        public int updateOneByPart(double l1g, double snl, double sgl, double lt, double thanhluong, string maluong)
        {
            string sql = "UPDATE LUONG SET LUONG1GIO=" + l1g + ", SONGAYLAM=" + snl + ", SOGIOLAM=" + sgl + ", LUONGTHUONG=" + lt + ", THANHLUONG=" + thanhluong + " WHERE MALUONG=" + maluong + "";
            return dao.executeUpdate(sql);
        }
    }
}

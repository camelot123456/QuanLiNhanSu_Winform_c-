using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S.models
{
    class NhanVien
    {
        private string msnv;
        private string tennv;
        private string avatar;
        private DateTime ngayVaoLam;
        private bool gioiTinh;
        private string phongBan;
        private string loaiCongViec;

        public NhanVien()
        {
        }

        public NhanVien(string msnv, string tennv, string avatar, DateTime ngayVaoLam, bool gioiTinh, string phongBan, string loaiCongViec)
        {
            this.msnv = msnv;
            this.tennv = tennv;
            this.avatar = avatar;
            this.ngayVaoLam = ngayVaoLam;
            this.gioiTinh = gioiTinh;
            this.phongBan = phongBan;
            this.loaiCongViec = loaiCongViec;
        }

        public string Msnv { get => msnv; set => msnv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public DateTime NgayVaoLam { get => ngayVaoLam; set => ngayVaoLam = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string PhongBan { get => phongBan; set => phongBan = value; }
        public string LoaiCongViec { get => loaiCongViec; set => loaiCongViec = value; }
    }
}

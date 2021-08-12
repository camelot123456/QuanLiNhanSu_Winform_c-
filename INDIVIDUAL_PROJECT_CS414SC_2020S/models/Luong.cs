using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S.models
{
    class Luong
    {
        private string maLuong;
        private double luongCoBan;
        private double heSoLuong;
        private double luong1Gio;
        private double luong1Ngay;
        private int soNgay;
        private int soGio;
        private double luongThuong;
        private string manv;
        private NhanVien nhanVien = new NhanVien();

        public Luong()
        {
        }

        public string MaLuong { get => maLuong; set => maLuong = value; }
        public double LuongCoBan { get => luongCoBan; set => luongCoBan = value; }
        public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public double Luong1Gio { get => luong1Gio; set => luong1Gio = value; }
        public double Luong1Ngay { get => luong1Ngay; set => luong1Ngay = value; }
        public int SoNgay { get => soNgay; set => soNgay = value; }
        public int SoGio { get => soGio; set => soGio = value; }
        public double LuongThuong { get => luongThuong; set => luongThuong = value; }
        public string Manv { get => manv; set => manv = value; }
        internal NhanVien NhanVien { get => nhanVien; set => nhanVien = value; }
    }
}

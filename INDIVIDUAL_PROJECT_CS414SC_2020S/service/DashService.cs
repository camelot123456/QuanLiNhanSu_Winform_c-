using INDIVIDUAL_PROJECT_CS414SC_2020S.GUI;
using INDIVIDUAL_PROJECT_CS414SC_2020S.repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S.service
{
    class DashService
    {
        DashRepository dashRepository;
        PRRepository pRRepository;
        frm_dashboard _Dashboard;

        public DashService(frm_dashboard dashboard)
        {
            _Dashboard = dashboard;
            dashRepository = new DashRepository();
            pRRepository = new PRRepository();
        }
        public void loadData()
        {
            _Dashboard.chart_gioiTinh.Series["Payroll"].Points.AddXY("Nam", (double)dashRepository.getTotalByGender(1));
            _Dashboard.chart_gioiTinh.Series["Payroll"].Points.AddXY("Nữ", (double)dashRepository.getTotalByGender(0));

            _Dashboard.chart_PhongBan.Series["Payroll"].Points.AddXY("Kế toán", (double)dashRepository.getTotalByDepartment("Kế toán"));
            _Dashboard.chart_PhongBan.Series["Payroll"].Points.AddXY("Nhân sự", (double)dashRepository.getTotalByDepartment("Nhân sự"));

            _Dashboard.chart_LoaiViec.Series["Payroll"].Points.AddXY("Full-time", (double)dashRepository.getTotalByType("Fulltime"));
            _Dashboard.chart_LoaiViec.Series["Payroll"].Points.AddXY("Part-time", (double)dashRepository.getTotalByType("Parttime"));

            _Dashboard.Pie_gioiTinh.Series["Payroll"].Points.AddXY("Nam", (int)dashRepository.getCountByGender(1));
            _Dashboard.Pie_gioiTinh.Series["Payroll"].Points.AddXY("Nữ", (int)dashRepository.getCountByGender(0));

            _Dashboard.pie_phongBan.Series["Payroll"].Points.AddXY("Kế toán", (int)dashRepository.getCountByDepartment("Kế toán"));
            _Dashboard.pie_phongBan.Series["Payroll"].Points.AddXY("Nhân sự", (int)dashRepository.getCountByDepartment("Nhân sự"));

            _Dashboard.pie_loaiViec.Series["Payroll"].Points.AddXY("Full-time", (int)dashRepository.getCountByType("Fulltime"));
            _Dashboard.pie_loaiViec.Series["Payroll"].Points.AddXY("Part-time", (int)dashRepository.getCountByType("Parttime"));

            _Dashboard.lbl_slnguoi.Text = dashRepository.countSLNhanVien().ToString() + " Người";
            _Dashboard.lbl_tongLuong.Text = dashRepository.countLNhanVien().ToString() + " VNĐ";
        }

    }
}

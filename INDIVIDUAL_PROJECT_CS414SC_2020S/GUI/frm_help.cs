using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S.GUI
{
    public partial class frm_help : Form
    {
        public frm_help()
        {
            InitializeComponent();
            richTextBox1.Text = "" +
                "   Đây là phần mềm quản lý nhân sự được phát triển bởi Nguyễn Sỹ Bảo - 7411 - CS414SC\n" +
                "   Có tính năng xử lý phân quyền, xác thực đối tượng, quản lý my account(đổi avatar, name, password), xem thống kê, nhân sự, lương, quyền và các account\n" +
                "   Hệ thống gồm 3 đối tượng chính: Giám đốc(CEO), quản lý nhân sự(MANAGER_HR), quản lý lương(MANAGER_PR)\n" +
                "       +Giám đốc được sở hữu toàn quyền(xem dashboard, quản lý nhân sự, quản lý lương, quản lý tài khoản, quản lý quyền)\n" +
                "       +Quản lý nhân sự(quản lý nhân sự,quản lý tài khoản, quản lý quyền)\n" +
                "       +Quản lý lương (Quản lý lương - có 2 tab : quản lý lương nhân viên full-time và part-time)\n" +
                "   Hệ thống cung cấp sẵn 3 tài khoản mặc định để có thể truy cập và sử dụng, 3 tài khoản này không thê cập nhập hoặc xóa\n" +
                "   Có thể được tạo thêm tài khoản mới nếu tài khoản đang truy cập được cấp quyền giám đốc(CEO) hoặc Quản lý nhân sự(MANAGER_HR)\n" +
                "   \n\n" +
                "   để sử dụng chức năng quản lý lương thì cần phải tạo nhân viên bên quản lý nhân sự trước\n" +
                "   Để sử dụng chức năng thêm quyền cho account, cần phải tạo account mới trước\n\n" +
                "   Lưu ý:" +
                "   +Sau khi tạo mới account thì account đó vẫn chưa thể sử dụng các chức năng chính trong hệ thống đc, \n" +
                "   để sử dụng các chức năng chính cần sử dụng 1 account có quyền CEO hoặc MANAGER_HR sau đó vào quản lý quyền rồi thêm quyền cho\n" +
                "   account vừa mới tạo là được" +
                "";
        }
    }
}

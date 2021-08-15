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
    public partial class frm_showAccountDefault : Form
    {
        public frm_showAccountDefault()
        {
            InitializeComponent();
            richTextBox1.Text = "Đây là những tài khoản mặc định được cấp sẵn\n" +
                "(những tài khoản này không thể cập nhập hoặc xóa!!)\n" +
                "\n" +
                "-------CEO--------\n" +
                "username: CEO\n" +
                "role: CEO, MANAGER_HR, MANAGER_PR\n" +
                "password: 1\n\n" +
                "-------HR---------\n" +
                "username: HR\n" +
                "role: MANAGER_HR\n" +
                "password: 1\n\n" +
                "-------PR---------\n" +
                "username: PR\n" +
                "role: MANAGER_PR\n" +
                "password: 1\n";
        }
    }
}

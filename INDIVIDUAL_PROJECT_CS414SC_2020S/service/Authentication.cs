using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INDIVIDUAL_PROJECT_CS414SC_2020S.repository;
using INDIVIDUAL_PROJECT_CS414SC_2020S.GUI;
using System.Data;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S.service
{
    class Authentication
    {
        UserRepository userRepository;
        RoleRepository roleRepository;
        frm_login frm_Login;
        frm_main frm_Main;

        public Authentication(frm_login frm_Login, frm_main frm_Main)
        {
            this.frm_Login = frm_Login;
            this.frm_Main = frm_Main;
            roleRepository = new RoleRepository();
            userRepository = new UserRepository();
        }

        public void handlerLogin()
        {
            DataTable dt = userRepository.findByUsernameAndPassword(frm_Login.txt_user.Text.ToUpper().Trim(), frm_Login.txt_pass.Text.Trim());
            if (dt.Rows.Count == 0)
            {
                frm_Login.lbl_warning_login.Text = @"Tên đăng nhập hoặc mật khẩu không đúng !!!";
                SystemConstant.USERNAME = null;
                SystemConstant.FULLNAME = null;
                SystemConstant.PASSWORD = null;
                SystemConstant.ROLES.Clear();
                frm_Login.Show();
                frm_Main.Hide();
            }
            else
            {
                frm_Login.lbl_warning_login.Text = "";
                SystemConstant.USERNAME = dt.Rows[0]["USERNAME"].ToString();
                SystemConstant.FULLNAME = dt.Rows[0]["FULLNAME"].ToString();
                SystemConstant.PASSWORD = dt.Rows[0]["PASSWORD"].ToString();
                dt = roleRepository.findRoleCodeByUsername(SystemConstant.USERNAME);
                foreach (DataRow row in dt.Rows)
                {
                    SystemConstant.ROLES.Add(row["ROLECODE"].ToString());
                }
                frm_Main.Show();
                frm_Login.Hide();
            }
        }
    }
}

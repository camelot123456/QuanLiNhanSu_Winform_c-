using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INDIVIDUAL_PROJECT_CS414SC_2020S.repository;
using INDIVIDUAL_PROJECT_CS414SC_2020S.GUI;
using System.Data;
using System.Windows.Forms;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S.service
{
    class Authentication
    {
        UserRepository userRepository;
        RoleRepository roleRepository;
        HomeService homeService;
        frm_login _Login;
        frm_main _Main;

        public Authentication(frm_login _Login, frm_main _Main)
        {
            this._Login = _Login;
            this._Main = _Main;
            homeService = new HomeService(this._Main);
            roleRepository = new RoleRepository();
            userRepository = new UserRepository();
        }

        public void handlerLogin()
        {
            DataTable dt = userRepository.findByUsernameAndPassword(_Login.txt_user.Text.ToUpper().Trim(), _Login.txt_pass.Text.Trim());
            if (dt.Rows.Count == 0)
            {
                homeService.contextLogout();
                _Login.lbl_warning_login.Text = "Tên đăng nhập hoặc mật khẩu không chính xác !";
                _Login.Show();
                _Main.Hide();
            }
            else
            {
                _Login.lbl_warning_login.Text = "";
                SystemConstant.USER_MEMORY = new models.User();
                SystemConstant.USER_MEMORY.Username = dt.Rows[0]["USERNAME"].ToString();
                SystemConstant.USER_MEMORY.Fullname = dt.Rows[0]["FULLNAME"].ToString();
                SystemConstant.PASSWORD = dt.Rows[0]["PASSWORD"].ToString();
                SystemConstant.USER_MEMORY.Avatar = dt.Rows[0]["AVATAR"].ToString();
                SystemConstant.USER_MEMORY.Id = dt.Rows[0]["IDUSER"].ToString();
                dt = roleRepository.findRoleCodeByUsername(SystemConstant.USER_MEMORY.Username);
                foreach (DataRow row in dt.Rows)
                {
                    SystemConstant.ROLES.Add(row["ROLECODE"].ToString());
                }
                _Main.btn_help.Visible = true;
                _Main.lbl_fullname.Text = SystemConstant.USER_MEMORY.Username;
                homeService.handlerBtnCloseChildForm();
                _Login.Hide();
                _Main.Show();

            }
        }
    }
}

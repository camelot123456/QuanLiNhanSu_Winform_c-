using INDIVIDUAL_PROJECT_CS414SC_2020S.GUI;
using INDIVIDUAL_PROJECT_CS414SC_2020S.repository;
using INDIVIDUAL_PROJECT_CS414SC_2020S.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S
{
    public partial class frm_main : Form
    {

        HomeService homeService;

        public frm_main()
        {
            InitializeComponent();
            btnCloseChild.Visible = false;
            homeService = new HomeService(this);
        }


        private void frm_main_Load(object sender, EventArgs e)
        {

            homeService.checkingLogin();
            if (SystemConstant.USERNAME != null)
            {
                lbl_fullname.Text = SystemConstant.FULLNAME;
            }
            else
            {
                lbl_fullname.Text = "Yêu cầu đăng nhập";
            }
        }

        private void tạoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool k = false;
            frm_createAccount _createAccount;
            foreach (string role in SystemConstant.ROLES)
            {
                if (role.Equals("CEO") || role.Equals("MANAGER_HR"))
                {
                    if (Application.OpenForms["frm_createAccount"] == null)
                    {
                        _createAccount = new frm_createAccount();
                        _createAccount.MdiParent = this;
                        _createAccount.Show();
                    }
                    else
                    {
                        _createAccount = new frm_createAccount();
                        Application.OpenForms["frm_createAccount"].Activate();
                    }
                    k = true;
                }
            }
            if (!k)
            {
                DialogResult d = MessageBox.Show("Bạn chưa được cấp quyền vào khu vực này !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_changePass _changePass;
            if (Application.OpenForms["frm_changePass"] == null)
            {
                _changePass = new frm_changePass();
                _changePass.MdiParent = this;
                _changePass.Show();
            }
            else
            {
                _changePass = new frm_changePass();
                Application.OpenForms["frm_changePass"].Activate();
            }

        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool k = false;
            frm_accList _accList;
            foreach (string role in SystemConstant.ROLES)
            {
                if (role.Equals("CEO") || role.Equals("MANAGER_HR"))
                {
                    if (Application.OpenForms["frm_accList"] == null)
                    {
                        _accList = new frm_accList();
                        _accList.MdiParent = this;
                        _accList.Show();
                    }
                    else
                    {
                        _accList = new frm_accList();
                        Application.OpenForms["frm_accList"].Activate();
                    }
                    k = true;
                }
            }
            if (!k)
            {
                DialogResult d = MessageBox.Show("Bạn chưa được cấp quyền vào khu vực này !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //---------------------------------------------------------------------------------------------------
      

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            homeService.handlerOpenChildFormDashboarh();
        }

        private void btn_hr_Click(object sender, EventArgs e)
        {
            homeService.handlerOpenChildFormHR();
        }

        private void btn_pr_Click(object sender, EventArgs e)
        {
            homeService.handlerOpenChildFormPR();
        }

        private void btn_role_Click(object sender, EventArgs e)
        {
            homeService.handlerOpenChildFormRoleList();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            homeService.openChildForms(new frm_dashboard());
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            homeService.openChildForms(new frm_login());
        }

        private void btnCloseChild_Click(object sender, EventArgs e)
        {
            homeService.handlerBtnCloseChildForm();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            homeService.handerExitApp();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            homeService.handerExitApp();
        }

        private void pb_avatar_Click(object sender, EventArgs e)
        {
            homeService.handerOpenChildFormMyAccount();
        }
    }
}

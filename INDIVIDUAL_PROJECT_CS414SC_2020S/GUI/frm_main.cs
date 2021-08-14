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
            if (SystemConstant.USER_MEMORY != null)
            {
                lbl_fullname.Text = SystemConstant.USER_MEMORY.Fullname;
                lbl_id.Text = SystemConstant.USER_MEMORY.Id;
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

        private void pb_avatar_Click(object sender, EventArgs e)
        {
            homeService.handerOpenChildFormMyAccount();
        }

        private void btn_createdAcc_Click(object sender, EventArgs e)
        {
            homeService.handerOpenChildFormCreateAccount();
        }
    }
}

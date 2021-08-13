using INDIVIDUAL_PROJECT_CS414SC_2020S.GUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S.service
{
    class HomeService
    {

        frm_main _Main;
        public Form activeForm;


        public HomeService(frm_main main)
        {
            _Main = main;
        }

        public void contextLogout()
        {
            _Main.lbl_fullname.Text = "Yêu cầu đăng nhập!";
            _Main.lbl_id.Text = "Yêu cầu đăng nhập!";

            SystemConstant.USERNAME = null;
            SystemConstant.FULLNAME = null;
            SystemConstant.PASSWORD = null;
            SystemConstant.AVATAR = null;
            SystemConstant.ID = null;
            SystemConstant.ROLES.Clear();

            _Main.btn_logout.Visible = false;
        }


        public void checkingLogin()
        {
            if (SystemConstant.USERNAME == null)
            {
                contextLogout();
                _Main.Hide();
                new frm_login().Show();
            }
            else
            {
                _Main.btn_logout.Visible = true;
                _Main.lbl_fullname.Text = SystemConstant.FULLNAME;
                _Main.pb_avatar.Image = Image.FromFile(SystemConstant.AVATAR);
                _Main.pb_avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                _Main.Show();
                new frm_login().Hide();
            }
        }

        public void handlerOpenChildFormDashboarh()
        {
            bool k = false;
            foreach (string role in SystemConstant.ROLES)
            {
                if (role.Equals("CEO"))
                {
                    k = true;
                    break;
                }
                else k = false;
            }
                
            if (!k)
            {
                DialogResult d = MessageBox.Show("Bạn chưa được cấp quyền vào khu vực này !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else openChildForms(new frm_dashboard());
        }

        public void handlerOpenChildFormHR()
        {
            bool k = false;
            foreach (string role in SystemConstant.ROLES)
            {
                if (role.Equals("CEO") || role.Equals("MANAGER_HR"))
                {
                    k = true;
                    break;
                }
                else k = false;
            }
            if (!k)
            {
                DialogResult d = MessageBox.Show("Bạn chưa được cấp quyền vào khu vực này !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else openChildForms(new frm_HR());
        }

        public void handlerOpenChildFormPR()
        {
            bool k = false;
            foreach (string role in SystemConstant.ROLES)
            {
                if (role.Equals("CEO") || role.Equals("MANAGER_PR"))
                {
                    k = true;
                    break;
                }
                else k = false;
            }
            if (!k)
            {
                DialogResult d = MessageBox.Show("Bạn chưa được cấp quyền vào khu vực này !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else openChildForms(new frm_PR());
        }

        public void handlerOpenChildFormRoleList()
        {
            bool k = false;
            foreach (string role in SystemConstant.ROLES)
            {
                if (role.Equals("CEO") || role.Equals("MANAGER_HR"))
                {
                    k = true;
                    break;
                }
                else k = false;
            }
            if (!k)
            {
                DialogResult d = MessageBox.Show("Bạn chưa được cấp quyền vào khu vực này !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else openChildForms(new frm_accList());
        }

        public void openChildForms(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            _Main.panelDesktopMain.Controls.Add(childForm);
            _Main.panelDesktopMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            _Main.lbl_title.Text = childForm.Text;
            _Main.btnCloseChild.Visible = true;
        }

        public void handlerLogout()
        {
            contextLogout();
            openChildForms(new frm_login());
            handlerBtnCloseChildForm();
        }

        public void handlerBtnCloseChildForm()
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }

        public void Reset()

        {
            _Main.lbl_title.Text = "HOME";
            _Main.btnCloseChild.Visible = false;
        }

        public void handerExitApp()
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                _Main.Close();
                contextLogout();
                new frm_login().Show();
            }
            else
            {
                return;
            }
        }

        public void handerOpenChildFormMyAccount()
        {
            openChildForms(new frm_myAcc());
        }
    }
}

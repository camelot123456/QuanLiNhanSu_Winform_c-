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

namespace INDIVIDUAL_PROJECT_CS414SC_2020S.GUI
{
    public partial class frm_myAcc : Form
    {
        UserService userService;

        public frm_myAcc()
        {
            userService = new UserService(this);
            InitializeComponent();
            txt_fullname.Text = SystemConstant.USER_MEMORY.Fullname;
            lbl_id.Text = SystemConstant.USER_MEMORY.Id;
            lbl_account.Text = SystemConstant.USER_MEMORY.Username;
            pb_avatar.Image = Image.FromFile(SystemConstant.PATH_BASE_ACCOUNT + SystemConstant.USER_MEMORY.Avatar);
            pb_avatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void frm_myAcc_Load(object sender, EventArgs e)
        {

        }

        private void btn_changePass_Click(object sender, EventArgs e)
        {
            frm_changePass _ChangePass = new frm_changePass();
            _ChangePass.lbl_id.Text = lbl_id.Text;
            _ChangePass.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            userService.updateOneFullnameAndAvatarByUsername();
        }

        private void pb_avatar_Click(object sender, EventArgs e)
        {
            userService.handlerUploadImg();
        }
    }
}

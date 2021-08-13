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
            txt_fullname.Text = SystemConstant.FULLNAME;
            txt_avatar.Text = SystemConstant.AVATAR;
            lbl_id.Text = SystemConstant.ID;
            lbl_account.Text = SystemConstant.USERNAME;
            pb_avatar.Image = Image.FromFile(SystemConstant.AVATAR);
            pb_avatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void frm_myAcc_Load(object sender, EventArgs e)
        {

        }

        private void btn_changePass_Click(object sender, EventArgs e)
        {
            new frm_changePass().Show();
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

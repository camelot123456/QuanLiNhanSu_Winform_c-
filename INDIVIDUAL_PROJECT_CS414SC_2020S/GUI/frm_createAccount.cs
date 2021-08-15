using INDIVIDUAL_PROJECT_CS414SC_2020S.models;
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
    public partial class frm_createAccount : Form
    {
        UserService userService;

        public frm_createAccount()
        {
            userService = new UserService(this);
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            userService.handlerAddAccount();
            userService.loadDataAccDel();
        }

        private void txt_username_Validated(object sender, EventArgs e)
        {
            userService.handlerValidateUsername();
        }

        private void txt_validatePass_Validated(object sender, EventArgs e)
        {
            userService.handlerValidatePassword();
        }

        private void pb_avatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            //OFD.Title = "Hãy chọn ảnh";
            OFD.Filter = "Hãy chọn ảnh jpg|*.jpg|png|*.png|tất cả ảnh|*.*";   // Lọc ảnh
            if (OFD.ShowDialog() == DialogResult.OK)    //  .OK chứ ko phải .YES
            {
                pb_avatar.Image = Image.FromFile(OFD.FileName);
                pb_avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_changePass_Click(object sender, EventArgs e)
        {
            txt_fullname.Text = "";
            txt_pass.Text = "";
            txt_username.Text = "";
            txt_validatePass.Text = "";
            txt_tenAnh.Text = "";
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            userService.handlerBtnDelete();
            userService.loadDataAccDel();
        }

        private void btn_free_part_Click(object sender, EventArgs e)
        {
            userService.freeMemory();
        }

        private void dataGridView_del_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SystemConstant.USER_MEMORY = new User();
            SystemConstant.USER_MEMORY.Id = dataGridView_del.CurrentRow.Cells["IDUSER"].Value.ToString();
            SystemConstant.USER_MEMORY.Username = dataGridView_del.CurrentRow.Cells["USERNAME"].Value.ToString();
            SystemConstant.USER_MEMORY.Avatar = dataGridView_del.CurrentRow.Cells["AVATAR"].Value.ToString();
            lbl_maTK_del.Text = SystemConstant.USER_MEMORY.Id;
            lbl_username_del.Text = SystemConstant.USER_MEMORY.Username;
            pb_img_del.ImageLocation = SystemConstant.PATH_BASE_ACCOUNT + dataGridView_del.CurrentRow.Cells["AVATAR"].Value.ToString();
            pb_img_del.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void frm_createAccount_Load(object sender, EventArgs e)
        {
            userService.loadDataAccDel();
        }
    }
}

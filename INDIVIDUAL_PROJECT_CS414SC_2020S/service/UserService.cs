using INDIVIDUAL_PROJECT_CS414SC_2020S.GUI;
using INDIVIDUAL_PROJECT_CS414SC_2020S.repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S.service
{
    class UserService
    {
        UserRepository userRepository;
        frm_changePass _changePass;
        frm_createAccount _CreateAccount;
        frm_myAcc _MyAcc;
        bool is_username = false;
        bool is_password = false;
        bool is_passOldChange = false;
        bool is_passNewChange = false;

        public UserService(frm_changePass _changePass)
        {
            userRepository = new UserRepository();
            this._changePass = _changePass;
        }

        public UserService(frm_myAcc _MyAcc)
        {
            userRepository = new UserRepository();
            this._MyAcc = _MyAcc;
        }

        public UserService(frm_createAccount createAccount)
        {
            _CreateAccount = createAccount;
            userRepository = new UserRepository();
        }

        public void updateOneFullnameAndAvatarByUsername()
        {
            try
            {
                DialogResult d = MessageBox.Show("Bạn có muốn cập nhập thông tin ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    Int32 CODE_IMG = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                    _MyAcc.pb_avatar.Image.Save(SystemConstant.PATH_BASE_ACCOUNT + _MyAcc.txt_avatar.Text + CODE_IMG + ".png");
                    userRepository.updateOneFullnameAndAvatarByUsername
                    (
                        _MyAcc.txt_fullname.Text,
                        _MyAcc.txt_avatar.Text + CODE_IMG + ".png",
                        SystemConstant.USER_MEMORY.Username
                    );
                    MessageBox.Show("Cập nhập thông tin thành công\nSẽ có hiệu lực sau lần đăng nhập tiếp theo");
                }
                else return;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        public void validateChangePass()
        {
            try
            {
                if (!_changePass.txt_pass_old.Text.Equals("") && !_changePass.txt_pass_new.Text.Equals("") && !_changePass.txt_pass_check.Text.Equals(""))
                {
                    if (is_passNewChange && is_passOldChange)
                    {
                        try
                        {
                            userRepository.updateOnePasswordByUsername(_changePass.txt_pass_check.Text, SystemConstant.USER_MEMORY.Username);
                            MessageBox.Show("Đổi mật khẩu thành công\nSẽ có hiệu lực sau lần đăng nhập tiếp theo");
                            _changePass.Close();
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!");
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        public void handlerValidatePassOld()
        {
            if (!_changePass.txt_pass_old.Text.Equals(SystemConstant.USER_MEMORY.Password))
            {
                _changePass.lbl_warnChangePass.Text = "Mật khẩu cũ không đúng";
                is_passOldChange = false;
            }
            else
            {
                _changePass.lbl_warnChangePass.Text = "";
                is_passOldChange = true;
            }
        }

        public void handlerValidatePassNew()
        {
            if (!_changePass.txt_pass_check.Text.Equals(_changePass.txt_pass_new.Text))
            {
                _changePass.lbl_validateChangePass.Text = "Nhập lại mật khẩu không đúng";
                is_passNewChange = false;
            }
            else
            {
                _changePass.lbl_validateChangePass.Text = "";
                is_passNewChange = true;
            }
        }

        public void handlerCancelBtn()
        {
            _changePass.Close();
        }

        public void handlerAddAccount()
        {
            try
            {
                if (!_CreateAccount.txt_username.Text.Equals("") && !_CreateAccount.txt_pass.Text.Equals("") && !_CreateAccount.txt_validatePass.Text.Equals("") && !_CreateAccount.txt_fullname.Text.Equals(""))
                {
                    if (is_password && is_username)
                    {
                        try
                        {
                            Int32 CODE_IMG = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                            string path = SystemConstant.PATH_BASE_ACCOUNT + _CreateAccount.txt_tenAnh.Text + CODE_IMG + ".png";
                            _CreateAccount.pb_avatar.Image.Save(path);
                            userRepository.save
                        (
                            _CreateAccount.txt_fullname.Text,
                            _CreateAccount.txt_username.Text,
                            _CreateAccount.txt_tenAnh.Text + CODE_IMG + ".png",
                            _CreateAccount.txt_validatePass.Text
                        );

                            MessageBox.Show("Thêm tài khoản mới thành công");
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void handlerValidateUsername()
        {
            bool k = false;
            foreach (DataRow row in userRepository.find().Rows)
            {
                if (_CreateAccount.txt_username.Text.Equals(row["USERNAME"].ToString()))
                {
                    k = false;
                    break;
                }
                else
                {
                    k = true;
                }
            }
            if (!k)
            {
                _CreateAccount.lbl_validateUsername.Text = "Tên đăng nhập đã được sử dụng";
            }
            else
            {
                _CreateAccount.lbl_validateUsername.Text = "";
                is_username = true;
            }
        }

        public void handlerValidatePassword()
        {
            if (!_CreateAccount.txt_validatePass.Text.Equals(_CreateAccount.txt_pass.Text))
            {
                _CreateAccount.lbl_checkPass.Text = "Nhập lại mật khẩu chưa trùng khớp!";
            }
            else
            {
                _CreateAccount.lbl_checkPass.Text = "";
                is_password = true;
            }
        }

        public void handlerUploadImg()
        {
            OpenFileDialog OFD = new OpenFileDialog();
            //OFD.Title = "Hãy chọn ảnh";
            OFD.Filter = "Hãy chọn ảnh jpg|*.jpg|png|*.png|tất cả ảnh|*.*";   // Lọc ảnh
            if (OFD.ShowDialog() == DialogResult.OK)    //  .OK chứ ko phải .YES
            {
                _MyAcc.pb_avatar.Image = Image.FromFile(OFD.FileName);
                _MyAcc.pb_avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }


        public void loadDataAccDel()
        {
            _CreateAccount.dataGridView_del.DataSource = userRepository.find();
        }

        public void handlerBtnDelete()
        {
            try
            {
                int k = 0;
                DialogResult d = MessageBox.Show("Bạn có muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    k = userRepository.deleteOneById(_CreateAccount.lbl_maTK_del.Text);
                    if (k > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        freeMemory();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                        
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void freeMemory()
        {
            SystemConstant.USER_MEMORY = null;
            _CreateAccount.lbl_maTK_del.Text = "Kích đúp hàng cần xóa";
            _CreateAccount.lbl_username_del.Text = "Kích đúp hàng cần xóa";
        }
    }
}

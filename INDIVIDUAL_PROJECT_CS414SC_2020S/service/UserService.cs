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
            DialogResult d = MessageBox.Show("Bạn có muốn cập nhập thông tin ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                _MyAcc.pb_avatar.Image.Save(SystemConstant.PATH_BASE_ACCOUNT + _MyAcc.txt_avatar.Text);
                userRepository.updateOneFullnameAndAvatarByUsername
                (
                    _MyAcc.txt_fullname.Text,
                    _MyAcc.txt_avatar.Text,
                    SystemConstant.USER_MEMORY.Username
                );
                MessageBox.Show("Cập nhập thông tin thành công\n");
            }
            else return;
        }

        public void validateChangePass()
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
            if (!_CreateAccount.txt_username.Text.Equals("") && !_CreateAccount.txt_pass.Text.Equals("") && !_CreateAccount.txt_validatePass.Text.Equals("") && !_CreateAccount.txt_fullname.Text.Equals(""))
            {
                if (is_password && is_username)
                {
                    try
                    {
                        userRepository.save
                    (
                        _CreateAccount.txt_fullname.Text,
                        _CreateAccount.txt_username.Text,
                        _CreateAccount.txt_validatePass.Text
                    );

                        MessageBox.Show("Thêm tài khoản mới thành công");
                        _CreateAccount.Close();
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
            }
        }
    }
}

using INDIVIDUAL_PROJECT_CS414SC_2020S.GUI;
using INDIVIDUAL_PROJECT_CS414SC_2020S.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S.service
{
    class RoleService
    {

        RoleRepository roleRepository;
        
        frm_accList _AccList;

        public RoleService(frm_accList accList)
        {
            _AccList = accList;
            roleRepository = new RoleRepository();
        }

        public void findUserAndRole()
        {
            _AccList.dataGridView_roleList.DataSource = roleRepository.findUserAndRole();
        }

        public void loadComboBoxUsername()
        {
            _AccList.cb_username.DataSource = roleRepository.findUser();
            _AccList.cb_username.DisplayMember = "USERNAME";
            _AccList.cb_username.ValueMember = "USERNAME";
        }

        public void loadComboBoxRoleCode()
        {
            _AccList.cb_roleCode.DataSource = roleRepository.findRole();
            _AccList.cb_roleCode.DisplayMember = "ROLECODE";
            _AccList.cb_roleCode.ValueMember = "ROLECODE";
        }

        public void handlerBtnAdd()
        {
            int k = roleRepository.save(_AccList.cb_username.Text, _AccList.cb_roleCode.Text);
            if (k == 0)
            {
                MessageBox.Show("Thêm thất bại");
            }
            else
            {
                MessageBox.Show("Thêm thành công");
            }
        }

        public void handlerBtnUpdate()
        {
            int k = roleRepository.updateOneRoleCodedById(_AccList.cb_roleCode.Text, SystemConstant.ROLE_MEMORY.Id);
            if (k == 0)
            {
                MessageBox.Show("Cập nhập thất bại");
            }
            else
            {
                MessageBox.Show("Cập nhập thành công");
                freeMemory();
            }
        }

        public void handlerBtnDelete()
        {
            DialogResult d = MessageBox.Show("Bạn có muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                int k = roleRepository.deleteOne(SystemConstant.ROLE_MEMORY.Id);
                if (k == 0)
                {
                    MessageBox.Show("Xóa thất bại");
                }
                else
                {
                    MessageBox.Show("Xóa thành công");
                    freeMemory();
                }
            }
            else
            {
                return;
            }
        }

        public void freeMemory()
        {
            SystemConstant.ROLE_MEMORY = null;
            _AccList.lbl_maQuyen.Text = "Kích đúp hàng cần sửa hoặc xóa";
        }
    }
}

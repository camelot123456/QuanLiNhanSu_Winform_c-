using INDIVIDUAL_PROJECT_CS414SC_2020S.GUI;
using INDIVIDUAL_PROJECT_CS414SC_2020S.repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S.service
{
    class HRService
    {
        HRRepository hRRepository;
        frm_HR _HR;

        public HRService(frm_HR hR)
        {
            _HR = hR;
            hRRepository = new HRRepository();
        }

        public void handlerLoadData()
        {
            _HR.dataGridView1.DataSource = hRRepository.find();
        }



        public void freeMemory()
        {
            SystemConstant.STAFF_MEMORY = null;
            _HR.lbl_manv.Text = "Kích đúp hàng cần sửa hoặc xóa";
        }

        public int genderToBool(string gender)
        {
            if (gender.Equals("Nam"))
            {
                return 1;
            }
            return 0;
        }

        public void handlerBtnAdd()
        {
            //_HR.dtp_dob.Format("yyyy-MM-dd")
            try
            {
                string path = SystemConstant.PATH_BASE_STAFF + _HR.txt_img.Text + ".png";
                _HR.pb_img.Image.Save(path);
                int k = hRRepository.save(_HR.txt_name.Text, _HR.txt_img.Text + ".png", DateTime.Parse(_HR.dtp_dob.Text), genderToBool(_HR.cb_gender.Text), _HR.cb_department.Text, _HR.cb_typeJob.Text);
                if (k == 0)
                {
                    MessageBox.Show("Thêm thất bại");
                }
                else
                {
                    MessageBox.Show("Thêm thành công");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void handlerBtnUpdate()
        {
            try
            {
                string path = SystemConstant.PATH_BASE_STAFF + _HR.txt_img.Text + ".png";
                _HR.pb_img.Image.Save(path);
                int k = hRRepository.updateOne(_HR.txt_name.Text, _HR.txt_img.Text + ".png", DateTime.Parse(_HR.dtp_dob.Text), genderToBool(_HR.cb_gender.Text), _HR.cb_department.Text, _HR.cb_typeJob.Text, _HR.lbl_manv.Text);
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
            catch (Exception e)
            {

                MessageBox.Show(e.Message);

            }
        }

        public void handlerBtnDelete()
        {
            try
            {
                DialogResult d = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (d == DialogResult.Yes)
                {
                    int k = hRRepository.deleteOne(_HR.lbl_manv.Text);
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void handlerUploadImg()
        {
            OpenFileDialog OFD = new OpenFileDialog();
            //OFD.Title = "Hãy chọn ảnh";
            OFD.Filter = "Hãy chọn ảnh jpg|*.jpg|png|*.png|tất cả ảnh|*.*";   // Lọc ảnh
            if (OFD.ShowDialog() == DialogResult.OK)    //  .OK chứ ko phải .YES
            {
                _HR.pb_img.Image = Image.FromFile(OFD.FileName);
            }
        }
    }
}

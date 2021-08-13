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
                string path = SystemConstant.PATH_BASE_STAFF + _HR.txt_img.Text;
                _HR.pb_img.Image.Save(path);
                int k = hRRepository.save(_HR.txt_name.Text, _HR.txt_img.Text, DateTime.Parse(_HR.dtp_dob.Text), genderToBool(_HR.cb_gender.Text), _HR.cb_department.Text, _HR.cb_typeJob.Text);
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

        internal void handlerBtnUpdate()
        {
            throw new NotImplementedException();
        }

        internal void handlerBtnDelete()
        {
            throw new NotImplementedException();
        }

        internal void handlerBtnRefresh()
        {
            throw new NotImplementedException();
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

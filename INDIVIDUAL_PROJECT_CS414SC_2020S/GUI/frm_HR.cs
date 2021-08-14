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
    public partial class frm_HR : Form
    {

        HRService hRService;

        public frm_HR()
        {
            InitializeComponent();
            hRService = new HRService(this);
        }

        private void frm_HR_Load(object sender, EventArgs e)
        {
            hRService.handlerLoadData();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            hRService.handlerBtnAdd();
            hRService.handlerLoadData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            hRService.handlerBtnUpdate();
            hRService.handlerLoadData();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            hRService.handlerBtnDelete();
            hRService.handlerLoadData();
        }

        private void pb_img_Click(object sender, EventArgs e)
        {
            hRService.handlerUploadImg();
        }

        private void txt_img_Validated(object sender, EventArgs e)
        {
            if (txt_img.Text == "" || txt_img.Text == null)
            {
                lbl_thongBaoImg.Text = "Trường này không được để trống !";
            }
            else
            {
                lbl_thongBaoImg.Text = "";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SystemConstant.STAFF_MEMORY = new models.NhanVien();
            SystemConstant.STAFF_MEMORY.Msnv = dataGridView1.CurrentRow.Cells["MANV"].Value.ToString();
            txt_name.Text = dataGridView1.CurrentRow.Cells["TENNV"].Value.ToString();  // hoặc .Cells[0]  //[chỉ mục]
            txt_img.Text = dataGridView1.CurrentRow.Cells["AVATAR"].Value.ToString();  //   .Cells[1]
            dtp_dob.Text = dataGridView1.CurrentRow.Cells["NGAYVAOLAM"].Value.ToString();
            cb_gender.Text = dataGridView1.CurrentRow.Cells["GIOITINH"].Value.ToString();      //.Cells[3] 
            cb_department.Text = dataGridView1.CurrentRow.Cells["PHONGBAN"].Value.ToString();
            cb_typeJob.Text = dataGridView1.CurrentRow.Cells["LOAICONGVIEC"].Value.ToString();
            pb_img.ImageLocation = SystemConstant.PATH_BASE_STAFF + txt_img.Text;
            pb_img.SizeMode = PictureBoxSizeMode.StretchImage;
            lbl_manv.Text = SystemConstant.STAFF_MEMORY.Msnv;
        }

        private void btn_free_Click(object sender, EventArgs e)
        {
            hRService.freeMemory();
        }
    }
}

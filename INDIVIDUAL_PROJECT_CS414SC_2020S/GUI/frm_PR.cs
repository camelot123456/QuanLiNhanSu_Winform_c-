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
    public partial class frm_PR : Form
    {
        PRService pRService;

        public frm_PR()
        {
            InitializeComponent();
            pRService = new PRService(this);
        }

        private void frm_PR_Load(object sender, EventArgs e)
        {
            pRService.handlerLoadCb_manv_full();
            pRService.handlerLoadCb_manv_part();
            pRService.handlerLoadDataListFull();
            pRService.handlerLoadDataListPart();
        }

        private void btn_add_part_Click(object sender, EventArgs e)
        {
            pRService.handlerBtnAddPart();
            pRService.handlerLoadCb_manv_part();
            pRService.handlerLoadDataListPart();
        }

        private void btn_update_part_Click(object sender, EventArgs e)
        {
            pRService.handlerBtnUpdatePart();
            pRService.handlerLoadCb_manv_part();
            pRService.handlerLoadDataListPart();
        }

        private void btn_del_part_Click(object sender, EventArgs e)
        {
            pRService.handlerBtnDeletePart();
            pRService.handlerLoadCb_manv_part();
            pRService.handlerLoadDataListPart();
        }

        private void btn_free_part_Click(object sender, EventArgs e)
        {
            pRService.freeMemory();
        }

        private void dataGridView_part_DoubleClick(object sender, EventArgs e)
        {
            SystemConstant.LUONG_MEMORY = new models.Luong();
            SystemConstant.LUONG_MEMORY.MaLuong = dataGridView_part.CurrentRow.Cells["MALUONG"].Value.ToString();
            txt_luong1gio.Text = dataGridView_part.CurrentRow.Cells["LUONG1GIO"].Value.ToString(); 
            txt_songay_part.Text = dataGridView_part.CurrentRow.Cells["SONGAYLAM"].Value.ToString();
            txt_sogio.Text = dataGridView_part.CurrentRow.Cells["SOGIOLAM"].Value.ToString();
            txt_luongThuong_part.Text = dataGridView_part.CurrentRow.Cells["LUONGTHUONG"].Value.ToString();
            lbl_maluong_part.Text = SystemConstant.LUONG_MEMORY.MaLuong;
            pb_img_part.ImageLocation = SystemConstant.PATH_BASE_STAFF + dataGridView_part.CurrentRow.Cells["AVATAR"].Value.ToString();
            pb_img_part.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pb_img_part_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_full_Click(object sender, EventArgs e)
        {
            pRService.handlerBtnAddFull();
            pRService.handlerLoadCb_manv_full();
            pRService.handlerLoadDataListFull();
        }

        private void btn_update_full_Click(object sender, EventArgs e)
        {
            pRService.handlerBtnUpdateFull();
            pRService.handlerLoadCb_manv_full();
            pRService.handlerLoadDataListFull();
        }

        private void btn_del_full_Click(object sender, EventArgs e)
        {
            pRService.handlerBtnDeleteFull();
            pRService.handlerLoadCb_manv_full();
            pRService.handlerLoadDataListFull();
        }

        private void btn_free_full_Click(object sender, EventArgs e)
        {
            pRService.freeMemory();
        }

        private void dataGridView_full_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SystemConstant.LUONG_MEMORY = new models.Luong();
            SystemConstant.LUONG_MEMORY.MaLuong = dataGridView_full.CurrentRow.Cells["MALUONG"].Value.ToString();
            txt_luongcb.Text = dataGridView_full.CurrentRow.Cells["LUONGCOBAN"].Value.ToString();  // hoặc .Cells[0]  //[chỉ mục]
            txt_hesl.Text = dataGridView_full.CurrentRow.Cells["HESOLUONG"].Value.ToString();  //   .Cells[1]
            txt_luong1ngay.Text = dataGridView_full.CurrentRow.Cells["LUONG1NGAY"].Value.ToString();
            txt_songay.Text = dataGridView_full.CurrentRow.Cells["SONGAYLAM"].Value.ToString();
            txt_luongThuong_full.Text = dataGridView_full.CurrentRow.Cells["LUONGTHUONG"].Value.ToString();
            pb_img_full.ImageLocation = SystemConstant.PATH_BASE_STAFF + dataGridView_part.CurrentRow.Cells["AVATAR"].Value.ToString();
            pb_img_full.SizeMode = PictureBoxSizeMode.StretchImage;
            lbl_maluong_full.Text = SystemConstant.LUONG_MEMORY.MaLuong;
        }
    }
}

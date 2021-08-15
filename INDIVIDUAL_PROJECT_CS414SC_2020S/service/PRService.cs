using INDIVIDUAL_PROJECT_CS414SC_2020S.GUI;
using INDIVIDUAL_PROJECT_CS414SC_2020S.repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S.service
{
    class PRService
    {

        PRRepository pRRepository;
        frm_PR _PR;

        public PRService(frm_PR pR)
        {
            _PR = pR;
            pRRepository = new PRRepository();
        }

        public void freeMemory()
        {
            SystemConstant.LUONG_MEMORY = null;
            _PR.lbl_maluong_full.Text = "Kích đúp hàng cần sửa hoặc xóa";
            _PR.lbl_maluong_part.Text = "Kích đúp hàng cần sửa hoặc xóa";
        }
        

        public void handlerUploadImg()
        {
            OpenFileDialog OFD = new OpenFileDialog();
            //OFD.Title = "Hãy chọn ảnh";
            OFD.Filter = "Hãy chọn ảnh jpg|*.jpg|png|*.png|tất cả ảnh|*.*";   // Lọc ảnh
            if (OFD.ShowDialog() == DialogResult.OK)    //  .OK chứ ko phải .YES
            {
                _PR.pb_img_part.Image = Image.FromFile(OFD.FileName);
            }
        }

        public void handlerLoadCb_manv_full()
        {
            _PR.cb_nhanvien_full.DataSource = pRRepository.findIdOfNhanVienByTypeJob("Fulltime");
            _PR.cb_nhanvien_full.DisplayMember = "MANV";
            _PR.cb_nhanvien_full.ValueMember = "MANV";
        }

        public void handlerLoadCb_manv_part()
        {
            _PR.cb_nhanvien_part.DataSource = pRRepository.findIdOfNhanVienByTypeJob("Parttime");
            _PR.cb_nhanvien_part.DisplayMember = "MANV";
            _PR.cb_nhanvien_part.ValueMember = "MANV";
        }

        public void handlerLoadDataListFull()
        {
            _PR.dataGridView_full.DataSource = pRRepository.getLuongByTypeJobIsFulltime();
        }

        public void handlerLoadDataListPart()
        {
            _PR.dataGridView_part.DataSource = pRRepository.getLuongByTypeJobIsParttime();
        }

        public double getThanhLuongFull(double lcb, double hsl, double l1n, double sn, double lt)
        {
            if (lcb > 28)
            {
                return lcb * hsl + (l1n * sn) + lt;
            }
            else
            {
                return lcb * hsl + (l1n * sn);
            }
        }

        public void handlerBtnAddFull()
        {
            try
            {
                int k = pRRepository.saveByFull
                    (
                        Convert.ToDouble(_PR.txt_luongcb.Text),
                        Convert.ToDouble(_PR.txt_hesl.Text),
                        Convert.ToDouble(_PR.txt_luong1ngay.Text),
                        Convert.ToDouble(_PR.txt_songay.Text),
                        Convert.ToDouble(_PR.txt_luongThuong_full.Text),
                        getThanhLuongFull(Convert.ToDouble(_PR.txt_luongcb.Text), Convert.ToDouble(_PR.txt_hesl.Text), Convert.ToDouble(_PR.txt_luong1ngay.Text), Convert.ToDouble(_PR.txt_songay.Text), Convert.ToDouble(_PR.txt_luongThuong_full.Text)),
                        Convert.ToInt32(_PR.cb_nhanvien_full.SelectedValue.ToString())
                    );
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

        public void handlerBtnUpdateFull()
        {
            try
            {
                int k = pRRepository.updateOneByFull
                    (
                        Convert.ToDouble(_PR.txt_luongcb.Text),
                        Convert.ToDouble(_PR.txt_hesl.Text),
                        Convert.ToDouble(_PR.txt_luong1ngay.Text),
                        Convert.ToDouble(_PR.txt_songay.Text),
                        Convert.ToDouble(_PR.txt_luongThuong_full.Text),
                        getThanhLuongFull(Convert.ToDouble(_PR.txt_luongcb.Text), Convert.ToDouble(_PR.txt_hesl.Text), Convert.ToDouble(_PR.txt_luong1ngay.Text), Convert.ToDouble(_PR.txt_songay.Text), Convert.ToDouble(_PR.txt_luongThuong_full.Text)),
                        _PR.lbl_maluong_full.Text
                    );
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

        public double getThanhLuongPart(double l1g, double sn, double sg, double lt)
        {
            if ((sg*sn) > 210)
            {
                return ((l1g * sg) * sn) + lt;
            }
            else
            {
                return (l1g * sg) * sn;
            }
        }

        public void handlerBtnAddPart()
        {
            try
            {
                int k = pRRepository.saveByPart
                    (
                        Convert.ToDouble(_PR.txt_luong1gio.Text),
                        Convert.ToDouble(_PR.txt_songay_part.Text),
                        Convert.ToDouble(_PR.txt_sogio.Text),
                        Convert.ToDouble(_PR.txt_luongThuong_part.Text),
                        getThanhLuongPart(Convert.ToDouble(_PR.txt_luong1gio.Text), Convert.ToDouble(_PR.txt_songay_part.Text), Convert.ToDouble(_PR.txt_sogio.Text), Convert.ToDouble(_PR.txt_luongThuong_part.Text)),
                        Convert.ToInt32(_PR.cb_nhanvien_part.SelectedValue.ToString())
                    );
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

        public void handlerBtnUpdatePart()
        {
            try
            {
                int k = pRRepository.updateOneByPart
                    (
                        Convert.ToDouble(_PR.txt_luong1gio.Text),
                        Convert.ToDouble(_PR.txt_songay_part.Text),
                        Convert.ToDouble(_PR.txt_sogio.Text),
                        Convert.ToDouble(_PR.txt_luongThuong_part.Text),
                        getThanhLuongPart(Convert.ToDouble(_PR.txt_luong1gio.Text), Convert.ToDouble(_PR.txt_songay_part.Text), Convert.ToDouble(_PR.txt_sogio.Text), Convert.ToDouble(_PR.txt_luongThuong_part.Text)),
                        _PR.lbl_maluong_part.Text
                    );
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

        public void handlerBtnDeleteFull()
        {
            try
            {
                DialogResult d = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (d == DialogResult.Yes)
                {

                    int k = pRRepository.deleteOne(_PR.lbl_maluong_full.Text);
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

        public void handlerBtnDeletePart()
        {
            try
            {
                DialogResult d = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (d == DialogResult.Yes)
                {

                    int k = pRRepository.deleteOne(_PR.lbl_maluong_part.Text);
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
    }
}

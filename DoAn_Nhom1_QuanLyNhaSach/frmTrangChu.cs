using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Nhom1_QuanLyNhaSach
{
    public partial class frmTrangChu : Form
    {
        DBConnect db = new DBConnect();
        private string username;
        private string role;
        public frmTrangChu(string username, string role)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            ToggleSidebar();
        }

        private const int SidebarMinWidth = 50; 
        private const int SidebarMaxWidth = 205; 

        private void ToggleSidebar()
        {
            if (panelSidebar.Width > SidebarMinWidth)
            {
               
                panelSidebar.Width = SidebarMinWidth;
            }
            else
            {
                
                panelSidebar.Width = SidebarMaxWidth;
            }

            AdjustFormSize(); 
        }


        private void AdjustFormSize()
        {
            foreach (Form frm in this.Controls.OfType<Form>())
            {
               
                frm.Location = new Point(panelSidebar.Width, frm.Location.Y);
                frm.Width = this.ClientSize.Width - panelSidebar.Width;
                frm.Height = this.ClientSize.Height; 
            }
        }

        private void container(object _form)
        {

            if (Panel_container.Controls.Count > 0) Panel_container.Controls.Clear();

            Form frm = _form as Form;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            Panel_container.Controls.Add(frm);
            Panel_container.Tag = frm;
            frm.Show();

        }

        private void btnQL_SanPham_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ SẢN PHẨM";
            container(new frmSanPham());
        }

        private void btnQL_PhieuNhap_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ PHIẾU NHẬP";
            container(new frmPhieuNhap());
        }

        private void btnQL_TheLoai_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ THỂ LOẠI";
            container(new frmTheLoai());
        }

        private void btnQL_HoaDon_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ HOÁ ĐƠN";
            container(new frmHoaDon());
        }

        private void btnNhaPhanPhoi_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ NHÀ PHÂN PHỐI";
            container(new frmNhaPhanPhoi());
        }

        private void btnQL_TacGia_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ TÁC GIẢ";
            container(new frmTacGia());
        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "QUẢN LÝ CHI TIẾT HOÁ ĐƠN";
            container(new frmChiTietHoaDon());
        }

        //private void btnChiTietPhieuNhap_Click(object sender, EventArgs e)
        //{
        //    labelTitleFrm.Text = "QUẢN LÝ CHI TIẾT PHIẾU NHẬP";
        //    container(new frmChiTietPhieuNhap());
        //}

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            ShadowForm1.SetShadowForm(this);
            btnTrangChu_Click(sender, e);

            if (role == "Admin")
            {
                lblQuyen.Text = "Quản trị viên";
            }
            else if (role == "NhanVien")
            {
                lblQuyen.Text = "Nhân viên";
            }
            lblTenUser.Text = username;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "TRANG CHỦ";
            container(new frmPoster());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "ĐỔI MẬT KHẨU";
            container(new frmDoiMatKhau(role));
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "THỐNG KÊ";
            container(new frmThongKe());
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            labelTitleFrm.Text = "BÁN HÀNG";
            container(new frmBanHang());
        }
    }
}

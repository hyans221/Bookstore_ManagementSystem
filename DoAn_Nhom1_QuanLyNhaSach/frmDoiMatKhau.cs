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
    public partial class frmDoiMatKhau : Form
    {
        DBConnect dbConnect = new DBConnect();
        private string userRole;
        public frmDoiMatKhau(string role)
        {
            InitializeComponent();
            userRole = role;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhauCu = txtMatKhauCu.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string xacNhanMatKhau = txtXacNhanMatKhau.Text;

            if (userRole != "Admin")
            {
                MessageBox.Show("Bạn không có quyền đổi mật khẩu của Admin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsUsernameExists(tenDangNhap))
            {
                MessageBox.Show("Tên đăng nhập không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (matKhauMoi != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsPasswordCorrect(tenDangNhap, matKhauCu))
            {
                MessageBox.Show("Mật khẩu cũ không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = $"UPDATE TAIKHOAN SET MatKhau = '{matKhauMoi}' WHERE TenDangNhap = '{tenDangNhap}'";
            dbConnect.getNonQuery(sql);
            MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm();
        }

        private void OpenChangePasswordForm()
        {
            string userRole = GetUserRole(txtTenDangNhap.Text);

            frmDoiMatKhau changePasswordForm = new frmDoiMatKhau(userRole);
            changePasswordForm.ShowDialog();
        }

        private string GetUserRole(string tenDangNhap)
        {
            string sql = $"SELECT Quyen FROM TAIKHOAN WHERE TenDangNhap = '{tenDangNhap}'";
            string userRole = dbConnect.getScalar(sql)?.ToString();
            return userRole;
        }

        private bool IsPasswordCorrect(string tenDangNhap, string matKhau)
        {
            string sql = $"SELECT MatKhau FROM TAIKHOAN WHERE TenDangNhap = '{tenDangNhap}'";
            string currentPassword = dbConnect.getScalar(sql).ToString();
            return matKhau == currentPassword;
        }

        private bool IsUsernameExists(string tenDangNhap)
        {
            string sql = $"SELECT COUNT(*) FROM TAIKHOAN WHERE TenDangNhap = '{tenDangNhap}'";
            int count = Convert.ToInt32(dbConnect.getScalar(sql));
            return count > 0;
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhauCu.UseSystemPasswordChar = !chkShowPass.Checked;
            txtMatKhauMoi.UseSystemPasswordChar = !chkShowPass.Checked;
            txtXacNhanMatKhau.UseSystemPasswordChar = !chkShowPass.Checked;
        }

        private bool IsAdmin(string tenDangNhap)
        {
            string sql = $"SELECT Quyen FROM TAIKHOAN WHERE TenDangNhap = '{tenDangNhap}'";
            string quyen = dbConnect.getScalar(sql).ToString();
            return quyen == "admin"; 
        }

        private void ResetForm()
        {
            txtTenDangNhap.Clear();
            txtMatKhauCu.Clear();
            txtMatKhauMoi.Clear();
            txtXacNhanMatKhau.Clear();
        }
    }
}

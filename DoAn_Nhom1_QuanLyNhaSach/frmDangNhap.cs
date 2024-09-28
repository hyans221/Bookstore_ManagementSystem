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
    public partial class frmDangNhap : Form
    {
        DBConnect dbConnect = new DBConnect();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text; 

            string sql = $"SELECT Quyen FROM TAIKHOAN WHERE TenDangNhap = '{username}' AND MatKhau = '{password}'";
            object result = dbConnect.getScalar(sql);

            if (result != null)
            {
                this.Hide();

                string role = result.ToString();

                if (role == "Admin")
                {
                    frmAdmin adminForm = new frmAdmin(username, role);
                    adminForm.FormClosed += (s, args) => this.Show();
                    adminForm.Show();
                }
                else if (role == "NhanVien")
                {
                    frmTrangChu homeForm = new frmTrangChu(username, role);
                    homeForm.FormClosed += (s, args) => this.Show();
                    homeForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
        }

        private void lblMaTheLoai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuenMatKhau frmQuenMatKhau = new frmQuenMatKhau();
            frmQuenMatKhau.FormClosed += (s, args) => this.Show();
            frmQuenMatKhau.Show();
        }
    }
}

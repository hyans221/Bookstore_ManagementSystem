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
    public partial class frmTaiKhoan : Form
    {
        DBConnect dbConnect = new DBConnect();
        public frmTaiKhoan()
        {
            InitializeComponent();
            LoadTaiKhoanData();
            LoadMaNVData();
            LoadQuyen();
        }

        private void LoadTaiKhoanData()
        {
            string sql = "SELECT * FROM TAIKHOAN";
            DataTable dt = dbConnect.getDatatable(sql);
            dgvTaiKhoan.DataSource = dt;
        }

        private void LoadQuyen()
        {
            cmbQuyen.Items.Clear();
            cmbQuyen.Items.Add("Admin");
            cmbQuyen.Items.Add("NhanVien");
        }

        private void LoadMaNVData()
        {
            string sql = "SELECT MaNV FROM NHANVIEN";
            DataTable dt = dbConnect.getDatatable(sql);
            cmbMaNV.DataSource = dt;
            cmbMaNV.DisplayMember = "MaNV";
            cmbMaNV.ValueMember = "MaNV";
            cmbMaNV.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maTK = txtMaTaiKhoan.Text;
            string maNV = cmbMaNV.SelectedValue.ToString();

            if (IsAccountExist(maTK, maNV))
            {
                MessageBox.Show("Tài khoản hoặc Mã nhân viên đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tenDN = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            string quyen = cmbQuyen.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(tenDN) || string.IsNullOrWhiteSpace(matKhau) || string.IsNullOrWhiteSpace(quyen))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsPasswordValid(matKhau))
            {
                MessageBox.Show("Mật khẩu phải bao gồm chữ cái, chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsUsernameExist(tenDN))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = $"INSERT INTO TAIKHOAN (MaTK, MaNV, TenDangNhap, MatKhau, Quyen) VALUES ('{maTK}', '{maNV}', '{tenDN}', '{matKhau}', '{quyen}')";
            dbConnect.getNonQuery(sql);
            LoadTaiKhoanData();
            ResetFormControls();
        }

        private bool IsAccountExist(string maTK, string maNV)
        {
            string sql = $"SELECT COUNT(*) FROM TAIKHOAN WHERE MaTK = '{maTK}' OR MaNV = '{maNV}'";
            int count = Convert.ToInt32(dbConnect.getScalar(sql));
            return count > 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maTK = txtMaTaiKhoan.Text;
            string sql = $"DELETE FROM TAIKHOAN WHERE MaTK = '{maTK}'";
            dbConnect.getNonQuery(sql);
            LoadTaiKhoanData();
            ResetFormControls();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maTK = txtMaTaiKhoan.Text;
            string maNV = cmbMaNV.SelectedValue?.ToString();
            string tenDN = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            string quyen = cmbQuyen.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(maNV) || string.IsNullOrWhiteSpace(tenDN) || string.IsNullOrWhiteSpace(matKhau) || string.IsNullOrWhiteSpace(quyen))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsPasswordValid(matKhau))
            {
                MessageBox.Show("Mật khẩu phải bao gồm chữ cái, chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsUsernameExist(tenDN))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = $"UPDATE TAIKHOAN SET MaNV = '{maNV}', TenDangNhap = '{tenDN}', MatKhau = '{matKhau}', Quyen = '{quyen}' WHERE MaTK = '{maTK}'";
            dbConnect.getNonQuery(sql);
            LoadTaiKhoanData();
            ResetFormControls();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];
                txtMaTaiKhoan.Text = row.Cells["MaTK"].Value.ToString();
                cmbMaNV.SelectedValue = row.Cells["MaNV"].Value.ToString();
                txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();

                string quyen = row.Cells["Quyen"].Value.ToString();
                cmbQuyen.SelectedItem = quyen;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void ResetFormControls()
        {
            txtMaTaiKhoan.Clear();
            cmbMaNV.SelectedIndex = -1;
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cmbQuyen.SelectedIndex = -1;
        }

        private bool IsUsernameExist(string tenDN)
        {
            string sql = $"SELECT COUNT(*) FROM TAIKHOAN WHERE TenDangNhap = '{tenDN}'";
            int count = Convert.ToInt32(dbConnect.getScalar(sql));
            return count > 0;
        }

        private bool IsPasswordValid(string password)
        {
            return password.Any(char.IsLetter) && password.Any(char.IsDigit);
        }

    }
}

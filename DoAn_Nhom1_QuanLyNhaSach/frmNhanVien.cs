using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Nhom1_QuanLyNhaSach
{
    public partial class frmNhanVien : Form
    {
        DBConnect dbConnect = new DBConnect();
        public frmNhanVien()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string sql = "SELECT * FROM NHANVIEN";
            DataTable dt = dbConnect.getDatatable(sql);
            dgvNhanVien.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string tenNV = txtTenNV.Text;
            string diaChi = txtDiaChi.Text;
            string email = txtEmail.Text;

            if (CheckMaNhanVienUnique(maNV))
            {
                string sql = $"INSERT INTO NHANVIEN (MaNV, TenNV, DiaChi, Email) VALUES ('{maNV}', N'{tenNV}', N'{diaChi}', '{email}')";
                int result = dbConnect.getNonQuery(sql);

                if (result > 0)
                {
                    MessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ResetFormControls();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string sql = $"DELETE FROM NHANVIEN WHERE MaNV = '{maNV}'";
            int result = dbConnect.getNonQuery(sql);

            if (result > 0)
            {
                MessageBox.Show("Xoá nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Xoá nhân viên thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string tenNV = txtTenNV.Text;
            string diaChi = txtDiaChi.Text;
            string email = txtEmail.Text;


            string sql = $"UPDATE NHANVIEN SET TenNV = N'{tenNV}', DiaChi = N'{diaChi}', Email = '{email}' WHERE MaNV = '{maNV}'";
            int result = dbConnect.getNonQuery(sql);

            if (result > 0)
            {
                MessageBox.Show("Sửa thông tin nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Sửa thông tin nhân viên thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null)
            {
                txtMaNV.Text = dgvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
                txtTenNV.Text = dgvNhanVien.CurrentRow.Cells["TenNV"].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
                txtEmail.Text = dgvNhanVien.CurrentRow.Cells["Email"].Value.ToString();
            }
        }

        private bool CheckMaNhanVienUnique(string maNV)
        {
            string sql = $"SELECT COUNT(*) FROM NHANVIEN WHERE MaNV = '{maNV}'";
            int count = Convert.ToInt32(dbConnect.getScalar(sql));
            return count == 0;
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void ResetFormControls()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
        }

        //private bool CheckTenNhanVienUniqueUpdate(string maNV, string tenNV)
        //{
        //    string sql = $"SELECT COUNT(*) FROM NHANVIEN WHERE MaNV != '{maNV}' AND TenNV = N'{tenNV}'";
        //    int count = Convert.ToInt32(dbConnect.getScalar(sql));
        //    return count == 0;
        //}
    }
}

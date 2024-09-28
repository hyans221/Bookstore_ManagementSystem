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
    public partial class frmNhaPhanPhoi : Form
    {
        DBConnect db = new DBConnect();

        public frmNhaPhanPhoi()
        {
            InitializeComponent();
            LoadDatagridview();
            dgvNhaPhanPhoi.CellClick += dgvNhaPhanPhoi_CellClick;
        }

        public void LoadDatagridview()
        {
            string sql = "Select *from NhaPhanPhoi";
            DataTable data = db.getDatatable(sql);
            dgvNhaPhanPhoi.DataSource = data;
        }

        private bool kiemtra(string manpp)
        {
            string sql = "SELECT COUNT(*) FROM NHAPHANPHOI WHERE MANPP='" + manpp + "'";
            int dem = (int)db.getScalar(sql);
            if (dem == 0)
            {
                return true;
            }
            return false;
        }

        private bool KiemTra(string manpp)
        {
            string sql = $"SELECT COUNT(*) FROM NHAPHANPHOI WHERE MANPP = '{manpp}'";
            int dem = (int)db.getScalar(sql);
            return dem == 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string manpp = txtMaNPP.Text;
            string tennpp = txtTenNPP.Text;
            string diachi = txtDiaChi.Text;

            if (KiemTra(txtMaNPP.Text))
            {
                string sql = $"INSERT INTO NhaPhanPhoi(MaNPP, TenNPP, DiaChi) VALUES('{manpp}', N'{tennpp}', N'{diachi}')";
                int result = db.getNonQuery(sql);

                if (result > 0)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDatagridview();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Đã có nhà phân phối này rồi không thêm được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM NhaPhanPhoi WHERE MaNPP = '{txtMaNPP.Text}'";
            int result = db.getNonQuery(sql);

            if (result > 0)
            {
                MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDatagridview();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Xoá thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE NhaPhanPhoi SET TenNPP = N'{txtTenNPP.Text}', DiaChi = N'{txtDiaChi.Text}' WHERE MaNPP = '{txtMaNPP.Text}'";
            int result = db.getNonQuery(sql);

            if (result > 0)
            {
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDatagridview();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNhaPhanPhoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvNhaPhanPhoi.Rows[e.RowIndex];

                txtMaNPP.Text = row.Cells["MaNPP"].Value.ToString();
                txtTenNPP.Text = row.Cells["TenNPP"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtMaNPP.Clear();
            txtTenNPP.Clear();
            txtDiaChi.Clear();
        }
    }
}

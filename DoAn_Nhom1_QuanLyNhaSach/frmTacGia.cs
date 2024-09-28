using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Nhom1_QuanLyNhaSach
{
    public partial class frmTacGia : Form
    {
        DBConnect dBConnect = new DBConnect();
        private string maTG;
        private string tenTG;
        private string diaChi;

        public frmTacGia()
        {
            InitializeComponent();
        }

        private bool kiemTraTrungKhoa(string maTG)
        {
            string query = "SELECT COUNT(*) FROM TACGIA WHERE MaTacGia = @MaTacGia";
            using (SqlConnection connection = new SqlConnection(@"Data Source = THY; Initial Catalog = DB_QL_NHASACH_NHOM1; User ID = sa; Password = sa"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaTacGia", txtMaTG.Text);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        private bool IsNameValid(string name)
        {
            return !name.Any(char.IsDigit);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTG.Text) || string.IsNullOrWhiteSpace(txtTenTG.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (!IsNameValid(txtTenTG.Text))
            {
                MessageBox.Show("Tên tác giả không được chứa số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (kiemTraTrungKhoa(maTG))
            {
                MessageBox.Show("Mã loại đã tồn tại. Vui lòng nhập mã loại khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            StringBuilder query = new StringBuilder("EXEC proc_ThemTacGia ");
            query.Append("@maTG = N'" + txtMaTG.Text + "', ");
            query.Append("@tenTG = N'" + txtTenTG.Text + "', ");
            query.Append("@diaChi = N'" + txtDiaChi.Text + "'");
            int result = dBConnect.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadTacGia();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Thêm loại sách không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn Xóa tác giả " + txtTenTG.Text + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (check == DialogResult.Yes)
            {
                string query = "DELETE FROM TACGIA WHERE MaTacGia = @MaTacGia";

                using (SqlConnection connection = new SqlConnection(@"Data Source = THY; Initial Catalog = DB_QL_NHASACH_NHOM1; User ID = sa; Password = sa"))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaTacGia", txtMaTG.Text);

                    connection.Open();

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        loadTacGia();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Xóa tác giả không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTG.Text) || string.IsNullOrWhiteSpace(txtTenTG.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (!IsNameValid(txtTenTG.Text))
            {
                MessageBox.Show("Tên tác giả không được chứa số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            StringBuilder query = new StringBuilder("EXEC proc_CapNhatTacGia ");
            query.Append("@maTG = N'" + txtMaTG.Text + "', ");
            query.Append("@tenTG = N'" + txtTenTG.Text + "', ");
            query.Append("@diaChi = N'" + txtDiaChi.Text + "'");
            int result = dBConnect.execNonQuery(query.ToString());
            if (result > 0)
            {
                loadTacGia();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Cập nhật loại sản phẩm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            lblMaTG.Text = "Mã tác giả";
            lblTenTG.Text = "Tên tác giả";
            lblDiaChi.Text = "Địa chỉ";
            loadTacGia();
        }
        public void loadTacGia()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("SELECT MaTacGia as [Mã tác giả]");
            query.Append(",TenTacGia as [Tên tác giả]");
            query.Append(",DiaChi as [Địa chỉ]");
            query.Append("FROM TACGIA");
            dt = dBConnect.execQuery(query.ToString());
            dgvTacGia.DataSource = dt;
        }

        private void dgvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTacGia.Rows[e.RowIndex];
                txtMaTG.Text = row.Cells[0].Value.ToString();
                txtTenTG.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtMaTG.Clear();
            txtTenTG.Clear();
            txtDiaChi.Clear();
        }

    }
}

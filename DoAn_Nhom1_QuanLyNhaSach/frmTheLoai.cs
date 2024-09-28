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
    public partial class frmTheLoai : Form
    {
        DBConnect dBConnect = new DBConnect();

        private string maLoai;
        private string tenLoai;
        public frmTheLoai()
        {
            InitializeComponent();
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            lblMaTheLoai.Text = "Mã thể loại";
            lblTenTheLoai.Text = "Thể loại";
            loadTheLoai();
        }
        public void loadTheLoai()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("SELECT MaLoai as [Mã thể loại]");
            query.Append(",TenLoai as [Thể loại]");
            query.Append("FROM THELOAISANPHAM");
            dt = dBConnect.execQuery(query.ToString());
            dgvTheLoai.DataSource = dt;
        }
        private void dgvTheLoai_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTheLoai.Rows[e.RowIndex];
                txtMaTL.Text = row.Cells[0].Value.ToString();
                txtTL.Text = row.Cells[1].Value.ToString();
            }

        }
        private void loadAll()
        {
            loadTheLoai();
        }
        private bool kiemTraTrungKhoa(string maLoai)
        {
            string query = "SELECT COUNT(*) FROM THELOAISANPHAM WHERE MaLoai = @MaLoai";
            using (SqlConnection connection = new SqlConnection(@"Data Source = THY; Initial Catalog = DB_QL_NHASACH_NHOM1; User ID = sa; Password = sa"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaLoai", txtMaTL.Text);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTL.Text) || string.IsNullOrWhiteSpace(txtTL.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (kiemTraTrungKhoa(maLoai))
            {
                MessageBox.Show("Mã loại đã tồn tại. Vui lòng nhập mã loại khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            StringBuilder query = new StringBuilder("EXEC proc_ThemTheLoai ");
            query.Append("@maLoai = N'" + txtMaTL.Text + "', ");
            query.Append("@tenLoai = N'" + txtTL.Text + "'");
            int result = dBConnect.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadAll();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Thêm loại sách không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa loại sản phẩm " + txtTL.Text + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (check == DialogResult.Yes)
            {
                string query = "DELETE FROM THELOAISANPHAM WHERE MaLoai = @MaLoai";

                using (SqlConnection connection = new SqlConnection(@"Data Source = THY; Initial Catalog = DB_QL_NHASACH_NHOM1; User ID = sa; Password = sa"))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaLoai", txtMaTL.Text);

                    connection.Open();

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        loadTheLoai();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Xóa loại sản phẩm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTL.Text) || string.IsNullOrWhiteSpace(txtTL.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            StringBuilder query = new StringBuilder("EXEC proc_CapNhatLoaiSach ");
            query.Append("@maLoai = N'" + txtMaTL.Text + "', ");
            query.Append("@tenLoai = N'" + txtTL.Text + "'");
            int result = dBConnect.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadAll();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Cập nhật loại sản phẩm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtMaTL.Clear();
            txtTL.Clear();
        }
    }
}

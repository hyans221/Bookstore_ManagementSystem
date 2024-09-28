using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using System.Net;

namespace DoAn_Nhom1_QuanLyNhaSach
{
    public partial class frmQuenMatKhau : Form
    {
        DBConnect dbConnect = new DBConnect();
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string username = txtTenDangNhap.Text;
            string sql = $"SELECT * FROM TAIKHOAN TK JOIN NHANVIEN NV ON TK.MaNV = NV.MaNV WHERE TK.TenDangNhap = '{username}' AND NV.Email = '{email}'";
            DataTable dt = dbConnect.getDatatable(sql);

            if (dt.Rows.Count > 0)
            {
                string newPassword = GenerateRandomPassword(8);
                string maNhanVien = dt.Rows[0]["MaNV"].ToString();

                sql = $"UPDATE TAIKHOAN SET MatKhau = '{newPassword}' WHERE MaNV = '{maNhanVien}'";
                dbConnect.execQuery(sql);

                SendEmail(email, username, newPassword);
                MessageBox.Show("Mật khẩu mới đã được gửi đến email của bạn.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Email hoặc tên đăng nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateRandomPassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }
            return res.ToString();
        }


        private void SendEmail(string email, string username, string password)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Nhà sách SERENETY", "serenety221@gmail.com"));
            message.To.Add(new MailboxAddress("", email));
            message.Subject = "Quên mật khẩu";

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = $"Xin chào {username},\nMật khẩu mới của bạn là: {password}\nVui lòng đăng nhập lại và đổi mật khẩu.\nTrân trọng,\nNhà sách SERENETY.";
            message.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect("smtp-mail.outlook.com", 587, SecureSocketOptions.StartTls);

                    client.Authenticate(new NetworkCredential("serenety221@gmail.com", "matkhaupassword12345"));
                    client.Send(message);
                    client.Disconnect(true);

                    MessageBox.Show("Email đã gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

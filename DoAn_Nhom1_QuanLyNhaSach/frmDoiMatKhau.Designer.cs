namespace DoAn_Nhom1_QuanLyNhaSach
{
    partial class frmDoiMatKhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.chkShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnXacNhan = new Guna.UI2.WinForms.Guna2Button();
            this.txtMatKhauMoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMatKhauCu = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMatKhauMoi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTenDangNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMatKhauCu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtXacNhanMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenDangNhap = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblXacNhanMatKhau = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.ShadowDecoration.Parent = this.Panel1;
            this.Panel1.Size = new System.Drawing.Size(747, 554);
            this.Panel1.TabIndex = 0;
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.Controls.Add(this.chkShowPass);
            this.Panel2.Controls.Add(this.btnXacNhan);
            this.Panel2.Controls.Add(this.txtMatKhauMoi);
            this.Panel2.Controls.Add(this.txtMatKhauCu);
            this.Panel2.Controls.Add(this.lblMatKhauMoi);
            this.Panel2.Controls.Add(this.txtTenDangNhap);
            this.Panel2.Controls.Add(this.lblMatKhauCu);
            this.Panel2.Controls.Add(this.txtXacNhanMatKhau);
            this.Panel2.Controls.Add(this.lblTenDangNhap);
            this.Panel2.Controls.Add(this.lblXacNhanMatKhau);
            this.Panel2.Location = new System.Drawing.Point(53, 12);
            this.Panel2.Name = "Panel2";
            this.Panel2.ShadowDecoration.Parent = this.Panel2;
            this.Panel2.Size = new System.Drawing.Size(642, 530);
            this.Panel2.TabIndex = 0;
            // 
            // chkShowPass
            // 
            this.chkShowPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowPass.AutoSize = true;
            this.chkShowPass.CheckedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.chkShowPass.CheckedState.BorderRadius = 0;
            this.chkShowPass.CheckedState.BorderThickness = 0;
            this.chkShowPass.CheckedState.FillColor = System.Drawing.Color.SteelBlue;
            this.chkShowPass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPass.Location = new System.Drawing.Point(419, 304);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(102, 19);
            this.chkShowPass.TabIndex = 86;
            this.chkShowPass.Text = "Hiện mật khẩu";
            this.chkShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkShowPass.UncheckedState.BorderRadius = 0;
            this.chkShowPass.UncheckedState.BorderThickness = 0;
            this.chkShowPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacNhan.BorderRadius = 12;
            this.btnXacNhan.CheckedState.Parent = this.btnXacNhan;
            this.btnXacNhan.CustomImages.Parent = this.btnXacNhan;
            this.btnXacNhan.FillColor = System.Drawing.Color.Firebrick;
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.HoverState.Parent = this.btnXacNhan;
            this.btnXacNhan.Location = new System.Drawing.Point(280, 367);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.ShadowDecoration.Parent = this.btnXacNhan;
            this.btnXacNhan.Size = new System.Drawing.Size(169, 38);
            this.btnXacNhan.TabIndex = 85;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatKhauMoi.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtMatKhauMoi.BorderRadius = 10;
            this.txtMatKhauMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhauMoi.DefaultText = "";
            this.txtMatKhauMoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhauMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhauMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhauMoi.DisabledState.Parent = this.txtMatKhauMoi;
            this.txtMatKhauMoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhauMoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhauMoi.FocusedState.Parent = this.txtMatKhauMoi;
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhauMoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhauMoi.HoverState.Parent = this.txtMatKhauMoi;
            this.txtMatKhauMoi.Location = new System.Drawing.Point(280, 194);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '\0';
            this.txtMatKhauMoi.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMatKhauMoi.PlaceholderText = "Mật khẩu mới";
            this.txtMatKhauMoi.SelectedText = "";
            this.txtMatKhauMoi.ShadowDecoration.Parent = this.txtMatKhauMoi;
            this.txtMatKhauMoi.Size = new System.Drawing.Size(257, 36);
            this.txtMatKhauMoi.TabIndex = 81;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatKhauCu.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtMatKhauCu.BorderRadius = 10;
            this.txtMatKhauCu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhauCu.DefaultText = "";
            this.txtMatKhauCu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhauCu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhauCu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhauCu.DisabledState.Parent = this.txtMatKhauCu;
            this.txtMatKhauCu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhauCu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhauCu.FocusedState.Parent = this.txtMatKhauCu;
            this.txtMatKhauCu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauCu.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhauCu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhauCu.HoverState.Parent = this.txtMatKhauCu;
            this.txtMatKhauCu.Location = new System.Drawing.Point(280, 137);
            this.txtMatKhauCu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.PasswordChar = '\0';
            this.txtMatKhauCu.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMatKhauCu.PlaceholderText = "Mật khẩu cũ";
            this.txtMatKhauCu.SelectedText = "";
            this.txtMatKhauCu.ShadowDecoration.Parent = this.txtMatKhauCu;
            this.txtMatKhauCu.Size = new System.Drawing.Size(257, 36);
            this.txtMatKhauCu.TabIndex = 81;
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMatKhauMoi.BackColor = System.Drawing.Color.Transparent;
            this.lblMatKhauMoi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhauMoi.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMatKhauMoi.Location = new System.Drawing.Point(83, 203);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(66, 19);
            this.lblMatKhauMoi.TabIndex = 78;
            this.lblMatKhauMoi.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenDangNhap.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtTenDangNhap.BorderRadius = 10;
            this.txtTenDangNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDangNhap.DefaultText = "";
            this.txtTenDangNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDangNhap.DisabledState.Parent = this.txtTenDangNhap;
            this.txtTenDangNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDangNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDangNhap.FocusedState.Parent = this.txtTenDangNhap;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.Black;
            this.txtTenDangNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDangNhap.HoverState.Parent = this.txtTenDangNhap;
            this.txtTenDangNhap.Location = new System.Drawing.Point(280, 81);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.PasswordChar = '\0';
            this.txtTenDangNhap.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTenDangNhap.PlaceholderText = "Tên đăng nhập";
            this.txtTenDangNhap.SelectedText = "";
            this.txtTenDangNhap.ShadowDecoration.Parent = this.txtTenDangNhap;
            this.txtTenDangNhap.Size = new System.Drawing.Size(257, 36);
            this.txtTenDangNhap.TabIndex = 82;
            // 
            // lblMatKhauCu
            // 
            this.lblMatKhauCu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMatKhauCu.BackColor = System.Drawing.Color.Transparent;
            this.lblMatKhauCu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhauCu.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMatKhauCu.Location = new System.Drawing.Point(83, 146);
            this.lblMatKhauCu.Name = "lblMatKhauCu";
            this.lblMatKhauCu.Size = new System.Drawing.Size(66, 19);
            this.lblMatKhauCu.TabIndex = 78;
            this.lblMatKhauCu.Text = "Mật khẩu";
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXacNhanMatKhau.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtXacNhanMatKhau.BorderRadius = 10;
            this.txtXacNhanMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXacNhanMatKhau.DefaultText = "";
            this.txtXacNhanMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtXacNhanMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtXacNhanMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXacNhanMatKhau.DisabledState.Parent = this.txtXacNhanMatKhau;
            this.txtXacNhanMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXacNhanMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXacNhanMatKhau.FocusedState.Parent = this.txtXacNhanMatKhau;
            this.txtXacNhanMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhanMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtXacNhanMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXacNhanMatKhau.HoverState.Parent = this.txtXacNhanMatKhau;
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(280, 244);
            this.txtXacNhanMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.PasswordChar = '\0';
            this.txtXacNhanMatKhau.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtXacNhanMatKhau.PlaceholderText = "Xác nhận mật khẩu";
            this.txtXacNhanMatKhau.SelectedText = "";
            this.txtXacNhanMatKhau.ShadowDecoration.Parent = this.txtXacNhanMatKhau;
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(257, 36);
            this.txtXacNhanMatKhau.TabIndex = 83;
            this.txtXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTenDangNhap.Location = new System.Drawing.Point(83, 90);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(99, 19);
            this.lblTenDangNhap.TabIndex = 79;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblXacNhanMatKhau
            // 
            this.lblXacNhanMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblXacNhanMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lblXacNhanMatKhau.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXacNhanMatKhau.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblXacNhanMatKhau.Location = new System.Drawing.Point(83, 253);
            this.lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            this.lblXacNhanMatKhau.Size = new System.Drawing.Size(126, 19);
            this.lblXacNhanMatKhau.TabIndex = 80;
            this.lblXacNhanMatKhau.Text = "Xác nhận mật khẩu";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 554);
            this.Controls.Add(this.Panel1);
            this.Name = "frmDoiMatKhau";
            this.Text = "frmDoiMatKhau";
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel1;
        private Guna.UI2.WinForms.Guna2Panel Panel2;
        internal Guna.UI2.WinForms.Guna2Button btnXacNhan;
        internal Guna.UI2.WinForms.Guna2TextBox txtMatKhauCu;
        internal Guna.UI2.WinForms.Guna2TextBox txtTenDangNhap;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMatKhauCu;
        internal Guna.UI2.WinForms.Guna2TextBox txtXacNhanMatKhau;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenDangNhap;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblXacNhanMatKhau;
        internal Guna.UI2.WinForms.Guna2TextBox txtMatKhauMoi;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMatKhauMoi;
        internal Guna.UI2.WinForms.Guna2CheckBox chkShowPass;
    }
}
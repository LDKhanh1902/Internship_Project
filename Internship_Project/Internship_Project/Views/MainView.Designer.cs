
namespace Internship_Project
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            btnThoat = new Button();
            pnlControl = new Panel();
            btnTaiKhoan = new Button();
            btnDanhMuc = new Button();
            pnlDanhMuc = new Panel();
            btnDMChungTu = new Button();
            btnDMHangHoa = new Button();
            btnDMHinhThucThanhToan = new Button();
            btnDMKhachHang = new Button();
            btnDMKho = new Button();
            btnDMNhaCungCap = new Button();
            btnDMNgoaiTe = new Button();
            btnDanhMucNhanVien = new Button();
            btnDanhMucThue = new Button();
            btnDMTaiKhoan = new Button();
            btnCongNo = new Button();
            pnlCongNo = new Panel();
            btnChungTuThuCngNo = new Button();
            btnDMTaIKhoanDoiCungUng = new Button();
            btnDauKy = new Button();
            pnlDauKy = new Panel();
            btnBangDauKy = new Button();
            btnGhiNo = new Button();
            btnNhapXuat = new Button();
            pnlNhapXuat = new Panel();
            btnHoaDonNhap = new Button();
            btnHoaDonNhapChungTu = new Button();
            btnHoaDonXuat = new Button();
            btnHoaDonXuatChungTi = new Button();
            btnKhoHang = new Button();
            pnlKhoHang = new Panel();
            btnNhapXuatTienTonKho = new Button();
            btnSoDuTongHop = new Button();
            btnTongHopSoLuong = new Button();
            btnTonKho = new Button();
            pnlView = new Panel();
            pnlSidebar.SuspendLayout();
            pnlControl.SuspendLayout();
            pnlDanhMuc.SuspendLayout();
            pnlCongNo.SuspendLayout();
            pnlDauKy.SuspendLayout();
            pnlNhapXuat.SuspendLayout();
            pnlKhoHang.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(pnlControl);
            pnlSidebar.Controls.Add(btnThoat);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(300, 561);
            pnlSidebar.TabIndex = 2;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Firebrick;
            btnThoat.Dock = DockStyle.Bottom;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = SystemColors.ControlLightLight;
            btnThoat.Location = new Point(0, 521);
            btnThoat.Margin = new Padding(0);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(300, 40);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // pnlControl
            // 
            pnlControl.AutoScroll = true;
            pnlControl.Controls.Add(pnlKhoHang);
            pnlControl.Controls.Add(btnKhoHang);
            pnlControl.Controls.Add(pnlNhapXuat);
            pnlControl.Controls.Add(btnNhapXuat);
            pnlControl.Controls.Add(btnGhiNo);
            pnlControl.Controls.Add(pnlDauKy);
            pnlControl.Controls.Add(btnDauKy);
            pnlControl.Controls.Add(pnlCongNo);
            pnlControl.Controls.Add(btnCongNo);
            pnlControl.Controls.Add(pnlDanhMuc);
            pnlControl.Controls.Add(btnDanhMuc);
            pnlControl.Controls.Add(btnTaiKhoan);
            pnlControl.Dock = DockStyle.Fill;
            pnlControl.Location = new Point(0, 0);
            pnlControl.Margin = new Padding(0);
            pnlControl.Name = "pnlControl";
            pnlControl.Size = new Size(300, 521);
            pnlControl.TabIndex = 0;
            // 
            // btnTaiKhoan
            // 
            btnTaiKhoan.BackColor = Color.Cyan;
            btnTaiKhoan.Dock = DockStyle.Top;
            btnTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnTaiKhoan.Location = new Point(0, 0);
            btnTaiKhoan.Margin = new Padding(0);
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Padding = new Padding(100, 0, 0, 0);
            btnTaiKhoan.Size = new Size(300, 40);
            btnTaiKhoan.TabIndex = 0;
            btnTaiKhoan.Text = "Tài khoản";
            btnTaiKhoan.TextAlign = ContentAlignment.MiddleLeft;
            btnTaiKhoan.UseVisualStyleBackColor = false;
            btnTaiKhoan.Click += btnTaiKhoan_Click;
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.BackColor = Color.Cyan;
            btnDanhMuc.Dock = DockStyle.Top;
            btnDanhMuc.FlatStyle = FlatStyle.Flat;
            btnDanhMuc.Location = new Point(0, 40);
            btnDanhMuc.Margin = new Padding(0);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Padding = new Padding(100, 0, 0, 0);
            btnDanhMuc.Size = new Size(300, 40);
            btnDanhMuc.TabIndex = 1;
            btnDanhMuc.Text = "Danh mục";
            btnDanhMuc.TextAlign = ContentAlignment.MiddleLeft;
            btnDanhMuc.UseVisualStyleBackColor = false;
            btnDanhMuc.Click += btnDanhMuc_Click;
            // 
            // pnlDanhMuc
            // 
            pnlDanhMuc.Controls.Add(btnDMTaiKhoan);
            pnlDanhMuc.Controls.Add(btnDanhMucThue);
            pnlDanhMuc.Controls.Add(btnDanhMucNhanVien);
            pnlDanhMuc.Controls.Add(btnDMNgoaiTe);
            pnlDanhMuc.Controls.Add(btnDMNhaCungCap);
            pnlDanhMuc.Controls.Add(btnDMKho);
            pnlDanhMuc.Controls.Add(btnDMKhachHang);
            pnlDanhMuc.Controls.Add(btnDMHinhThucThanhToan);
            pnlDanhMuc.Controls.Add(btnDMHangHoa);
            pnlDanhMuc.Controls.Add(btnDMChungTu);
            pnlDanhMuc.Dock = DockStyle.Top;
            pnlDanhMuc.Location = new Point(0, 80);
            pnlDanhMuc.Name = "pnlDanhMuc";
            pnlDanhMuc.Size = new Size(300, 0);
            pnlDanhMuc.TabIndex = 2;
            // 
            // btnDMChungTu
            // 
            btnDMChungTu.Dock = DockStyle.Top;
            btnDMChungTu.FlatStyle = FlatStyle.Flat;
            btnDMChungTu.Location = new Point(0, 0);
            btnDMChungTu.Margin = new Padding(0);
            btnDMChungTu.Name = "btnDMChungTu";
            btnDMChungTu.Padding = new Padding(30, 0, 0, 0);
            btnDMChungTu.Size = new Size(300, 30);
            btnDMChungTu.TabIndex = 2;
            btnDMChungTu.Text = "Danh mục chứng từ";
            btnDMChungTu.TextAlign = ContentAlignment.MiddleLeft;
            btnDMChungTu.UseVisualStyleBackColor = true;
            // 
            // btnDMHangHoa
            // 
            btnDMHangHoa.Dock = DockStyle.Top;
            btnDMHangHoa.FlatStyle = FlatStyle.Flat;
            btnDMHangHoa.Location = new Point(0, 30);
            btnDMHangHoa.Margin = new Padding(0);
            btnDMHangHoa.Name = "btnDMHangHoa";
            btnDMHangHoa.Padding = new Padding(30, 0, 0, 0);
            btnDMHangHoa.Size = new Size(300, 30);
            btnDMHangHoa.TabIndex = 3;
            btnDMHangHoa.Text = "Danh mục hàng hóa";
            btnDMHangHoa.TextAlign = ContentAlignment.MiddleLeft;
            btnDMHangHoa.UseVisualStyleBackColor = true;
            // 
            // btnDMHinhThucThanhToan
            // 
            btnDMHinhThucThanhToan.Dock = DockStyle.Top;
            btnDMHinhThucThanhToan.FlatStyle = FlatStyle.Flat;
            btnDMHinhThucThanhToan.Location = new Point(0, 60);
            btnDMHinhThucThanhToan.Margin = new Padding(0);
            btnDMHinhThucThanhToan.Name = "btnDMHinhThucThanhToan";
            btnDMHinhThucThanhToan.Padding = new Padding(30, 0, 0, 0);
            btnDMHinhThucThanhToan.Size = new Size(300, 30);
            btnDMHinhThucThanhToan.TabIndex = 4;
            btnDMHinhThucThanhToan.Text = "Danh mục hình thức thanh toán";
            btnDMHinhThucThanhToan.TextAlign = ContentAlignment.MiddleLeft;
            btnDMHinhThucThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnDMKhachHang
            // 
            btnDMKhachHang.Dock = DockStyle.Top;
            btnDMKhachHang.FlatStyle = FlatStyle.Flat;
            btnDMKhachHang.Location = new Point(0, 90);
            btnDMKhachHang.Margin = new Padding(0);
            btnDMKhachHang.Name = "btnDMKhachHang";
            btnDMKhachHang.Padding = new Padding(30, 0, 0, 0);
            btnDMKhachHang.Size = new Size(300, 30);
            btnDMKhachHang.TabIndex = 5;
            btnDMKhachHang.Text = "Danh mục khách hàng";
            btnDMKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnDMKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnDMKho
            // 
            btnDMKho.Dock = DockStyle.Top;
            btnDMKho.FlatStyle = FlatStyle.Flat;
            btnDMKho.Location = new Point(0, 120);
            btnDMKho.Margin = new Padding(0);
            btnDMKho.Name = "btnDMKho";
            btnDMKho.Padding = new Padding(30, 0, 0, 0);
            btnDMKho.Size = new Size(300, 30);
            btnDMKho.TabIndex = 6;
            btnDMKho.Text = "Danh mục kho";
            btnDMKho.TextAlign = ContentAlignment.MiddleLeft;
            btnDMKho.UseVisualStyleBackColor = true;
            // 
            // btnDMNhaCungCap
            // 
            btnDMNhaCungCap.Dock = DockStyle.Top;
            btnDMNhaCungCap.FlatStyle = FlatStyle.Flat;
            btnDMNhaCungCap.Location = new Point(0, 150);
            btnDMNhaCungCap.Margin = new Padding(0);
            btnDMNhaCungCap.Name = "btnDMNhaCungCap";
            btnDMNhaCungCap.Padding = new Padding(30, 0, 0, 0);
            btnDMNhaCungCap.Size = new Size(300, 30);
            btnDMNhaCungCap.TabIndex = 7;
            btnDMNhaCungCap.Text = "Danh mục nhà cung cấp";
            btnDMNhaCungCap.TextAlign = ContentAlignment.MiddleLeft;
            btnDMNhaCungCap.UseVisualStyleBackColor = true;
            // 
            // btnDMNgoaiTe
            // 
            btnDMNgoaiTe.Dock = DockStyle.Top;
            btnDMNgoaiTe.FlatStyle = FlatStyle.Flat;
            btnDMNgoaiTe.Location = new Point(0, 180);
            btnDMNgoaiTe.Margin = new Padding(0);
            btnDMNgoaiTe.Name = "btnDMNgoaiTe";
            btnDMNgoaiTe.Padding = new Padding(30, 0, 0, 0);
            btnDMNgoaiTe.Size = new Size(300, 30);
            btnDMNgoaiTe.TabIndex = 8;
            btnDMNgoaiTe.Text = "Danh mục ngoại tệ";
            btnDMNgoaiTe.TextAlign = ContentAlignment.MiddleLeft;
            btnDMNgoaiTe.UseVisualStyleBackColor = true;
            // 
            // btnDanhMucNhanVien
            // 
            btnDanhMucNhanVien.Dock = DockStyle.Top;
            btnDanhMucNhanVien.FlatStyle = FlatStyle.Flat;
            btnDanhMucNhanVien.Location = new Point(0, 210);
            btnDanhMucNhanVien.Margin = new Padding(0);
            btnDanhMucNhanVien.Name = "btnDanhMucNhanVien";
            btnDanhMucNhanVien.Padding = new Padding(30, 0, 0, 0);
            btnDanhMucNhanVien.Size = new Size(300, 30);
            btnDanhMucNhanVien.TabIndex = 9;
            btnDanhMucNhanVien.Text = "Danh mục nhân viên";
            btnDanhMucNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnDanhMucNhanVien.UseVisualStyleBackColor = true;
            btnDanhMucNhanVien.Click += btnNhanVien_Click;
            // 
            // btnDanhMucThue
            // 
            btnDanhMucThue.Dock = DockStyle.Top;
            btnDanhMucThue.FlatStyle = FlatStyle.Flat;
            btnDanhMucThue.Location = new Point(0, 240);
            btnDanhMucThue.Margin = new Padding(0);
            btnDanhMucThue.Name = "btnDanhMucThue";
            btnDanhMucThue.Padding = new Padding(30, 0, 0, 0);
            btnDanhMucThue.Size = new Size(300, 30);
            btnDanhMucThue.TabIndex = 10;
            btnDanhMucThue.Text = "Danh mục thuế";
            btnDanhMucThue.TextAlign = ContentAlignment.MiddleLeft;
            btnDanhMucThue.UseVisualStyleBackColor = true;
            // 
            // btnDMTaiKhoan
            // 
            btnDMTaiKhoan.Dock = DockStyle.Top;
            btnDMTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnDMTaiKhoan.Location = new Point(0, 270);
            btnDMTaiKhoan.Margin = new Padding(0);
            btnDMTaiKhoan.Name = "btnDMTaiKhoan";
            btnDMTaiKhoan.Padding = new Padding(30, 0, 0, 0);
            btnDMTaiKhoan.Size = new Size(300, 30);
            btnDMTaiKhoan.TabIndex = 11;
            btnDMTaiKhoan.Text = "Danh mục tài khoản";
            btnDMTaiKhoan.TextAlign = ContentAlignment.MiddleLeft;
            btnDMTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btnCongNo
            // 
            btnCongNo.BackColor = Color.Cyan;
            btnCongNo.Dock = DockStyle.Top;
            btnCongNo.FlatStyle = FlatStyle.Flat;
            btnCongNo.Location = new Point(0, 80);
            btnCongNo.Margin = new Padding(0);
            btnCongNo.Name = "btnCongNo";
            btnCongNo.Padding = new Padding(100, 0, 0, 0);
            btnCongNo.Size = new Size(300, 40);
            btnCongNo.TabIndex = 3;
            btnCongNo.Text = "Công nợ";
            btnCongNo.TextAlign = ContentAlignment.MiddleLeft;
            btnCongNo.UseVisualStyleBackColor = false;
            btnCongNo.Click += btnCongNo_Click;
            // 
            // pnlCongNo
            // 
            pnlCongNo.Controls.Add(btnDMTaIKhoanDoiCungUng);
            pnlCongNo.Controls.Add(btnChungTuThuCngNo);
            pnlCongNo.Dock = DockStyle.Top;
            pnlCongNo.Location = new Point(0, 120);
            pnlCongNo.Name = "pnlCongNo";
            pnlCongNo.Size = new Size(300, 0);
            pnlCongNo.TabIndex = 4;
            // 
            // btnChungTuThuCngNo
            // 
            btnChungTuThuCngNo.Dock = DockStyle.Top;
            btnChungTuThuCngNo.FlatStyle = FlatStyle.Flat;
            btnChungTuThuCngNo.Location = new Point(0, 0);
            btnChungTuThuCngNo.Margin = new Padding(0);
            btnChungTuThuCngNo.Name = "btnChungTuThuCngNo";
            btnChungTuThuCngNo.Padding = new Padding(30, 0, 0, 0);
            btnChungTuThuCngNo.Size = new Size(300, 30);
            btnChungTuThuCngNo.TabIndex = 2;
            btnChungTuThuCngNo.Text = "Chứng từ thu công nợ";
            btnChungTuThuCngNo.TextAlign = ContentAlignment.MiddleLeft;
            btnChungTuThuCngNo.UseVisualStyleBackColor = true;
            // 
            // btnDMTaIKhoanDoiCungUng
            // 
            btnDMTaIKhoanDoiCungUng.Dock = DockStyle.Top;
            btnDMTaIKhoanDoiCungUng.FlatStyle = FlatStyle.Flat;
            btnDMTaIKhoanDoiCungUng.Location = new Point(0, 30);
            btnDMTaIKhoanDoiCungUng.Margin = new Padding(0);
            btnDMTaIKhoanDoiCungUng.Name = "btnDMTaIKhoanDoiCungUng";
            btnDMTaIKhoanDoiCungUng.Padding = new Padding(30, 0, 0, 0);
            btnDMTaIKhoanDoiCungUng.Size = new Size(300, 30);
            btnDMTaIKhoanDoiCungUng.TabIndex = 3;
            btnDMTaIKhoanDoiCungUng.Tag = "";
            btnDMTaIKhoanDoiCungUng.Text = "Danh mục tài khoản đợi cung ứng";
            btnDMTaIKhoanDoiCungUng.TextAlign = ContentAlignment.MiddleLeft;
            btnDMTaIKhoanDoiCungUng.UseVisualStyleBackColor = true;
            // 
            // btnDauKy
            // 
            btnDauKy.BackColor = Color.Cyan;
            btnDauKy.Dock = DockStyle.Top;
            btnDauKy.FlatStyle = FlatStyle.Flat;
            btnDauKy.Location = new Point(0, 120);
            btnDauKy.Margin = new Padding(0);
            btnDauKy.Name = "btnDauKy";
            btnDauKy.Padding = new Padding(100, 0, 0, 0);
            btnDauKy.Size = new Size(300, 40);
            btnDauKy.TabIndex = 5;
            btnDauKy.Text = "Đầu kỳ";
            btnDauKy.TextAlign = ContentAlignment.MiddleLeft;
            btnDauKy.UseVisualStyleBackColor = false;
            btnDauKy.Click += btnDauKy_Click;
            // 
            // pnlDauKy
            // 
            pnlDauKy.Controls.Add(btnBangDauKy);
            pnlDauKy.Dock = DockStyle.Top;
            pnlDauKy.Location = new Point(0, 160);
            pnlDauKy.Name = "pnlDauKy";
            pnlDauKy.Size = new Size(300, 0);
            pnlDauKy.TabIndex = 6;
            // 
            // btnBangDauKy
            // 
            btnBangDauKy.Dock = DockStyle.Top;
            btnBangDauKy.FlatStyle = FlatStyle.Flat;
            btnBangDauKy.Location = new Point(0, 0);
            btnBangDauKy.Margin = new Padding(0);
            btnBangDauKy.Name = "btnBangDauKy";
            btnBangDauKy.Padding = new Padding(30, 0, 0, 0);
            btnBangDauKy.Size = new Size(300, 30);
            btnBangDauKy.TabIndex = 3;
            btnBangDauKy.Text = "Bảng đầu kỳ";
            btnBangDauKy.TextAlign = ContentAlignment.MiddleLeft;
            btnBangDauKy.UseVisualStyleBackColor = true;
            // 
            // btnGhiNo
            // 
            btnGhiNo.BackColor = Color.Cyan;
            btnGhiNo.Dock = DockStyle.Top;
            btnGhiNo.FlatStyle = FlatStyle.Flat;
            btnGhiNo.Location = new Point(0, 160);
            btnGhiNo.Margin = new Padding(0);
            btnGhiNo.Name = "btnGhiNo";
            btnGhiNo.Padding = new Padding(100, 0, 0, 0);
            btnGhiNo.Size = new Size(300, 40);
            btnGhiNo.TabIndex = 7;
            btnGhiNo.Text = "Ghi nợ";
            btnGhiNo.TextAlign = ContentAlignment.MiddleLeft;
            btnGhiNo.UseVisualStyleBackColor = false;
            btnGhiNo.Click += btnGhiNo_Click;
            // 
            // btnNhapXuat
            // 
            btnNhapXuat.BackColor = Color.Cyan;
            btnNhapXuat.Dock = DockStyle.Top;
            btnNhapXuat.FlatStyle = FlatStyle.Flat;
            btnNhapXuat.Location = new Point(0, 200);
            btnNhapXuat.Margin = new Padding(0);
            btnNhapXuat.Name = "btnNhapXuat";
            btnNhapXuat.Padding = new Padding(100, 0, 0, 0);
            btnNhapXuat.Size = new Size(300, 40);
            btnNhapXuat.TabIndex = 9;
            btnNhapXuat.Text = "Nhập xuất";
            btnNhapXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnNhapXuat.UseVisualStyleBackColor = false;
            btnNhapXuat.Click += btnNhapXuat_Click;
            // 
            // pnlNhapXuat
            // 
            pnlNhapXuat.Controls.Add(btnHoaDonXuatChungTi);
            pnlNhapXuat.Controls.Add(btnHoaDonXuat);
            pnlNhapXuat.Controls.Add(btnHoaDonNhapChungTu);
            pnlNhapXuat.Controls.Add(btnHoaDonNhap);
            pnlNhapXuat.Dock = DockStyle.Top;
            pnlNhapXuat.Location = new Point(0, 240);
            pnlNhapXuat.Name = "pnlNhapXuat";
            pnlNhapXuat.Size = new Size(300, 0);
            pnlNhapXuat.TabIndex = 10;
            // 
            // btnHoaDonNhap
            // 
            btnHoaDonNhap.Dock = DockStyle.Top;
            btnHoaDonNhap.FlatStyle = FlatStyle.Flat;
            btnHoaDonNhap.Location = new Point(0, 0);
            btnHoaDonNhap.Margin = new Padding(0);
            btnHoaDonNhap.Name = "btnHoaDonNhap";
            btnHoaDonNhap.Padding = new Padding(30, 0, 0, 0);
            btnHoaDonNhap.Size = new Size(300, 30);
            btnHoaDonNhap.TabIndex = 2;
            btnHoaDonNhap.Text = "Hóa đơn nhập";
            btnHoaDonNhap.TextAlign = ContentAlignment.MiddleLeft;
            btnHoaDonNhap.UseVisualStyleBackColor = true;
            // 
            // btnHoaDonNhapChungTu
            // 
            btnHoaDonNhapChungTu.Dock = DockStyle.Top;
            btnHoaDonNhapChungTu.FlatStyle = FlatStyle.Flat;
            btnHoaDonNhapChungTu.Location = new Point(0, 30);
            btnHoaDonNhapChungTu.Margin = new Padding(0);
            btnHoaDonNhapChungTu.Name = "btnHoaDonNhapChungTu";
            btnHoaDonNhapChungTu.Padding = new Padding(30, 0, 0, 0);
            btnHoaDonNhapChungTu.Size = new Size(300, 30);
            btnHoaDonNhapChungTu.TabIndex = 3;
            btnHoaDonNhapChungTu.Text = "Hoắ đơn nhập chứng từ";
            btnHoaDonNhapChungTu.TextAlign = ContentAlignment.MiddleLeft;
            btnHoaDonNhapChungTu.UseVisualStyleBackColor = true;
            // 
            // btnHoaDonXuat
            // 
            btnHoaDonXuat.Dock = DockStyle.Top;
            btnHoaDonXuat.FlatStyle = FlatStyle.Flat;
            btnHoaDonXuat.Location = new Point(0, 60);
            btnHoaDonXuat.Margin = new Padding(0);
            btnHoaDonXuat.Name = "btnHoaDonXuat";
            btnHoaDonXuat.Padding = new Padding(30, 0, 0, 0);
            btnHoaDonXuat.Size = new Size(300, 30);
            btnHoaDonXuat.TabIndex = 4;
            btnHoaDonXuat.Text = "Hóa đơn xuất";
            btnHoaDonXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnHoaDonXuat.UseVisualStyleBackColor = true;
            // 
            // btnHoaDonXuatChungTi
            // 
            btnHoaDonXuatChungTi.Dock = DockStyle.Top;
            btnHoaDonXuatChungTi.FlatStyle = FlatStyle.Flat;
            btnHoaDonXuatChungTi.Location = new Point(0, 90);
            btnHoaDonXuatChungTi.Margin = new Padding(0);
            btnHoaDonXuatChungTi.Name = "btnHoaDonXuatChungTi";
            btnHoaDonXuatChungTi.Padding = new Padding(30, 0, 0, 0);
            btnHoaDonXuatChungTi.Size = new Size(300, 30);
            btnHoaDonXuatChungTi.TabIndex = 5;
            btnHoaDonXuatChungTi.Text = "Hoắ đơn xuất chứng từ";
            btnHoaDonXuatChungTi.TextAlign = ContentAlignment.MiddleLeft;
            btnHoaDonXuatChungTi.UseVisualStyleBackColor = true;
            // 
            // btnKhoHang
            // 
            btnKhoHang.BackColor = Color.Cyan;
            btnKhoHang.Dock = DockStyle.Top;
            btnKhoHang.FlatStyle = FlatStyle.Flat;
            btnKhoHang.Location = new Point(0, 240);
            btnKhoHang.Margin = new Padding(0);
            btnKhoHang.Name = "btnKhoHang";
            btnKhoHang.Padding = new Padding(100, 0, 0, 0);
            btnKhoHang.Size = new Size(300, 40);
            btnKhoHang.TabIndex = 11;
            btnKhoHang.Text = "Kho hàng";
            btnKhoHang.TextAlign = ContentAlignment.MiddleLeft;
            btnKhoHang.UseVisualStyleBackColor = false;
            btnKhoHang.Click += btnKhoHang_Click;
            // 
            // pnlKhoHang
            // 
            pnlKhoHang.Controls.Add(btnTonKho);
            pnlKhoHang.Controls.Add(btnTongHopSoLuong);
            pnlKhoHang.Controls.Add(btnSoDuTongHop);
            pnlKhoHang.Controls.Add(btnNhapXuatTienTonKho);
            pnlKhoHang.Dock = DockStyle.Top;
            pnlKhoHang.Location = new Point(0, 280);
            pnlKhoHang.Name = "pnlKhoHang";
            pnlKhoHang.Size = new Size(300, 0);
            pnlKhoHang.TabIndex = 12;
            // 
            // btnNhapXuatTienTonKho
            // 
            btnNhapXuatTienTonKho.Dock = DockStyle.Top;
            btnNhapXuatTienTonKho.FlatStyle = FlatStyle.Flat;
            btnNhapXuatTienTonKho.Location = new Point(0, 0);
            btnNhapXuatTienTonKho.Margin = new Padding(0);
            btnNhapXuatTienTonKho.Name = "btnNhapXuatTienTonKho";
            btnNhapXuatTienTonKho.Padding = new Padding(30, 0, 0, 0);
            btnNhapXuatTienTonKho.Size = new Size(300, 30);
            btnNhapXuatTienTonKho.TabIndex = 2;
            btnNhapXuatTienTonKho.Text = "Nhập xuất tiền tồn kho";
            btnNhapXuatTienTonKho.TextAlign = ContentAlignment.MiddleLeft;
            btnNhapXuatTienTonKho.UseVisualStyleBackColor = true;
            // 
            // btnSoDuTongHop
            // 
            btnSoDuTongHop.Dock = DockStyle.Top;
            btnSoDuTongHop.FlatStyle = FlatStyle.Flat;
            btnSoDuTongHop.Location = new Point(0, 30);
            btnSoDuTongHop.Margin = new Padding(0);
            btnSoDuTongHop.Name = "btnSoDuTongHop";
            btnSoDuTongHop.Padding = new Padding(30, 0, 0, 0);
            btnSoDuTongHop.Size = new Size(300, 30);
            btnSoDuTongHop.TabIndex = 3;
            btnSoDuTongHop.Text = "Số dư tổng hợp";
            btnSoDuTongHop.TextAlign = ContentAlignment.MiddleLeft;
            btnSoDuTongHop.UseVisualStyleBackColor = true;
            // 
            // btnTongHopSoLuong
            // 
            btnTongHopSoLuong.Dock = DockStyle.Top;
            btnTongHopSoLuong.FlatStyle = FlatStyle.Flat;
            btnTongHopSoLuong.Location = new Point(0, 60);
            btnTongHopSoLuong.Margin = new Padding(0);
            btnTongHopSoLuong.Name = "btnTongHopSoLuong";
            btnTongHopSoLuong.Padding = new Padding(30, 0, 0, 0);
            btnTongHopSoLuong.Size = new Size(300, 30);
            btnTongHopSoLuong.TabIndex = 4;
            btnTongHopSoLuong.Text = "Tổng hợp số lượng";
            btnTongHopSoLuong.TextAlign = ContentAlignment.MiddleLeft;
            btnTongHopSoLuong.UseVisualStyleBackColor = true;
            // 
            // btnTonKho
            // 
            btnTonKho.Dock = DockStyle.Top;
            btnTonKho.FlatStyle = FlatStyle.Flat;
            btnTonKho.Location = new Point(0, 90);
            btnTonKho.Margin = new Padding(0);
            btnTonKho.Name = "btnTonKho";
            btnTonKho.Padding = new Padding(30, 0, 0, 0);
            btnTonKho.Size = new Size(300, 30);
            btnTonKho.TabIndex = 5;
            btnTonKho.Text = "Tồn kho";
            btnTonKho.TextAlign = ContentAlignment.MiddleLeft;
            btnTonKho.UseVisualStyleBackColor = true;
            // 
            // pnlView
            // 
            pnlView.Dock = DockStyle.Fill;
            pnlView.Location = new Point(300, 0);
            pnlView.Name = "pnlView";
            pnlView.Size = new Size(884, 561);
            pnlView.TabIndex = 3;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 561);
            Controls.Add(pnlView);
            Controls.Add(pnlSidebar);
            Name = "MainView";
            Text = "Form1";
            Load += MainView_Load;
            pnlSidebar.ResumeLayout(false);
            pnlControl.ResumeLayout(false);
            pnlDanhMuc.ResumeLayout(false);
            pnlCongNo.ResumeLayout(false);
            pnlDauKy.ResumeLayout(false);
            pnlNhapXuat.ResumeLayout(false);
            pnlKhoHang.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlSidebar;
        private Button btnThoat;
        private Panel pnlControl;
        private Panel pnlKhoHang;
        private Button btnTonKho;
        private Button btnTongHopSoLuong;
        private Button btnSoDuTongHop;
        private Button btnNhapXuatTienTonKho;
        private Button btnKhoHang;
        private Panel pnlNhapXuat;
        private Button btnHoaDonXuatChungTi;
        private Button btnHoaDonXuat;
        private Button btnHoaDonNhapChungTu;
        private Button btnHoaDonNhap;
        private Button btnNhapXuat;
        private Button btnGhiNo;
        private Panel pnlDauKy;
        private Button btnBangDauKy;
        private Button btnDauKy;
        private Panel pnlCongNo;
        private Button btnDMTaIKhoanDoiCungUng;
        private Button btnChungTuThuCngNo;
        private Button btnCongNo;
        private Panel pnlDanhMuc;
        private Button btnDMTaiKhoan;
        private Button btnDanhMucThue;
        private Button btnDanhMucNhanVien;
        private Button btnDMNgoaiTe;
        private Button btnDMNhaCungCap;
        private Button btnDMKho;
        private Button btnDMKhachHang;
        private Button btnDMHinhThucThanhToan;
        private Button btnDMHangHoa;
        private Button btnDMChungTu;
        private Button btnDanhMuc;
        private Button btnTaiKhoan;
        private Panel pnlView;
    }
}

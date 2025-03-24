using Internship_Project.Views;

namespace Internship_Project
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmTaiKhoan());
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            if (pnlDanhMuc.Height > 0)
            {
                pnlDanhMuc.AutoSize = false;
                pnlDanhMuc.Height = 0;
            }
            else
            {
                pnlDanhMuc.AutoSize = true;
            }

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmNhanVien());
        }

        private void btnCongNo_Click(object sender, EventArgs e)
        {
            if (pnlCongNo.Height > 0)
            {
                pnlCongNo.AutoSize = false;
                pnlCongNo.Height = 0;
            }
            else
            {
                pnlCongNo.AutoSize = true;
            }
        }

        private void btnDauKy_Click(object sender, EventArgs e)
        {
            if (pnlDauKy.Height > 0)
            {
                pnlDauKy.AutoSize = false;
                pnlDauKy.Height = 0;
            }
            else
            {
                pnlDauKy.AutoSize = true;
            }
        }

        private void btnGhiNo_Click(object sender, EventArgs e)
        {

        }

        private void btnNhapXuat_Click(object sender, EventArgs e)
        {
            if (pnlNhapXuat.Height > 0)
            {
                pnlNhapXuat.AutoSize = false;
                pnlNhapXuat.Height = 0;
            }
            else
            {
                pnlNhapXuat.AutoSize = true;
            }
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            if (pnlKhoHang.Height > 0)
            {
                pnlKhoHang.AutoSize = false;
                pnlKhoHang.Height = 0;
            }
            else
            {
                pnlKhoHang.AutoSize = true;
            }
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        private void ShowFormInPanel(Form form)
        {
            pnlView.Controls.Clear(); // Xóa Form cũ nếu có
            form.TopLevel = false; // Không phải Form cấp cao
            form.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền
            form.Dock = DockStyle.Fill; // Fill toàn bộ Panel
            pnlView.Controls.Add(form); // Thêm vào Panel
            form.Show(); // Hiển thị Form
        }
    }
}

using Microsoft.Data.SqlClient;
namespace CK_QLKS
{
    public partial class FrmMain : Form

    {
        
        public FrmMain()
        {
            InitializeComponent();
        }

        

        private void FrmMain_Load(object sender, EventArgs e)
        {
            btnQuanLyPhong_Click(this, EventArgs.Empty);
        }

        

        private void btnQuanLyPhong_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();

            
            ucQLPhong = new ucQLPhong();
            ucQLPhong.Dock = DockStyle.Fill; // Cho nó lấp đầy khoảng trống

            // 3. Nhét nó vào cái Panel ở giữa form chính
            pnlContainer.Controls.Add(uc);
        }

        private void pnGiaoDienChinh_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

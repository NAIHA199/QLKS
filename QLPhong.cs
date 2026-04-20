using QuanLyKhachSan_LTUD;
using System.Data;

namespace CK_QLKS
{
    public partial class QLPhong : UserControl
    {
        KetNoi kn = new KetNoi();

        public QLPhong()
        {
            InitializeComponent();
        }

        // 1. Tạo hàm load dữ liệu
        public void LoadDataPhong()
        {
            string sql = "SELECT MaPhong AS [Mã Phòng], MaLoaiPhong AS [Loại Phòng], " +
                         "TinhTrang AS [Tình Trạng], GhiChu AS [Ghi Chú] FROM LOAIPHONG";
            DataTable dt = kn.LayDuLieu(sql);

            
        }

        // 2. Gọi hàm load khi UserControl vừa được nạp
        private void QLPhong_Load(object sender, EventArgs e)
        {
        }
    }
}
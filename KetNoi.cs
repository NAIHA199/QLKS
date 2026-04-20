using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;


namespace QuanLyKhachSan_LTUD
{
    public class KetNoi
    {
        private string conStr = @"Data Source=.;Initial Catalog=QuanLyKhachSan_LTUD;Integrated Security=True";

        private SqlConnection conn;

        public KetNoi()
        {
            conn = new SqlConnection(conStr);
        }
        public DataTable LayDuLieu(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        // Hàm 2: Dùng để chạy câu lệnh INSERT, UPDATE, DELETE
        // Trả về true nếu thành công, false nếu thất bại
        public bool ThucThi(string sql)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
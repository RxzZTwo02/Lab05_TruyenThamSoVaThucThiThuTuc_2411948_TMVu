using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab05_Advanced_Command
{
    // Phần C: mỗi form tự tạo SqlCommand gọi thủ tục và truyền tham số,
    // lớp này chỉ lo phần kết nối và bắt lỗi SQL để không phải lặp lại
    internal static class DataProvider
    {
        const string connectionString = "server=localhost\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";

        // Thủ tục trả về dữ liệu: đổ kết quả vào DataTable
        public static DataTable GetData(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = new SqlConnection(connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL Error");
            }
            return dt;
        }

        // Thủ tục thêm, sửa: trả về số dòng bị ảnh hưởng, lỗi thì báo và trả về 0
        public static int Execute(SqlCommand cmd)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            cmd.Connection = conn;
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL Error");
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

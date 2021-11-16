using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlyphongtro1
{
    public partial class frmthemphong : Form
    {
        String strconn = "Data Source=.\\SQLEXPRESS;Initial Catalog=quanlyphongtro;Integrated Security = True";
        SqlConnection conn = null;
        public frmthemphong()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            String maphong = txtmaphong.Text;
            String query = String.Format("insert into phong (maPhong,trangThai) values ('{0}',N'Trống')", maphong);
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                com.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm phòng thành công!");
            }
            catch
            {
                MessageBox.Show("Phòng đã tồn tại");
            }
        }
    }
}

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
    public partial class frmsuathongtin_taikhoan : Form
    {
        String strconn = "Data Source=.\\SQLEXPRESS;Initial Catalog=quanlyphongtro;Integrated Security = True";
        SqlConnection conn = null;
        private String tendangnhap;
        
        public frmsuathongtin_taikhoan()
        {
            InitializeComponent();
        }

        public frmsuathongtin_taikhoan(String ptendangnhap)
            : this()
        {
            tendangnhap = ptendangnhap;
            txttendangnhap.Text = ptendangnhap;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            this.txttendangnhap.Clear();
            this.txttenhienthi.Clear();
            this.txtmatkhau.Clear();
            this.txtnhaplaimatkhau.Clear();
            this.txtquyenhan.Clear();
            this.txttendangnhap.Focus();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            String tenhienthi = txttenhienthi.Text;
            String matkhau = txtmatkhau.Text;
            String nhaplaimatkhau = txtnhaplaimatkhau.Text;
            String quyenhan = txtquyenhan.Text;
            if (tenhienthi==""||matkhau==""||nhaplaimatkhau==""||quyenhan=="")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            } else if (matkhau != nhaplaimatkhau)
            {
                MessageBox.Show("Mật khẩu không giống nhau!");
            } else
            {
                conn = new SqlConnection(strconn);
                String query = String.Format("update taikhoan set tenDangNhap='{0}',tenHienThi=N'{1}',matkhau='{2}',quyenhan='{3}' where tenDangNhap='{0}'", tendangnhap, tenhienthi, matkhau, quyenhan);
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                com.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Cập nhật thành công");
                this.txttendangnhap.Clear();
                this.txttenhienthi.Clear();
                this.txtmatkhau.Clear();
                this.txtnhaplaimatkhau.Clear();
                this.txtquyenhan.Clear();
                this.txttendangnhap.Focus();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

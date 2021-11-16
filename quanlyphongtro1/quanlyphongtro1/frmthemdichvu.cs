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
    public partial class frmthemdichvu : Form
    {
        String strconn = "Data Source=.\\SQLEXPRESS;Initial Catalog=quanlyphongtro;Integrated Security = True";
        SqlConnection conn = null;
        public frmthemdichvu()
        {
            InitializeComponent();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            this.txttendichvu.Clear();
            this.txtdonvitinh.Clear();
            this.txtdongia.Clear();
            this.txttendichvu.Focus();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            String tendichvu = txttendichvu.Text;
            String donvitinh = txtdonvitinh.Text;
            String dongia = txtdongia.Text;
            conn = new SqlConnection(strconn);
            
            try
            {
                String query1 = String.Format("insert into danhSachDichVu (tenDichVu,donViTinh,donGia) values (N'{0}',N'{1}','{2}')",tendichvu,donvitinh,dongia);
                conn.Open();
                SqlCommand com1 = new SqlCommand(query1,conn);
                com1.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Đã thêm dịch vụ thành công!");
                this.txttendichvu.Clear();
                this.txtdonvitinh.Clear();
                this.txtdongia.Clear();
                this.txttendichvu.Focus();
            }
            catch
            {
                MessageBox.Show("Dịch vụ đã tồn tại!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNganHang
{
    public partial class fTinDung : Form
    {
        DataQLNganHangDataContext db = new DataQLNganHangDataContext();
        public fTinDung()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string b = txtCccd.Text;
            var item = (from u in db.KhachHangs where u.Cccd == b select u);
            gvKhachHang.DataSource = item.ToList();
            var item1 = (from u in db.TinDungs where u.Cccd == b select u);
            gvTinDung.DataSource = item1.ToList();
        }
    }
}

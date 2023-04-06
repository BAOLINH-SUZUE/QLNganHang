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
        DataClasses1DataContext db = new DataClasses1DataContext();
        public fTinDung()
        {
            InitializeComponent();
        }

        private void fTinDung_Load(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            gvKhachHang.DataSource = db.KhachHangs;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var lst = (from s in db.KhachHangs where s.Cccd.Contains(txtTimKiem.Text) select s).ToList();
            gvKhachHang.DataSource = lst;

        }

        private void btnTaoTinDung_Click(object sender, EventArgs e)
        {
            
            fTaoTinDung f = new fTaoTinDung();
            f.ShowDialog();

            
        }
    }
}

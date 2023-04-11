using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNganHang
{
    internal class khachHang
    {
        public string MaKH;
        public string TenKH;
        public DateTime NgaySinh;
        public string SDT;
        public string Email;
        public string Cccd;
        public string Diachi;
        public SqlMoney ThuNhap;

        public khachHang(string makh, string tenkh, DateTime ngaysinh, string sdt, string email, string cccd, string diachi, SqlMoney thuNhap)
        {
            MaKH = makh;
            TenKH = tenkh;
            NgaySinh = ngaysinh;
            SDT = sdt;
            Email = email;
            Cccd = cccd;
            Diachi = diachi;
            ThuNhap = thuNhap;
        }
    }
}

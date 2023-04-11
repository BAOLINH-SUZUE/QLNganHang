using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace QLNganHang
{
    internal class nhanVien
    {
        public string MaNV;
        public string TenNV;
        public DateTime NgaySinh;
        public string SDT;
        public string Cccd;
        public string Email;
        public string DiaChi;

        public nhanVien(string manv, string tennv, DateTime ngaySinh, string sdt, string cccd, string email, string diaChi)
        {
            MaNV = manv;
            TenNV = tennv;
            NgaySinh = ngaySinh;
            SDT = sdt;
            Cccd = cccd;
            Email = email;
            DiaChi = diaChi;
        }
    }
}

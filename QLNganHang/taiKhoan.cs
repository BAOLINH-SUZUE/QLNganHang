using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNganHang
{
    internal class taiKhoan
    {
        public string SoTK;
        public string SoTKhoanTk;
        public string MaKH;
        public string TenKH;
        public string SDT;
        public string Cccd;
        public SqlMoney SoDu;
        public SqlMoney SoTienVay;

        public taiKhoan(string sotk, string sotkhoanTk, string makh, string tenkh, string sdt, string cccd, SqlMoney sodu, SqlMoney sotienvay)
        {
            SoTK = sotk;
            SoTKhoanTk = sotkhoanTk;
            MaKH = makh;
            TenKH = tenkh;
            SDT = sdt;
            Cccd = cccd;
            SoDu = sodu;
            SoTienVay = sotienvay;
        }
    }
}

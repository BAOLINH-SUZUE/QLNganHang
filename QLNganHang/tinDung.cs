using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLNganHang
{
    internal class tinDung
    {
        public string MaTD;
        public string TenKH;
        public SqlMoney ThuNhap;
        public string Cccd;
        public string LoaiThe;
        public string HangMuc;
        public DateTime NgayTra;
        public float laiXuatTD;
        public SqlMoney NoTD;
        public SqlMoney NoXau;
        public string SoLan;

        public tinDung(string matd, string tenkh, SqlMoney thunhap, string cccd, string loaithe, string hangmuc, DateTime ngaytra, float laixuattd, SqlMoney notd, SqlMoney noxau, string solan)
        {
            MaTD = matd;
            TenKH = tenkh;
            ThuNhap = thunhap;
            Cccd = cccd;
            LoaiThe = loaithe;
            HangMuc = hangmuc;
            NgayTra = ngaytra;
            this.laiXuatTD = laixuattd;
            NoTD = notd;
            NoXau = noxau;
            SoLan = solan;
        }
    }
}

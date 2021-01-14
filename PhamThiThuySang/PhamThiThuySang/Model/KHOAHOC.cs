using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamThiThuySang.Model
{
    class KHOAHOC
    {
        public string MaKhoaHoc { get; set; }
        public string TenKhoaHoc { get; set; }



        public KHOAHOC(string makh, string tenkh)
        {
            this.MaKhoaHoc= makh;
            this.TenKhoaHoc = tenkh;

        }
        public KHOAHOC(DataRow r)
        {
            this.MaKhoaHoc = r["MaKhoaHoc"].ToString();
            this.TenKhoaHoc = r["TenKhoaHoc"].ToString();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamThiThuySang.Model
{
    class LOP
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string MaKhoa { get; set; }
        public string MaKhoaHoc { get; set; }



        public LOP(string malop, string tenlop, string mk,string makh)
        {
            this.MaLop = malop;
            this.TenLop = tenlop;
            this.MaKhoa = mk;
            this.MaKhoaHoc = makh;

        }
        public LOP(DataRow r)
        {
            this.MaLop = r["MaLop"].ToString();
            this.TenLop = r["TenLop"].ToString();
            this.MaKhoa = r["MaKhoa"].ToString();
            this.MaKhoaHoc = r["MaKhoaHoc"].ToString();

        }
    }
}

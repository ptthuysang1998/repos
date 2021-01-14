using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamThiThuySang.Model
{
    class LOP_SINHVIEN
    {
        public string MaSinhVien { get; set; }
        public string MaLop { get; set; }



        public LOP_SINHVIEN(string masv, string malop)
        {
            this.MaSinhVien = masv;
            this.MaLop = malop;

        }
        public LOP_SINHVIEN(DataRow r)
        {
            this.MaSinhVien = r["MaSinhVien"].ToString();
            this.MaLop = r["MaLop"].ToString();

        }
    }

}

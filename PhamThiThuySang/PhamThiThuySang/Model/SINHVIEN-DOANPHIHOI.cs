using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamThiThuySang.Model
{
    class SINHVIEN_DOANPHIHOI
    {
        public string MaDoanPhi { get; set; }
        public string MaSinhVien { get; set; }
         public Boolean Nop { get; set; }



        public SINHVIEN_DOANPHIHOI(string madp, string masv, Boolean nop)
        {
            this.MaDoanPhi = madp;
            this.MaSinhVien = masv;
            this.Nop = nop;

        }
        public SINHVIEN_DOANPHIHOI(DataRow r)
        {
            this.MaDoanPhi = r["MaDoanPhi"].ToString();
            this.MaSinhVien = r["MaSinhVien"].ToString();
            this.Nop = Boolean.Parse(r["Nop"].ToString());

        }
    }
}

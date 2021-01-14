using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamThiThuySang.Model
{
    class DOANPHI
    {
        public string MaDoanPhi { get; set; }
        public string TenDoanPhi { get; set; }



        public DOANPHI(string madp, string tendp)
        {
            this.MaDoanPhi= madp;
            this.TenDoanPhi = tendp;

        }
        public DOANPHI(DataRow r)
        {
            this.MaDoanPhi = r["MaDoanPhi"].ToString();
            this.TenDoanPhi = r["TenDoanPhi"].ToString();

        }
    }
}

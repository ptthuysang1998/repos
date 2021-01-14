using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Model
{
    class HocTap
    {
        public string MaSV { get; set; }
        public string MaLopHP { get; set; }



        public HocTap(string masv, string malophp)
        {
            this.MaSV = masv;
            this.MaLopHP = malophp;

        }
        public HocTap(DataRow r)
        {
            this.MaSV = r["MaSV"].ToString();
            this.MaLopHP = r["MaLopHP"].ToString();

        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sang
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietHoaDon
    {
        public long MaChiTietHD { get; set; }
        public string MaSach { get; set; }
        public int SoLuongMua { get; set; }
        public long MaHoaDon { get; set; }
        public string DaMua { get; set; }
    
        public virtual hoadon hoadon { get; set; }
        public virtual sach sach { get; set; }
    }
}
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
    
    public partial class GioHang
    {
        public long makh { get; set; }
        public string masach { get; set; }
        public long soluong { get; set; }
        public string tensach { get; set; }
        public long gia { get; set; }
        public string tacgia { get; set; }
    
        public virtual KhachHang KhachHang { get; set; }
        public virtual sach sach { get; set; }
    }
}
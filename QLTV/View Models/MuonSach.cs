//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLTV.View_Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MuonSach
    {
        public int MaMuon { get; set; }
        public string MaDocGia { get; set; }
        public string MaSach { get; set; }
        public System.DateTime NgayMuon { get; set; }
        public bool DaTra { get; set; }
        public System.DateTime NgayHen { get; set; }
        public int SoLuongMuon { get; set; }
        public decimal TienCoc { get; set; }
    
        public virtual DocGia DocGia { get; set; }
        public virtual Sach Sach { get; set; }
    }
}

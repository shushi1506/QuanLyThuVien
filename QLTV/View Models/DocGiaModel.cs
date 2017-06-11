using QLTV.View_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.View_Models
{
  public  class DocGiaModel
    {
        [Display(Name = "Mã độc giả")]
        [Editable(false)]
        public string MaDocGia { get; set; }
        [Display(Name = "Tên Độc Giả")]
        [Editable(false)]
        public string TenDocGia { get; set; }
        [Display(Name = "Ngày Sinh")]
        [Editable(false)]
        public string NgaySinh { get; set; }
        [Display(Name = "Giới Tính")]
        [Editable(false)]

        public string GioiTinh { get; set; }
        [Display(Name = "Địa Chỉ")]
        [Editable(false)]
        public string DiaChi { get; set; }
        [Display(Name = "Số CMT")]
        [Editable(false)]
        public string SoCMT { get; set; }
        [Display(Name = "Tiền Kí Gửi")]
        [Editable(false)]
        public decimal TienKiGui { get; set; }

        [Display(Name = "Tên Lớp")]
        [Editable(false)]
        public string TenLop { get; set; }

        [Display(Name = "Tên Khoa")]
        [Editable(false)]
        public string TenKhoa { get; set; }

        public DocGiaModel() { }
        public DocGiaModel(DocGia dg)
        {
            MaDocGia = dg.MaDocGia;
            TenDocGia = dg.TenDocGia;
            NgaySinh = dg.NgaySinh.ToString("dd/MM/yyyy");
            GioiTinh = dg.GioiTinh;
            DiaChi = dg.DiaChi;
            SoCMT = dg.SoCMT;
            TienKiGui = dg.TienKiGui;
            TenKhoa = dg.Khoa.TenKhoa;
            TenLop = dg.Lop.TenLop;
           
        }
        public static List<DocGiaModel> ToListByListDocGia(List<DocGia> docgia)
        {

            List<DocGiaModel> list = new List<DocGiaModel>();

            foreach (var item in docgia)
            {
                list.Add(new DocGiaModel(item));
            }
            return list;
        }
    }
}

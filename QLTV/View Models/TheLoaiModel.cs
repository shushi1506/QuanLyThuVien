using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.View_Models
{
  public  class TheLoaiModel
    {
        [Display(Name = "Mã thể loại")]
        [Editable(false)]
        public string MaTheLoai { get; set; }
        [Display(Name = "Tên thể loại")]
        [Editable(false)]
        public string TenTheLoai { get; set; }
        public TheLoaiModel() { }
        public TheLoaiModel(TheLoai theloai)
        {
            MaTheLoai = theloai.MaTheLoai;
            TenTheLoai = theloai.TenTheLoai;
        }
        public static List<TheLoaiModel> ToListByListTheLoai(List<TheLoai> theloai)
        {

            List<TheLoaiModel> list = new List<TheLoaiModel>();

            foreach (var item in theloai)
            {
                list.Add(new TheLoaiModel(item));
            }

            return list;
        }

    }
}

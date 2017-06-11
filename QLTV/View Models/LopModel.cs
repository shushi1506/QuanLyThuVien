using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.View_Models
{
  public  class LopModel
    {

        [Display(Name = "Mã Lớp")]
        [Editable(false)]
        public string MaLop { get; set; }
        [Display(Name = "Tên Lớp")]
        [Editable(false)]
        public string TenLop { get; set; }
        public LopModel() { }
        public LopModel(Lop Lop)
        {
            MaLop = Lop.MaLop;
            TenLop = Lop.TenLop;
        }
        public static List<LopModel> ToListByListLop(List<Lop> Lop)
        {

            List<LopModel> list = new List<LopModel>();

            foreach (var item in Lop)
            {
                list.Add(new LopModel(item));
            }

            return list;
        }
    }
}

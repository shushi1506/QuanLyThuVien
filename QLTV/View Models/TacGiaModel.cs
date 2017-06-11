using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.View_Models
{
  public  class TacGiaModel
    {
        [Display(Name = "Mã tác giả")]
        [Editable(false)]
        public string MaTacGia { get; set; }
        [Display(Name = "Tên tác giả")]
        [Editable(false)]
        public string TenTacGia { get; set; }
        public TacGiaModel() { }
        public TacGiaModel(TacGia tacgia)
        {
            MaTacGia = tacgia.MaTacGia;
            TenTacGia = tacgia.TenTacGia;
        }
        public static List<TacGiaModel> ToListByListTacGia(List<TacGia> tacgia)
        {

            List<TacGiaModel> list = new List<TacGiaModel>();

            foreach (var item in tacgia)
            {
                list.Add(new TacGiaModel(item));
            }

            return list;
        }
    }
}

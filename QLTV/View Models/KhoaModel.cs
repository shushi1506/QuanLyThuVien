using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.View_Models
{
   public class KhoaModel
    {
        [Display(Name = "Mã Khoa")]
        [Editable(false)]
        public string MaKhoa { get; set; }
        [Display(Name = "Tên Khoa")]
        [Editable(false)]
        public string TenKhoa { get; set; }
        public KhoaModel() { }
        public KhoaModel(Khoa Khoa)
        {
            MaKhoa = Khoa.MaKhoa;
            TenKhoa = Khoa.TenKhoa;
        }
        public static List<KhoaModel> ToListByListKhoa(List<Khoa> Khoa)
        {

            List<KhoaModel> list = new List<KhoaModel>();

            foreach (var item in Khoa)
            {
                list.Add(new KhoaModel(item));
            }

            return list;
        }
    }
}

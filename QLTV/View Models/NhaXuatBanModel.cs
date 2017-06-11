using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.View_Models
{
   public class NhaXuatBanModel
    {
        [Display(Name = "Mã nhà xuất bản")]
        [Editable(false)]
        public string MaNXB { get; set; }
        [Display(Name = "Tên nhà xuất bản")]
        [Editable(false)]
        public string TenNhaXB { get; set; }
        public NhaXuatBanModel() { }
        public NhaXuatBanModel(NhaXB nhaxb)
        {
            MaNXB = nhaxb.MaNXB;
            TenNhaXB = nhaxb.TenNhaXB;
        }
        public static List<NhaXuatBanModel> ToListByListNXB(List<NhaXB> nhaxb)
        {

            List<NhaXuatBanModel> list = new List<NhaXuatBanModel>();

            foreach (var item in nhaxb)
            {
                list.Add(new NhaXuatBanModel(item));
            }

            return list;
        }
    }
}

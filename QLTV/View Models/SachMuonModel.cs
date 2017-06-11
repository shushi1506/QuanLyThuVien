using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.View_Models
{
  public  class SachMuonModel
    {
        [Display(Name = "Mã mượn")]
        [Editable(false)]
        public int MaMuon { get; set; }
        [Display(Name = "Tên Sách")]
        [Editable(false)]
        public string TenSach { get; set; }
        [Display(Name = "Tên Độc giả")]
        [Editable(false)]
        public string TenDocGia { get; set; }
        [Display(Name = "Ngày Mượn")]
        [Editable(false)]
        public DateTime NgayMuon { get; set; }

        [Display(Name = "Ngày Trả")]
        [Editable(true)]
        public DateTime NgayHen { get; set; }

        [Display(Name = "Số lượng mượn")]
        [Editable(false)]
        public int SoLuongMuon { get; set; }
        [Display(Name = "Đã Trả")]
        [Editable(false)]
        public bool DaTra { get; set; }
        [Display(Name = "Tiền Cọc")]
        [Editable(false)]
        public string TienCoc { get; set; }

      public SachMuonModel(){}
        public SachMuonModel(MuonSach sach)
        {
            MaMuon = sach.MaMuon;
            TenSach = sach.Sach.TenSach;
            //  NgayMuon = sach.NgayMuon.ToString("dd/MM/yyyy");
            //  NgayHen = sach.NgayHen.ToString("dd/MM/yyyy");
            NgayMuon = sach.NgayMuon;
            NgayHen = sach.NgayHen;
            TenDocGia = sach.DocGia.TenDocGia;
            SoLuongMuon = sach.SoLuongMuon;
            DaTra = sach.DaTra;
            TienCoc= sach.TienCoc.ToString();
           
        }
        public static List<SachMuonModel> ToListByListSachMuon(List<MuonSach> sach)
        {

            List<SachMuonModel> list = new List<SachMuonModel>();

            foreach (var item in sach)
            {
                list.Add(new SachMuonModel(item));
            }

            return list;
        }
        public static SachMuonModel ToBySachMuon(MuonSach sach)
        {
            return new SachMuonModel(sach);
        }
    }
}

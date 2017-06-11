using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.View_Models
{
   public class SachModel
    {
        [Display(Name = "Mã sách")]
        [Editable(false)]
        public string MaSach { get; set; }
        [Display(Name = "Tên Sách")]
        [Editable(false)]
        public string TenSach { get; set; }
        [Display(Name = "Năm Xuất Bản")]
        [Editable(false)]
        public string NamXuatBan { get; set; }
        [Display(Name = "Số Trang")]
        [Editable(true)]

        public int SoTrang { get; set; }
        [Display(Name = "Số lượng sách")]
        [Editable(false)]
        public int TongSoSach{ get; set; }
        [Display(Name = "Thể Loại")]
        [Editable(false)]
        public string TenTheLoai { get; set; }
        [Display(Name = "Tên Tác Giả")]
        [Editable(false)]
        public string TenTacGia { get; set; }
     
        [Display(Name = "Đã Mượn")]
        [Editable(false)]
        public int LuongDaMuon { get; set; }
      
        [Display(Name = "Ten NXB")]
        [Editable(false)]
        public string TenNhaXB { get; set; }

        public SachModel() { }
        public SachModel(Sach sach)
        {
            MaSach = sach.MaSach;
            TenSach = sach.TenSach;
            NamXuatBan = sach.NamXuatBan.ToString("dd/MM/yyyy");
            SoTrang = sach.SoTrang;
            TongSoSach = sach.TongSoSach;
            LuongDaMuon = sach.LuongDaMuon;
            NhaXB nxb = sach.NhaXB;
            TheLoai tl = sach.TheLoai;
            TacGia tg = sach.TacGia;
            TenTheLoai = tl.TenTheLoai;
            TenTacGia = tg.TenTacGia;
            TenNhaXB = nxb.TenNhaXB;
        }
        public static List<SachModel> ToListByListSach(List<Sach> sach)
        {
           
            List<SachModel> list = new List<SachModel>();

            foreach (var item in sach)
            {
                list.Add(new SachModel(item));
            }

            return list;
        }
    }
}

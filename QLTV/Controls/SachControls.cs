
using QLTV.View_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Controls
{
   public class SachControls
    {

        QuanLyThuVien2Entities db;
        public SachControls()
        {
            db = new QuanLyThuVien2Entities();
        }

        public List<Sach> getAll()
        {
            try
            {
                return db.Saches.Select(m => m).ToList();
            }
            catch 
            {
                return null;
            }
        }
        public Sach getById(string Id)
        {
            try
            {
                return db.Saches.Single(m => m.MaSach == Id);
            }
            catch 
            {
                return null;
            }
        }
        public int checkchomuon(Sach sach)
        {
             return sach.TongSoSach - sach.LuongDaMuon;
        }
        public List<Sach> GetBySearch(string search)
        {
            try
            {
                search = search.ToLower();

                return db.Saches.Where(
                    m
                    => m.MaSach.Contains(search)
                    || m.TenSach.ToLower().Contains(search)
                    || m.TacGia.TenTacGia.ToLower().Contains(search)
                    || m.NhaXB.TenNhaXB.ToLower().Contains(search)
                    || m.TheLoai.TenTheLoai.ToLower().Contains(search)
                ).OrderByDescending(m => m.MaSach).ToList();
            }
            catch 
            {
                return new List<Sach>();
            }
        }
        public IEnumerable<string> getMaSach()
        {
            try
            {
                IEnumerable<string> query1 = db.Saches
                                            .OrderByDescending(s => s.MaSach)
                                            .Select(s => s.MaSach)
                                            .Take(1);
                return query1;
            }
            catch 
            {
                return null;
            }
        }
        public string GetMaSach()
        {
            string k = "";
            foreach (string i in this.getMaSach())
            {
                k = i;
            }
            int ma = Convert.ToInt16(k.Substring(1));
            ma += 1;
            string temp = "";
            if (ma < 10) temp = "S00" + ma;
            if (ma >= 10) temp = "S0" + ma;
            if (ma >= 100) temp = "S" + ma;
            return temp;
        }
        public bool Insert(Sach sach)
        {
            try
            {
                sach.LuongDaMuon = 0;
                sach.MaSach = GetMaSach();
                db.Saches.Add(sach);
                db.SaveChanges();

                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool Update(Sach sach)
        {
            try
            {
                Sach sachcu = getById(sach.MaSach);
                sachcu.TenSach = sach.TenSach;
                sachcu.NamXuatBan = sach.NamXuatBan;
                sachcu.SoTrang = sach.SoTrang;
                sachcu.TongSoSach = sach.TongSoSach;
                sachcu.LuongDaMuon = sach.LuongDaMuon;
                sachcu.MaNXB = sach.MaNXB;
                sachcu.ImageSach = sach.ImageSach;
                sachcu.MaTheLoai = sach.MaTheLoai;
                sachcu.MaTacGia = sach.MaTacGia;
                db.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool Delete(string Id)
        {
            try
            {
                db.Saches.Remove(getById(Id));

                db.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }


    }

}

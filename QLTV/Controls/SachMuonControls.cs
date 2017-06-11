using QLTV.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Controls
{
  public  class SachMuonControls
    {
        QuanLyThuVien2Entities db;
        public SachMuonControls()
        {
            db = new QuanLyThuVien2Entities();
        }

        public List<MuonSach> getAll()
        {
            try
            {
                return db.MuonSaches.Select(m => m).ToList();
            }
            catch
            {
                return null;
            }
        }
        public MuonSach getById(int Id)
        {
            try
            {
                return db.MuonSaches.Single(m => m.MaMuon == Id);
            }
            catch
            {
                return null;
            }
        }
        public List<MuonSach> getbyDocgia(DocGia docgia)
        {
            try
            {
                return db.MuonSaches.Where(m => m.DocGia.MaDocGia == docgia.MaDocGia).ToList();
            }
            catch 
            {
                return null;
            }
        }
        public IEnumerable<MuonSach> getChuaTra()
        {
            try
            {
                return db.MuonSaches.Where(m => m.DaTra == false);
            }
            catch 
            {
                return null;
            }
        }
        public List<string> getListMaDocGia(string sach)
        {
            try
            {
                return db.MuonSaches.Where(m => m.MaSach == sach).Select(m => m.MaDocGia).ToList();
            }
            catch 
            {
                return null;
            }
        }
        public List<MuonSach>getbyDocGiaMuon(DocGia docgia,bool bl)
        {
            try
            {
                return db.MuonSaches.Where(m => m.DocGia.MaDocGia == docgia.MaDocGia && m.DaTra==bl).ToList();
            }
            catch
            {
                return null;
            }
        }
        public Nullable<int> getTongSachMuon(Sach sach)
        {
            return (from ord in db.MuonSaches
                    where ord.MaSach == sach.MaSach && ord.DaTra==false
                    select ord.SoLuongMuon ).DefaultIfEmpty(0)
    .Sum();
        }
        public Nullable<decimal> getTongTienCoc(DocGia docgia)
        {
            //return (db.MuonSaches.Where(m => m.MaDocGia == docgia.MaDocGia && m.DaTra==false)
            //    .Select(m => m.TienCoc))
            //    .Sum();
            return (from ord in db.MuonSaches
                    where ord.MaDocGia == docgia.MaDocGia && ord.DaTra == false
                    select ord.TienCoc ).DefaultIfEmpty(0)
   .Sum();
        }
        public List<MuonSach> GetBySearch(string search)
        {
            try
            {
                search = search.ToLower();

                return db.MuonSaches.Where(
                    m
                    => m.MaSach.Contains(search)
                    || m.Sach.TenSach.ToLower().Contains(search)
                    || m.DocGia.TenDocGia.ToLower().Contains(search)

                ).OrderBy(m => m.MaMuon).ToList();
            }
            catch 
            {
                return new List<MuonSach>();
            }
        }
       
        public bool Insert(MuonSach sach)
        {
            try
            {
               
                db.MuonSaches.Add(sach);
                db.SaveChanges();

                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool Update(MuonSach sach)
        {
            try
            {
                MuonSach sachcu = getById(sach.MaMuon);
                sachcu.MaSach = sach.MaSach;
                sachcu.MaDocGia = sach.MaDocGia;
                sachcu.NgayHen = sach.NgayHen;
                sachcu.NgayMuon = sach.NgayMuon;
                sachcu.SoLuongMuon = sach.SoLuongMuon;
                sachcu.TienCoc = sach.TienCoc;
                sachcu.DaTra = sach.DaTra;
               
                db.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool Delete(int Id)
        {
            try
            {
                db.MuonSaches.Remove(getById(Id));

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

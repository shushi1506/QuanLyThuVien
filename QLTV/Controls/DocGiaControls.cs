
using QLTV.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Controls
{
   public class DocGiaControls
    {
        QuanLyThuVien2Entities db;
        public DocGiaControls()
        {
            db = new QuanLyThuVien2Entities();
        }

        public List<DocGia> getAll()
        {
            try
            {
                return db.DocGias.Select(m => m).ToList();
            }
            catch 
            {
                return null;
            }
        }
        public DocGia getById(string id)
        {
            try
            {
                return db.DocGias.Single(m => m.MaDocGia == id);
            }
            catch 
            {
                return null;
            }
        }
        public List<DocGia> getlistDocGiaByListMa(List<string> ma)
        {
            try
            {
                List<DocGia> dg = new List<DocGia>();
                foreach (var item in ma)
                {
                    dg.Add(getById(item));
                }
                return dg;
            }
            catch { return null; }
        }
        public List<DocGia> GetBySearch(string search)
        {
            try
            {
                search = search.ToLower();

                return db.DocGias.Where(
                    m
                    => m.MaDocGia.Contains(search)
                    || m.TenDocGia.ToLower().Contains(search)
                    || m.Khoa.TenKhoa.ToLower().Contains(search)
                    || m.Lop.TenLop.ToLower().Contains(search) 
                ).OrderByDescending(m => m.MaDocGia).ToList();
            }
            catch
            {
                return new List<DocGia>();
            }
        }
        public IEnumerable<string> getMadocgia()
        {
            try
            {
                IEnumerable<string> query1 = db.DocGias
                                            .OrderByDescending(s => s.MaDocGia)
                                            .Select(s => s.MaDocGia)
                                            .Take(1);
                return query1;
            }
            catch 
            {
                return null;
            }
        }
        public string GetMaDocGia()
        {
            string k = "";
            foreach (string i in this.getMadocgia())
            {
                k = i;
            }
            int ma = Convert.ToInt16(k.Substring(2));
            ma += 1;
            string temp = "";
            if (ma < 10) temp = "DG00" + ma;
            if (ma >= 10) temp = "DG0" + ma;
            if (ma >= 100) temp = "DG" + ma;
            return temp;
        }
        public bool Insert(DocGia dg)
        {
            try
            {
              
                dg.MaDocGia =GetMaDocGia();
                dg.TienKiGui = 0;
                db.DocGias.Add(dg);
                db.SaveChanges();

                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool Update(DocGia docgia)
        {
            try
            {
                DocGia temp = getById(docgia.MaDocGia);
                temp.MaKhoa = docgia.MaKhoa;
                temp.MaLop = docgia.MaLop;
                temp.NgaySinh = docgia.NgaySinh;
                temp.ImageDocGia = docgia.ImageDocGia;
               
                temp.GioiTinh = docgia.GioiTinh;
                temp.DiaChi = docgia.DiaChi;
                temp.TenDocGia = docgia.TenDocGia;
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
                db.DocGias.Remove(getById(Id));

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

using QLTV.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Controls
{
   public class TheLoaiControls
    {
        QuanLyThuVien2Entities db;
        public TheLoaiControls()
        {
            db = new QuanLyThuVien2Entities();
        }

        public List<TheLoai> getAll()
        {
            try
            {
                return db.TheLoais.Select(m => m).ToList();
            }
            catch 
            {
                return null;
            }
        }
        public TheLoai getById(string Matl)
        {
            try
            {
                return db.TheLoais.Single(m => m.MaTheLoai == Matl);
            }
            catch 
            {
                return null;
            }
        }
        public List<TheLoai> GetBySearch(string search)
        {
            try
            {
                search = search.ToLower();

                return db.TheLoais.Where(m => m.MaTheLoai.Contains(search) || m.TenTheLoai.ToLower().Contains(search)

                ).OrderBy(m => m.MaTheLoai).ToList();
            }
            catch 
            {
                return new List<TheLoai>();
            }
        }
        public bool Insert(TheLoai TheLoai)
        {
            try
            {
                db.TheLoais.Add(TheLoai);
                db.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool Update(TheLoai TheLoai)
        {
            try
            {
                TheLoai temp = getById(TheLoai.MaTheLoai); 
                temp.TenTheLoai = TheLoai.TenTheLoai;
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
                db.TheLoais.Remove(getById(Id));

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

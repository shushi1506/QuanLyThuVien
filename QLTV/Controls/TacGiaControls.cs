
using QLTV.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Controls
{
  public  class TacGiaControls
    {
        QuanLyThuVien2Entities db;
        public TacGiaControls()
        {
            db = new QuanLyThuVien2Entities();
        }

        public List<TacGia> getAll()
        {
            try
            {
                return db.TacGias.Select(m => m).ToList();
            }
            catch 
            {
                return null;
            }
        }
        public TacGia getById(string id)
        {
            try
            {
                return db.TacGias.Single(m => m.MaTacGia == id);
            }
            catch 
            {
                return null;
            }
        }
        public List<TacGia> GetBySearch(string search)
        {
            try
            {
                search = search.ToLower();

                return db.TacGias.Where(m => m.MaTacGia.Contains(search) || m.TenTacGia.ToLower().Contains(search)

                ).OrderBy(m => m.MaTacGia).ToList();
            }
            catch 
            {
                return new List<TacGia>();
            }
        }
        public bool Insert(TacGia TacGia)
        {
            try
            {
                db.TacGias.Add(TacGia);
                db.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool Update(TacGia TacGia)
        {
            try
            {
                TacGia temp = getById(TacGia.MaTacGia);           
                temp.TenTacGia = TacGia.TenTacGia;
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
                db.TacGias.Remove(getById(Id));

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

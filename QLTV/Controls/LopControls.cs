
using QLTV.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Controls
{
  
        public class LopControls
        {

            QuanLyThuVien2Entities db;
            public LopControls()
            {
                db = new QuanLyThuVien2Entities();
            }

            public List<Lop> getAll()
            {
                try
                {
                    return db.Lops.Select(m => m).ToList();
                }
                catch 
                {
                    return null;
                }
            }
            public Lop getById(string id)
            {
                try
                {
                    return db.Lops.Single(m => m.MaLop == id);
                }
                catch 
                {
                    return null;
                }
            }
            public List<Lop> GetBySearch(string search)
            {
                try
                {
                    search = search.ToLower();

                    return db.Lops.Where(m => m.MaLop.Contains(search) || m.TenLop.ToLower().Contains(search)

                    ).OrderBy(m => m.MaLop).ToList();
                }
                catch 
                {
                    return new List<Lop>();
                }
            }
            public bool Insert(Lop Lop)
            {
                try
                {
                    db.Lops.Add(Lop);
                    db.SaveChanges();
                    return true;
                }
                catch 
                {
                    return false;
                }
            }
            public bool Update(Lop Lop)
            {
                try
                {
                    Lop temp = getById(Lop.MaLop);
                  
                    temp.TenLop = Lop.TenLop;
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
                    db.Lops.Remove(getById(Id));

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

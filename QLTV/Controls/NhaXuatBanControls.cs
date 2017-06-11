using QLTV.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Controls
{
   public class NhaXuatBanControls
    {
        
        QuanLyThuVien2Entities db;
        public NhaXuatBanControls()
        {
            db = new QuanLyThuVien2Entities();
        }

        public List<NhaXB> getAll()
        {
            try
            {
                return db.NhaXBs.Select(m => m).ToList();
            }
            catch 
            {
                return null;
            }
        }
        public NhaXB getById(string id)
        {
            try
            {
                return db.NhaXBs.Single(m => m.MaNXB == id);
            }
            catch 
            {
                return null;
            }
        }
        public List<NhaXB> GetBySearch(string search)
        {
            try
            {
                search = search.ToLower();

                return db.NhaXBs.Where(m => m.MaNXB.Contains(search) || m.TenNhaXB.ToLower().Contains(search)

                ).OrderBy(m => m.MaNXB).ToList();
            }
            catch 
            {
                return new List<NhaXB>();
            }
        }
        public bool Insert(NhaXB NhaXB)
        {
            try
            {
                db.NhaXBs.Add(NhaXB);
                db.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool Update(NhaXB NhaXB)
        {
            try
            {
                NhaXB temp = getById(NhaXB.MaNXB);  
                temp.TenNhaXB = NhaXB.TenNhaXB;
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
                db.NhaXBs.Remove(getById(Id));

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

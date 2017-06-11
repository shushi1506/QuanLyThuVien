
using QLTV.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Controls
{
   public class KhoaControls
    {

        QuanLyThuVien2Entities db;
        public KhoaControls()
        {
            db = new QuanLyThuVien2Entities();
        }

        public List<Khoa> getAll()
        {
            try
            {
                return db.Khoas.Select(m => m).ToList();
            }
            catch 
            {
                return null;
            }
        }
        public Khoa getById(string id)
        {
            try
            {
                return db.Khoas.Single(m => m.MaKhoa == id);
            }
            catch 
            {
                return null;
            }
        }
        public List<Khoa> GetBySearch(string search)
        {
            try
            {
                search = search.ToLower();

                return db.Khoas.Where( m => m.MaKhoa.Contains(search) || m.TenKhoa.ToLower().Contains(search)
                   
                ).OrderBy(m => m.MaKhoa).ToList();
            }
            catch 
            {
                return new List<Khoa>();
            }
        }
        public bool Insert(Khoa khoa)
        {
            try
            { 
                db.Khoas.Add(khoa);
                db.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool Update(Khoa khoa)
        {
            try
            {
                Khoa temp = getById(khoa.MaKhoa);
             
                temp.TenKhoa = khoa.TenKhoa;
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
                db.Khoas.Remove(getById(Id));

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

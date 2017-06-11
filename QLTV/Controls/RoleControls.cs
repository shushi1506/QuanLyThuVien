using QLTV.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Controls
{
   public class RoleControls
    {
        QuanLyThuVien2Entities db;
        public RoleControls()
        {
            db = new QuanLyThuVien2Entities();
        }

        public List<Role> getAll()
        {
            try
            {
                return db.Roles.Select(m => m).ToList();
            }
            catch 
            {
                return null;
            }
        }
        public Role getById(int id)
        {
            try
            {
                return db.Roles.Single(m => m.IdRole == id);
            }
            catch 
            {
                return null;
            }
        }
        
       

        public bool Insert(Role Role)
        {
            try
            {
                db.Roles.Add(Role);
                db.SaveChanges();

                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool Update(Role Roleup)
        {
            try
            {
                Role roleadd = getById(Roleup.IdRole);
                roleadd.RoleName = Roleup.RoleName;
                roleadd.ViewAll = Roleup.ViewAll;
                roleadd.ViewDocGia = Roleup.ViewDocGia;
                roleadd.ViewSachMuon = Roleup.ViewSachMuon;
                roleadd.ViewSach = Roleup.ViewSach;
                roleadd.ViewThongKe = Roleup.ViewThongKe;
                roleadd.AddAll = Roleup.AddAll;
                roleadd.AddDocGia = Roleup.AddDocGia;
                roleadd.AddSachMuon = Roleup.AddSachMuon;
                roleadd.AddSach = Roleup.AddSach;
                roleadd.AddUser = Roleup.AddUser;
                roleadd.EditAll = Roleup.EditAll;
                roleadd.EditDocGia = Roleup.EditDocGia;
                roleadd.EditSachMuon = Roleup.EditSachMuon;
                roleadd.EditSach = Roleup.EditSach;
                roleadd.EditUser = Roleup.EditUser;
                roleadd.DeleteAll = Roleup.DeleteAll;
                roleadd.DeleteDocGia = Roleup.DeleteDocGia;
                roleadd.DeleteSachMuon = Roleup.DeleteSachMuon;
                roleadd.DeleteSach = Roleup.DeleteSach;
                roleadd.DeleteUser = Roleup.DeleteUser;
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
                db.Roles.Remove(getById(Id));
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

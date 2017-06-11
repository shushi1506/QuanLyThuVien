using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.View_Models
{
   public class RoleModel
    {
        [Display(Name = "Id Role")]
        [Editable(false)]
        public int IdRole { get; set; }
        [Display(Name = "RoleName")]
        [Editable(false)]
        public string RoleName { get; set; }
        [Display(Name = "View All")]
        [Editable(false)]
        public Nullable<bool> ViewAll { get; set; }
        [Display(Name = "View Sach")]
        [Editable(false)]
        public Nullable<bool> ViewSach { get; set; }
        [Display(Name = "View Doc Gia")]
        [Editable(false)]
        public Nullable<bool> ViewDocGia { get; set; }
        [Display(Name = "View Sach Muon")]
        [Editable(false)]
        public Nullable<bool> ViewSachMuon { get; set; }
        [Display(Name = "View Thong Ke")]
        [Editable(false)]
        public Nullable<bool> ViewThongKe { get; set; }
        [Display(Name = "View User")]
        [Editable(false)]
        public Nullable<bool> ViewUser { get; set; }
        //**
        [Display(Name = "Add All")]
        [Editable(false)]
        public Nullable<bool> AddAll { get; set; }
        [Display(Name = "Add Sach")]
        [Editable(false)]
        public Nullable<bool> AddSach { get; set; }
        [Display(Name = "Add Doc Gia")]
        [Editable(false)]
        public Nullable<bool> AddDocGia { get; set; }
        [Display(Name = "Add Sach Muon")]
        [Editable(false)]
        public Nullable<bool> AddSachMuon { get; set; }
        [Display(Name = "Add User")]
        [Editable(false)]
        public Nullable<bool> AddUser { get; set; }
        [Display(Name = "Edit All")]
        [Editable(false)]
        public Nullable<bool> EditAll { get; set; }
        [Display(Name = "Edit Sach")]
        [Editable(false)]
        public Nullable<bool> EditSach { get; set; }
        [Display(Name = "Edit Doc Gia")]
        [Editable(false)]
        public Nullable<bool> EditDocGia { get; set; }
        [Display(Name = "Edit Sach Muon")]
        [Editable(false)]
        public Nullable<bool> EditSachMuon { get; set; }  
        [Display(Name = "Edit User")]
        [Editable(false)]
        public Nullable<bool> EditUser { get; set; }
        [Display(Name = "Delete All")]
        [Editable(false)]
        public Nullable<bool> DeleteAll { get; set; }
        [Display(Name = "Delete Sach")]
        [Editable(false)]
        public Nullable<bool> DeleteSach { get; set; }
        [Display(Name = "Delete Doc Gia")]
        [Editable(false)]
        public Nullable<bool> DeleteDocGia { get; set; }
        [Display(Name = "Delete Sach Muon")]
        [Editable(false)]
        public Nullable<bool> DeleteSachMuon { get; set; }
        [Display(Name = "Delete User")]
        [Editable(false)]
        public Nullable<bool> DeleteUser { get; set; }
        public RoleModel() { }
        public RoleModel(Role r)
        {
            IdRole = r.IdRole;
            RoleName = r.RoleName;
            ViewAll = r.ViewAll;
            ViewDocGia = r.ViewDocGia;
            ViewSachMuon = r.ViewSachMuon;
            ViewSach = r.ViewSach;
            ViewThongKe = r.ViewThongKe;
            AddAll = r.AddAll;
            AddDocGia = r.AddDocGia;
            AddSachMuon = r.AddSachMuon;
            AddSach = r.AddSach;
            AddUser = r.AddUser;
            EditAll = r.EditAll;
            EditDocGia = r.EditDocGia;
            EditSachMuon = r.EditSachMuon;
            EditSach = r.EditSach;
            EditUser = r.EditUser;
            DeleteAll = r.DeleteAll;
            DeleteDocGia = r.DeleteDocGia;
            DeleteSachMuon = r.DeleteSachMuon;
            DeleteSach = r.DeleteSach;
            DeleteUser = r.DeleteUser;
        }
        public static List<RoleModel> ToListByListRole(List<Role> r)
        {

            List<RoleModel> list = new List<RoleModel>();

            foreach (var item in r)
            {
                list.Add(new RoleModel(item));
            }

            return list;
        }
    }
}

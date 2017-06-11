
using QLTV.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Controls
{
   public class UserControls
    {
        QuanLyThuVien2Entities db;
        public UserControls()
        {
            db = new QuanLyThuVien2Entities();
        }

        public List<User> getAll()
        {
            try
            {
                return db.Users.Select(m => m).ToList();
            }
            catch 
            {
                return null;
            }
        }
        public User getById(int id)
        {
            try
            {
                return db.Users.Single(m => m.IDUSER == id);
            }
            catch 
            {
                return null;
            }
        }

        public User getByUsernameAndPassword(string Username, string Password)
        {
            try
            {
                return db.Users
                    .Single(
                        m
                        => m.USERNAME.Equals(Username)
                        && m.PASSWORD.Equals(Password)
                    );
            }
            catch 
            {
                return null;
            }
        }
        public List<User> GetBySearch(string search)
        {
            try
            {
                search = search.ToLower();

                return db.Users.Where(
                    m
                    =>  m.USERNAME.ToLower().Contains(search)
                ).OrderByDescending(m => m.IDUSER).ToList();
            }
            catch 
            {
                return new List<User>();
            }
        }
        public Role getRole(string username)
        {

            try
            {
                var item = db.Users
                    .Single(
                        m
                        => m.USERNAME.Equals(username)
                    );
                return item.Role;
            }
            catch { return null; }
        }

        public bool Insert(User user)
        {
            try
            {     
                db.Users.Add(user);
                db.SaveChanges();

                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool Update(User User)
        {
            try
            {
                User user = getById(User.IDUSER);
                user.USERNAME = User.USERNAME;
                user.PASSWORD = User.PASSWORD;
                user.IdRole = User.IdRole;
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
                db.Users.Remove(getById(Id));
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

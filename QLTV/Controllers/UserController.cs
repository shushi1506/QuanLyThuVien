using QLTV.Controls;
using QLTV.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Controllers
{
  public  class UserController
    {
        private UserControls _UserControls
        {
            get
            {
                return new UserControls();
            }
        }
        public List<UserModel> ListUser
        {
            get
            {
                return UserModel.ToListByListUser(_UserControls.getAll());
            }
        }
        public User GetById(int Id)
        {
            return _UserControls.getById(Id);
        }
        public List<User> GetAllUser
        {
            get
            {
                return _UserControls.getAll();
            }
        }
        public Role GetRolebyUserName(string username)
        {
            return _UserControls.getRole(username);
        }
        public User User { get; set; }
        public bool Login(string Username, string Password)
        {
            User = _UserControls.getByUsernameAndPassword(Username, (Password));
            if (User != null)
            {
                return true;
            }

            return false;
        }
        public int GetId(string Username, string Password)
        {
            User = _UserControls.getByUsernameAndPassword(Username, (Password));
            if (User != null)
            {
                return User.IDUSER;
            }

            return -1;
        }
        public bool Add(User User)
        {
            return _UserControls.Insert(User);
        }
        public bool Edit(User User)
        {
            return _UserControls.Update(User);
        }
        public bool Delete(int Id)
        {
            return _UserControls.Delete(Id);
        }
        public List<UserModel> GetListTableModelBySearch(string search)
        {
            return UserModel.ToListByListUser(_UserControls.GetBySearch(search));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.View_Models
{
  public  class UserModel
    {
        [Display(Name = "Id user")]
        [Editable(false)]
        public int IDUSER { get; set; }
        [Display(Name = "UserName")]
        [Editable(false)]
        public string USERNAME { get; set; }
        [Display(Name = "PASSWORD")]
        [Editable(false)]
        public string PASSWORD { get; set; }
        [Display(Name = "ROLE")]
        [Editable(false)]
        public string ROLEName { get; set; }
        public UserModel() { }
        public UserModel(User User)
        {
            IDUSER = User.IDUSER;
            USERNAME = User.USERNAME;
            PASSWORD = User.PASSWORD;
            ROLEName = User.Role.RoleName;
        }
        public static List<UserModel> ToListByListUser(List<User> User)
        {

            List<UserModel> list = new List<UserModel>();

            foreach (var item in User)
            {
                list.Add(new UserModel(item));
            }

            return list;
        }
    }
}

using QLTV.Controls;
using QLTV.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Controllers
{
   public class RoleController
    {
        private RoleControls _RoleControls
        {
            get
            {
                return new RoleControls();
            }
        }
        public List<RoleModel> ListRole
        {
            get
            {
                return RoleModel.ToListByListRole(_RoleControls.getAll());
            }
        }
        public Role GetById(int Id)
        {
            return _RoleControls.getById(Id);
        }
        public List<Role> GetAllRole
        {
            get
            {
                return _RoleControls.getAll();
            }
        }
        
        public bool Add(Role Role)
        {
            return _RoleControls.Insert(Role);
        }
        public bool Edit(Role Role)
        {
            return _RoleControls.Update(Role);
        }
        public bool Delete(int Id)
        {
            return _RoleControls.Delete(Id);
        }
        
    }
}

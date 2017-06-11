
using QLTV.Controls;
using QLTV.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Controllers
{
  public  class NXBController
    {
        private NhaXuatBanControls _NhaXuatBanControls
        {
            get
            {
                return new NhaXuatBanControls();
            }
        }
        public List<NhaXuatBanModel> ListNXB
        {
            get
            {
                return NhaXuatBanModel.ToListByListNXB(_NhaXuatBanControls.getAll());
            }
        }
        public NhaXB GetById(string Id)
        {
            return _NhaXuatBanControls.getById(Id);
        }
        public List<NhaXB> GetAllNxb
        {
            get
            {
                return _NhaXuatBanControls.getAll();
            }
        }
        public bool Add(NhaXB NhaXB)
        {
            return _NhaXuatBanControls.Insert(NhaXB);
        }
        public bool Edit(NhaXB NhaXB)
        {
            return _NhaXuatBanControls.Update(NhaXB);
        }
        public bool Delete(string Id)
        {
            return _NhaXuatBanControls.Delete(Id);
        }
        public List<NhaXuatBanModel> GetListTableModelBySearch(string search)
        {
            return NhaXuatBanModel.ToListByListNXB(_NhaXuatBanControls.GetBySearch(search));
        }
    }
}

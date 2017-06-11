
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.View_Models;
using QLTV.Controls;

namespace QLTV.Controllers
{
  public  class TacGiaController
    {
        private TacGiaControls _tacgiaControls
        {
            get
            {
                return new TacGiaControls();
            }
        }
        public List<TacGiaModel> ListTacGia
        {
            get
            {
                return TacGiaModel.ToListByListTacGia(_tacgiaControls.getAll());
            }
        }
        public TacGia GetById(string Id)
        {
            return _tacgiaControls.getById(Id);
        }
        public List<TacGia> GetAllTacgia
        {
            get
            {
                return _tacgiaControls.getAll();
            }
        }
        public bool Add(TacGia TacGia)
        {
            return _tacgiaControls.Insert(TacGia);
        }
        public bool Edit(TacGia TacGia)
        {
            return _tacgiaControls.Update(TacGia);
        }
        public bool Delete(string Id)
        {
            return _tacgiaControls.Delete(Id);
        }
        public List<TacGiaModel> GetListTableModelBySearch(string search)
        {
            return TacGiaModel.ToListByListTacGia(_tacgiaControls.GetBySearch(search));
        }
    }
}

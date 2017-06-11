using QLTV.Controls;
using QLTV.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Controllers
{
   public class KhoaController
    {
        private KhoaControls _khoaControls
        {
            get
            {
                return new KhoaControls();
            }
        }
        public List<KhoaModel> ListKhoa
        {
            get
            {
                return KhoaModel.ToListByListKhoa(_khoaControls.getAll());
            }
        }
        public List<Khoa> GetAllKhoa
        {
            get
            {
                return _khoaControls.getAll();
            }
        }
        public Khoa GetById(string Id)
        {
            return _khoaControls.getById(Id);
        }

        public bool Add(Khoa Khoa)
        {
            return _khoaControls.Insert(Khoa);
        }
        public bool Edit(Khoa Khoa)
        {
            return _khoaControls.Update(Khoa);
        }
        public bool Delete(string Id)
        {
            return _khoaControls.Delete(Id);
        }
        public List<KhoaModel> GetListTableModelBySearch(string search)
        {
            return KhoaModel.ToListByListKhoa(_khoaControls.GetBySearch(search));
        }
    }
}

using QLTV.Controls;
using QLTV.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Controllers
{
 public   class TheLoaiController
    {
        private TheLoaiControls _theloaiControls
        {
            get
            {
                return new TheLoaiControls();
            }
        }
        public List<TheLoaiModel> ListTheLoai
        {
            get
            {
                return TheLoaiModel.ToListByListTheLoai(_theloaiControls.getAll());
            }
        }
        public TheLoai GetById(string Id)
        {
            return _theloaiControls.getById(Id);
        }
        public List<TheLoai> GetAllTheLoai
        {
            get
            {
                return _theloaiControls.getAll();
            }
        }
        public bool Add(TheLoai TheLoai)
        {
            return _theloaiControls.Insert(TheLoai);
        }
        public bool Edit(TheLoai TheLoai)
        {
            return _theloaiControls.Update(TheLoai);
        }
        public bool Delete(string Id)
        {
            return _theloaiControls.Delete(Id);
        }
        public List<TheLoaiModel> GetListTableModelBySearch(string search)
        {
            return TheLoaiModel.ToListByListTheLoai(_theloaiControls.GetBySearch(search));
        }

    }
}

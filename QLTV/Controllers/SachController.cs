using QLTV.Controls;
using QLTV.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QLTV.Controllers
{
   public class SachController
    {
        private SachControls _sachControls
        {
            get
            {
                return new SachControls();
            }
        }
        public List<SachModel> ListSach
        {
            get
            {
                return SachModel.ToListByListSach(_sachControls.getAll());
            }
        }
        public List<Sach> GetAllSach
        {
            get
            {
                return _sachControls.getAll();
            }
        }
        public Sach GetById(string Id)
        {
            return _sachControls.getById(Id);
        }
       public int CheckChoMuon(Sach sach)
        {
         
            return (_sachControls.checkchomuon(sach));
        }
        public bool Add(Sach sach)
        {
            return _sachControls.Insert(sach);
        }
        public bool Edit(Sach sach)
        {
            return _sachControls.Update(sach);
        }
        public bool Delete(string Id)
        {
            return _sachControls.Delete(Id);
        }
        public List<SachModel> GetListTableModelBySearch(string search)
        {
            return SachModel.ToListByListSach(_sachControls.GetBySearch(search));
        }

    }
}


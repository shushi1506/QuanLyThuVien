using QLTV.Controls;
using QLTV.View_Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Controllers
{
  public class LopController
    {

        private LopControls _LopControls
        {
            get
            {
                return new LopControls();
            }
        }
        public List<LopModel> ListLop
        {
            get
            {
                return LopModel.ToListByListLop(_LopControls.getAll());
            }
        }
        public Lop GetById(string Id)
        {
            return _LopControls.getById(Id);
        }
        public List<Lop> GetAllLop
        {
            get
            {
                return _LopControls.getAll();
            }
        }
        public bool Add(Lop Lop)
        {
            return _LopControls.Insert(Lop);
        }
        public bool Edit(Lop Lop)
        {
            return _LopControls.Update(Lop);
        }
        public bool Delete(string Id)
        {
            return _LopControls.Delete(Id);
        }
        public List<LopModel> GetListTableModelBySearch(string search)
        {
            return LopModel.ToListByListLop(_LopControls.GetBySearch(search));
        }
    }
}

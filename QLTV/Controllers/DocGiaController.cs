using QLTV.Controls;


using QLTV.View_Models;
using System.Collections.Generic;

namespace QLTV.Controllers
{
  public  class DocGiaController
    {
        private DocGiaControls _docgiaControls
        {
            get
            {
                return new DocGiaControls();
            }
        }
        public List<DocGiaModel> Listdocgia
        {
            get
            {
                return DocGiaModel.ToListByListDocGia(_docgiaControls.getAll());
            }
        }
        public List<DocGiaModel> GetDocGiaByListMa(List<string> ma)
        {
            return DocGiaModel.ToListByListDocGia(_docgiaControls.getlistDocGiaByListMa(ma));
        }
        public DocGia GetById(string Id)
        {
            return _docgiaControls.getById(Id);
        }

        public List<DocGia> GetAllDocGia
        {
            get
            {
                return _docgiaControls.getAll();
            }
        }
        public bool Add(DocGia dg)
        {
            return _docgiaControls.Insert(dg);
        }
        public bool Edit(DocGia docgia)
        {
            return _docgiaControls.Update(docgia);
        }
        public bool Delete(string Id)
        {
            return _docgiaControls.Delete(Id);
        }
        public List<DocGiaModel> GetListTableModelBySearch(string search)
        {
            return DocGiaModel.ToListByListDocGia(_docgiaControls.GetBySearch(search));
        }
    }
}

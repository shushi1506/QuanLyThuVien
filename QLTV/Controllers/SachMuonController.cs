
using QLTV.Controls;
using QLTV.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Controllers
{
   public class SachMuonController
    {
        private SachMuonControls _sachControls
        {
            get
            {
                return new SachMuonControls();
            }
        }
        public List<SachMuonModel> ListSach
        {
            get
            {
                return SachMuonModel.ToListByListSachMuon(_sachControls.getAll());
            }
        }
        public IEnumerable<MuonSach> GETCHUATRA
        {
            get { return _sachControls.getChuaTra(); }
        }
        public List<string>GetListMaDocGia(string masach)
        {
            return _sachControls.getListMaDocGia(masach);
        }
        public MuonSach GetById(int Id)
        {
            return _sachControls.getById(Id);
        }
        public List<MuonSach> GetAllMuonSach
        {
            get
            {
                return _sachControls.getAll();
            }
        }
        public List<SachMuonModel> GetSachMuonTableByDocGia(DocGia docgia)
        {   
               return SachMuonModel.ToListByListSachMuon(_sachControls.getbyDocgia(docgia));   
        }
        public List<SachMuonModel> GetSachMuonTableByDocGiaMuon(DocGia docgia,bool bl)
        {
            return SachMuonModel.ToListByListSachMuon(_sachControls.getbyDocGiaMuon(docgia,bl));
        }
        public Nullable<int> GetTongSachMuon(Sach sach)
        {
            return _sachControls.getTongSachMuon(sach);
        }
        public Nullable<decimal> GetTongTienCoc(DocGia  docgia)
        {
            return _sachControls.getTongTienCoc(docgia);
        }
        public bool Add(MuonSach sach)
        {
            return _sachControls.Insert(sach);
        }
        public bool Edit(MuonSach sach)
        {
            return _sachControls.Update(sach);
        }
        public bool Delete(int Id)
        {
            return _sachControls.Delete(Id);
        }
        public List<SachMuonModel> GetListTableModelBySearch(string search)
        {
            return SachMuonModel.ToListByListSachMuon(_sachControls.GetBySearch(search));
        }
        public SachMuonModel GetListTableModelById(int id)
        {
            return SachMuonModel.ToBySachMuon(_sachControls.getById(id));
        }
    }
}

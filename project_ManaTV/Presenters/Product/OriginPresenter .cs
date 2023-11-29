using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using project_ManaTV.Models;
using project_ManaTV.Repository;

namespace project_ManaTV.Presenters
{
    public class OriginPresenter
    {
        private OriginRepository _originRepository;
        public List<Origin> ListOriginRender { get; set; }


        //Search
        private bool isSearch = false;

        private PaginationPresenter<Origin> pgController;

        public OriginPresenter()
        {
            _originRepository = new OriginRepository();

        }

        public List<Origin> GetListByPagination(bool isDeleted = false)
        {
            if(!isSearch) pgController.UpdateData(GetAll(isDeleted));
            return pgController.GetListByPagination();
        }

        public void SetPagination(BunifuButton btn1, BunifuButton btn2, BunifuButton btn3, BunifuButton btnPrev, BunifuButton btnNext, BunifuDropdown dropdown)
        {
            pgController = new PaginationPresenter<Origin>(_originRepository.GetAll(),btn1, btn2, btn3, btnPrev, btnNext, dropdown);
        }

        public void ResetPagination(bool isDeleted = false)
        {
            isSearch = false;
            pgController.ReInit(1, 10, GetAll(isDeleted));
        }

        public List<Origin> Search(string searchKey, string filterBy, bool isDeleted = false)
        {
            isSearch = true;
            var lstResSearch = new List<Origin>();
            searchKey = searchKey.ToLower();
            if (filterBy == "id") lstResSearch = GetAll(isDeleted).Where(x => x.Id.ToString().Contains(searchKey)).ToList();
            else if (filterBy == "name") lstResSearch = GetAll(isDeleted).Where(x => x.Name.ToLower().Contains(searchKey)).ToList();
            pgController.ReInit(1, 10 ,lstResSearch);
            return pgController.GetListByPagination();
        }

        public List<Origin> GetAll(bool isDeleted= false)
        {
            return _originRepository.GetAll().ToList();
        }

        public Origin GetById(int id)
        {
            return _originRepository.GetById(id);
        }

        public void AddNew(Origin origin)
        {
            //origin.IsDeleted = false;
            _originRepository.AddNew(origin);
        }

        public void Update(Origin origin)
        {
            //origin.IsDeleted = false;
            _originRepository.Update(origin);
        }

        public void Delete(int id)
        {
            _originRepository.Delete(id);
        }



    }
}

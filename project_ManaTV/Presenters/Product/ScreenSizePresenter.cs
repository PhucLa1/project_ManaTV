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
    public class ScreenSizePresenter
    {
        private ScreenSizeRepository _screenSizeRepository;
        public List<ScreenSize> ListScreenSizeRender { get; set; }


        //Search
        private bool isSearch = false;

        private PaginationPresenter<ScreenSize> pgController;

        public ScreenSizePresenter()
        {
            _screenSizeRepository = new ScreenSizeRepository();

        }

        public List<ScreenSize> GetListByPagination(bool isDeleted = false)
        {
            if(!isSearch) pgController.UpdateData(GetAll(isDeleted));
            return pgController.GetListByPagination();
        }

        public void SetPagination(BunifuButton btn1, BunifuButton btn2, BunifuButton btn3, BunifuButton btnPrev, BunifuButton btnNext, BunifuDropdown dropdown)
        {
            pgController = new PaginationPresenter<ScreenSize>(_screenSizeRepository.GetAll(),btn1, btn2, btn3, btnPrev, btnNext, dropdown);
        }

        public void ResetPagination(bool isDeleted = false)
        {
            isSearch = false;
            pgController.ReInit(1, 10, GetAll(isDeleted));
        }

        public List<ScreenSize> Search(string searchKey, string filterBy, bool isDeleted = false)
        {
            isSearch = true;
            var lstResSearch = new List<ScreenSize>();
            searchKey = searchKey.ToLower();
            if (filterBy == "id") lstResSearch = GetAll(isDeleted).Where(x => x.Id.ToString().Contains(searchKey)).ToList();
            else if (filterBy == "size") lstResSearch = GetAll(isDeleted).Where(x => x.Screen_size.ToString().Contains(searchKey)).ToList();
            pgController.ReInit(1, 10 ,lstResSearch);
            return pgController.GetListByPagination();
        }

        public List<ScreenSize> GetAll(bool isDeleted= false)
        {
            return _screenSizeRepository.GetAll().ToList();
        }

        public ScreenSize GetById(int id)
        {
            return _screenSizeRepository.GetById(id);
        }

       

        public void AddNew(ScreenSize screenSize)
        {
            //screenSize.IsDeleted = false;
            _screenSizeRepository.AddNew(screenSize);
        }

        public void Update(ScreenSize screenSize)
        {
            //screenSize.IsDeleted = false;
            _screenSizeRepository.Update(screenSize);
        }

        public void Delete(int id)
        {
            _screenSizeRepository.Delete(id);
        }

    }
}

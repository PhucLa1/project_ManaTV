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
    public class ScreenPresenter
    {
        private ScreenRepository _screenRepository;
        public List<Screen> ListScreenRender { get; set; }


        //Search
        private bool isSearch = false;

        private PaginationPresenter<Screen> pgController;

        public ScreenPresenter()
        {
            _screenRepository = new ScreenRepository();

        }

        public List<Screen> GetListByPagination(bool isDeleted = false)
        {
            if(!isSearch) pgController.UpdateData(GetAll(isDeleted));
            return pgController.GetListByPagination();
        }

        public void SetPagination(BunifuButton btn1, BunifuButton btn2, BunifuButton btn3, BunifuButton btnPrev, BunifuButton btnNext, BunifuDropdown dropdown)
        {
            pgController = new PaginationPresenter<Screen>(_screenRepository.GetAll(),btn1, btn2, btn3, btnPrev, btnNext, dropdown);
        }

        public void ResetPagination(bool isDeleted = false)
        {
            isSearch = false;
            pgController.ReInit(1, 10, GetAll(isDeleted));
        }

        public List<Screen> Search(string searchKey, string filterBy, bool isDeleted = false)
        {
            isSearch = true;
            var lstResSearch = new List<Screen>();
            searchKey = searchKey.ToLower();
            if (filterBy == "id") lstResSearch = GetAll(isDeleted).Where(x => x.Id.ToString().Contains(searchKey)).ToList();
            else if (filterBy == "name") lstResSearch = GetAll(isDeleted).Where(x => x.Name.ToLower().Contains(searchKey)).ToList();
            pgController.ReInit(1, 10 ,lstResSearch);
            return pgController.GetListByPagination();
        }

        public List<Screen> GetAll(bool isDeleted= false)
        {
            return _screenRepository.GetAll().ToList();
        }

        public Screen GetById(int id)
        {
            return _screenRepository.GetById(id);
        }

       

        public void AddNew(Screen screen)
        {
            //screen.IsDeleted = false;
            _screenRepository.AddNew(screen);
        }

        public void Update(Screen screen)
        {
            //screen.IsDeleted = false;
            _screenRepository.Update(screen);
        }

        public void Delete(int id)
        {
            _screenRepository.Delete(id);
        }

    }
}

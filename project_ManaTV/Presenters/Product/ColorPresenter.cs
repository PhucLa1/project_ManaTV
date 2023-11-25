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
    public class ColorPresenter
    {
        private ColorRepository _colorRepository;
        public List<Colors> ListColorRender { get; set; }


        //Search
        private bool isSearch = false;

        private PaginationPresenter<Colors> pgController;

        public ColorPresenter()
        {
            _colorRepository = new ColorRepository();

        }

        public List<Colors> GetListByPagination(bool isDeleted = false)
        {
            if(!isSearch) pgController.UpdateData(GetAll(isDeleted));
            return pgController.GetListByPagination();
        }

        public void SetPagination(BunifuButton btn1, BunifuButton btn2, BunifuButton btn3, BunifuButton btnPrev, BunifuButton btnNext, BunifuDropdown dropdown)
        {
            pgController = new PaginationPresenter<Colors>(_colorRepository.GetAll(),btn1, btn2, btn3, btnPrev, btnNext, dropdown);
        }

        public void ResetPagination(bool isDeleted = false)
        {
            isSearch = false;
            pgController.ReInit(1, 10, GetAll(isDeleted));
        }

        public List<Colors> Search(string searchKey, string filterBy, bool isDeleted = false)
        {
            isSearch = true;
            var lstResSearch = new List<Colors>();
            searchKey = searchKey.ToLower();
            if (filterBy == "id") lstResSearch = GetAll(isDeleted).Where(x => x.Id.ToString().Contains(searchKey)).ToList();
            else if (filterBy == "r") lstResSearch = GetAll(isDeleted).Where(x => x.R.ToString().Contains(searchKey)).ToList();
            else if (filterBy == "g") lstResSearch = GetAll(isDeleted).Where(x => x.G.ToString().Contains(searchKey)).ToList();
            else if (filterBy == "b") lstResSearch = GetAll(isDeleted).Where(x => x.B.ToString().Contains(searchKey)).ToList();
            else if (filterBy == "name") lstResSearch = GetAll(isDeleted).Where(x => x.color_name.ToLower().Contains(searchKey)).ToList();
            else if (filterBy == "r,g,b")
            {
                string[] rgb = searchKey.Split(',');
                lstResSearch = GetAll(isDeleted).Where(x => x.R.ToString() == rgb[0]  && x.G.ToString() == rgb[1] && x.B.ToString() == rgb[2]) .ToList();
            }
            pgController.ReInit(1, 10 ,lstResSearch);
            return pgController.GetListByPagination();
        }

        public List<Colors> GetAll(bool isDeleted= false)
        {
            return _colorRepository.GetAll().ToList();
        }

        public Colors GetById(int id)
        {
            return _colorRepository.GetById(id);
        }

        public void AddNew(Colors color)
        {
            //brand.IsDeleted = false;
            _colorRepository.AddNew(color);
        }

        public void Update(Colors color)
        {
            //brand.IsDeleted = false;
            _colorRepository.Update(color);
        }

        public void Delete(int id)
        {
            _colorRepository.Delete(id);
        }
    }
}

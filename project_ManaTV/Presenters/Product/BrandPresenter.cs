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
    public class BrandPresenter
    {
        private BrandRepository _brandRepository;
        public List<Brand> ListBrandRender { get; set; }


        //Search
        private bool isSearch = false;

        private PaginationPresenter<Brand> pgController;

        public BrandPresenter()
        {
            _brandRepository = new BrandRepository();

        }

        public List<Brand> GetListByPagination(bool isDeleted = false)
        {
            if(!isSearch) pgController.UpdateData(GetAll(isDeleted));
            return pgController.GetListByPagination();
        }

        public void SetPagination(BunifuButton btn1, BunifuButton btn2, BunifuButton btn3, BunifuButton btnPrev, BunifuButton btnNext, BunifuDropdown dropdown)
        {
            pgController = new PaginationPresenter<Brand>(_brandRepository.GetAll(),btn1, btn2, btn3, btnPrev, btnNext, dropdown);
        }

        public void ResetPagination(bool isDeleted = false)
        {
            isSearch = false;
            pgController.ReInit(1, 10, GetAll(isDeleted));
        }

        public List<Brand> Search(string searchKey, string filterBy, bool isDeleted = false)
        {
            isSearch = true;
            var lstResSearch = new List<Brand>();
            searchKey = searchKey.ToLower();
            if (filterBy == "id") lstResSearch = GetAll(isDeleted).Where(x => x.Id.ToString().Contains(searchKey)).ToList();
            else if (filterBy == "name") lstResSearch = GetAll(isDeleted).Where(x => x.Name.ToLower().Contains(searchKey)).ToList();
            else if (filterBy == "address") lstResSearch = GetAll(isDeleted).Where(x => x.Address.ToLower().Contains(searchKey)).ToList();
            pgController.ReInit(1, 10 ,lstResSearch);
            return pgController.GetListByPagination();
        }

        public List<Brand> GetAll(bool isDeleted= false)
        {
            return _brandRepository.GetAll().ToList();
        }

        public Brand GetById(int id)
        {
            return _brandRepository.GetById(id);
        }

       

        public void AddNew(Brand brand)
        {
            //brand.IsDeleted = false;
            _brandRepository.AddNew(brand);
        }

        public void Update(Brand brand)
        {
            //brand.IsDeleted = false;
            _brandRepository.Update(brand);
        }

        public void Delete(int id)
        {
            _brandRepository.Delete(id);
        }



    }
}

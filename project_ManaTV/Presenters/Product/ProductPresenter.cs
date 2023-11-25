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
    public class ProductPresenter
    {
        private ProductRepository _productRepository;
        private BrandRepository _brandRepository;
        public List<Product> ListProductRender { get; set; }


        //Search
        private bool isSearch = false;

        private PaginationPresenter<ProductViewModel> pgController;

        public ProductPresenter()
        {
            _productRepository = new ProductRepository();
            _brandRepository = new BrandRepository();

        }

        public List<ProductViewModel> GetListByPagination(bool isDeleted = false)
        {
            if(!isSearch) pgController.UpdateData(GetAll(isDeleted));
            return pgController.GetListByPagination();
        }

        public void SetPagination(BunifuButton btn1, BunifuButton btn2, BunifuButton btn3, BunifuButton btnPrev, BunifuButton btnNext, BunifuDropdown dropdown)
        {
            pgController = new PaginationPresenter<ProductViewModel>(_productRepository.GetAll(),btn1, btn2, btn3, btnPrev, btnNext, dropdown);
        }

        public void ResetPagination(bool isDeleted = false)
        {
            isSearch = false;
            pgController.ReInit(1, 10, GetAll(isDeleted));
        }

        public List<ProductViewModel> Search(string searchKey, string filterBy, bool isDeleted = false)
        {
            isSearch = true;
            var lstResSearch = new List<ProductViewModel>();
            searchKey = searchKey.ToLower();
            if (filterBy == "id") lstResSearch = GetAll(isDeleted).Where(x => x.Id.ToString().Contains(searchKey)).ToList();
            else if (filterBy == "name") lstResSearch = GetAll(isDeleted).Where(x => x.Name.ToLower().Contains(searchKey)).ToList();
    
            pgController.ReInit(1, 10 ,lstResSearch);
            return pgController.GetListByPagination();
        }

        public List<ProductViewModel> GetAll(bool isDeleted= false)
        {
            return _productRepository.GetAll().ToList();
        }
        public List<Brand> GetAllBrand(bool isDeleted = false)
        {
            return _brandRepository.GetAll().ToList();
        }
        public ProductViewModel GetById(int id)
        {
            return _productRepository.GetById(id);
        }

       

        public void AddNew(Product product)
        {
            //product.IsDeleted = false;
            _productRepository.AddNew(product);
        }

        public void Update(Product product)
        {
            //product.IsDeleted = false;
            _productRepository.Update(product);
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }



    }
}

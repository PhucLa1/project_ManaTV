﻿using System;
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
    public class DesignPresenter
    {
        private DesignRepository _designRepository;
        public List<Design> ListDesignRender { get; set; }


        //Search
        private bool isSearch = false;

        private PaginationPresenter<Design> pgController;

        public DesignPresenter()
        {
            _designRepository = new DesignRepository();

        }

        public List<Design> GetListByPagination(bool isDeleted = false)
        {
            if(!isSearch) pgController.UpdateData(GetAll(isDeleted));
            return pgController.GetListByPagination();
        }

        public void SetPagination(BunifuButton btn1, BunifuButton btn2, BunifuButton btn3, BunifuButton btnPrev, BunifuButton btnNext, BunifuDropdown dropdown)
        {
            pgController = new PaginationPresenter<Design>(_designRepository.GetAll(),btn1, btn2, btn3, btnPrev, btnNext, dropdown);
        }

        public void ResetPagination(bool isDeleted = false)
        {
            isSearch = false;
            pgController.ReInit(1, 10, GetAll(isDeleted));
        }

        public List<Design> Search(string searchKey, string filterBy, bool isDeleted = false)
        {
            isSearch = true;
            var lstResSearch = new List<Design>();
            searchKey = searchKey.ToLower();
            if (filterBy == "id") lstResSearch = GetAll(isDeleted).Where(x => x.Id.ToString().Contains(searchKey)).ToList();
            else if (filterBy == "name") lstResSearch = GetAll(isDeleted).Where(x => x.Name.ToLower().Contains(searchKey)).ToList();
            pgController.ReInit(1, 10 ,lstResSearch);
            return pgController.GetListByPagination();
        }

        public List<Design> GetAll(bool isDeleted= false)
        {
            return _designRepository.GetAll().ToList();
        }

        public Design GetById(int id)
        {
            return _designRepository.GetById(id);
        }

       

        public void AddNew(Design design)
        {
            //design.IsDeleted = false;
            _designRepository.AddNew(design);
        }

        public void Update(Design design)
        {
            //design.IsDeleted = false;
            _designRepository.Update(design);
        }

        public void Delete(int id)
        {
            _designRepository.Delete(id);
        }

    }
}